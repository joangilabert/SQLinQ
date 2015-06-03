# README #

This README would normally document whatever steps are necessary to get your application up and running.

### What is this repository for? ###

* Quick summary
* Version
* [Learn Markdown](https://bitbucket.org/tutorials/markdowndemo)

### How do I get set up? ###

* Summary of set up
* Configuration
* Dependencies
* Database configuration
* How to run tests
* Deployment instructions

### Contribution guidelines ###

* Writing tests
* Code review
* Other guidelines

### Who do I talk to? ###

* Repo owner or admin
* Other community or team contact
SQLinq: Use LINQ to generate Ad-Hoc, strongly typed SQL queries
24. marzo 2012 10:33 / Chris Pietschmann / C# . SQL / Comentarios (0)
SQLinq is a new library that allows ad-hoc SQL code to be generated at runtime in a strongly typed manner that allows for compile time validation of your SQL code.

Why SQLinq?
SQLinq is built with the core idea of simplicity and ease of use. SQLinq wont get in your way like other Data Access Layers will.

SQLinq is not so much a Data Access Layer (DAL) as it is a code generation tool. Although, it’s not a code generator like others you may be used to. If you look at Entity Framework, you’ll see a ton of C# or VB.NET code that gets generated from a complex data model defined in XML. Yes, Entity Framework gives you compile time validation of your queries, but it also can be a bit bloated (depending on your needs) and can be difficult to setup.

Personally, I have moved away from using Entity Framework for the most part due to the fact that it has performance issues with complex SQL queries that involve a lot of table joins and many where parameters to limit the results returned. The SQL code that Entity Framework generates generally has good performance, but Entity Framework’s performance issues can be seen when it loops through the data to instantiate the resulting object model. Because of these issues, I have mostly moved to manually writing SQL code and using straight ADO.NET for data access within the applications I build; that is at least until I created SQLinq.

With SQLinq there are no complex object models. You simply create Class or Interface that matches the scheme of your database table or view, and you can start querying it in a strongly typed manner.

IEnumerable<Person> data = con.Query(
    from p in SQLinq<Person>()
    where p.FirstName.StartsWith("C") && p.Age > 21
    orderby p.FirstName
    select p
);
Basic SQLinq Usage
Step 1: Create your data object in code (like the following examples) that matches the database table or view you want to select from. It can either be a class or interface. You can also name the object and/or its properties differently than the database by using the SQLinqTable and SQLinqColumn attributes to specify their name in the database.

[SQLinqTable("PersonTable")]
public class Person
{
    public Guid ID { get; set; }

    [SQLinqColumn("First_Name")]
    public string FirstName { get; set; }

    [SQLinqColumn("Last_Name")]
    public string LastName { get; set; }

    public int Age { get; set; }
}
Step 2: Use LINQ to generate the ad-hoc SQL query necessary

var query = from d in new SQLinq<Person>()
            where d.FirstName.StartsWith("C")
                 && d.Age > 18
            orderby d.FirstName
            select new {
                id = d.ID,
                firstName = d.FirstName
            };
Step 3: Generate the SQL code and necessary query parameter key/value pairs.

var queryResult = query.ToSQL();

// get the full SQL code
var sqlCode = queryResult.ToQuery();

// get the query parameters necessary to execute the above query
var sqlParameters = queryResult.Parameters;
Step 4: Create SqlCommand and set the SQL code and query parameters.

var cmd = new SqlCommand(dbconnection, sqlCode);
foreach(var p in sqlParameters)
{
    cmd.Parameters.AddWithValue(p.Key, p.Value);
}
// now execute the command and get the results from the database
Now add SQLinq.Dapper
SQLinq.Dapper is a small extension library that bridges SQLinq and Dapper to make querying much simpler.

Here’s a modified version of the above example that uses Dapper:

IEnumerable<Person> data = null;
using(IDbConnection con = GetDbConnection())
{
    con.Open();
    data = con.Query(
        from p in SQLinq<Person>()
        where p.FirstName.StartsWith("C") && p.Age > 21
        orderby p.FirstName
        select p
    );
    con.Close();
}
// do something with the data that was returned
Install SQLinq and SQLinq.Dapper via Nuget
Both SQLinq and SQLinq.Dapper are available via Nuget.

http://nuget.org/packages/SQLinq



http://nuget.org/packages/SQLinq.Dapper



Current Limitations of SQLinq
Currently the only real limitation of SQLinq is that is currently doesn’t support the ability to join multiple tables together using it. This requires you to only select data from existing database tables and/or views. However, by using a View to base your SQLinq query you can basically “pre” join different tables together for specific uses.

Conclusion
Personally, I think the concept of SQLinq is pretty neat and will be using it in my own projects. Although, I must admit that mixing SQLinq with other data access methods within a single application is probably best, and allows you to use the best method for your needs as they arise.