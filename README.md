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
<html>

<head>
<meta http-equiv=Content-Type content="text/html; charset=windows-1252">
<meta name=Generator content="Microsoft Word 15 (filtered)">
<style>
<!--
 /* Font Definitions */
 @font-face
	{font-family:"Cambria Math";
	panose-1:2 4 5 3 5 4 6 3 2 4;}
@font-face
	{font-family:Calibri;
	panose-1:2 15 5 2 2 2 4 3 2 4;}
@font-face
	{font-family:"Segoe UI";
	panose-1:2 11 5 2 4 2 4 2 2 3;}
@font-face
	{font-family:"Segoe UI Semibold";
	panose-1:2 11 7 2 4 2 4 2 2 3;}
 /* Style Definitions */
 p.MsoNormal, li.MsoNormal, div.MsoNormal
	{margin:0cm;
	margin-bottom:.0001pt;
	font-size:10.0pt;
	font-family:"Segoe UI",sans-serif;}
h1
	{mso-style-link:"Título 1 Car";
	margin-top:3.0pt;
	margin-right:0cm;
	margin-bottom:0cm;
	margin-left:0cm;
	margin-bottom:.0001pt;
	font-size:18.0pt;
	font-family:"Segoe UI",sans-serif;
	color:#2E74B5;}
h2
	{mso-style-link:"Título 2 Car";
	margin-top:0cm;
	margin-right:0cm;
	margin-bottom:3.0pt;
	margin-left:0cm;
	font-size:14.0pt;
	font-family:"Segoe UI",sans-serif;
	color:#2E74B5;}
span.Ttulo1Car
	{mso-style-name:"Título 1 Car";
	mso-style-link:"Título 1";
	font-family:"Segoe UI",sans-serif;
	color:#2E74B5;
	font-weight:bold;}
span.Ttulo2Car
	{mso-style-name:"Título 2 Car";
	mso-style-link:"Título 2";
	font-family:"Segoe UI",sans-serif;
	color:#2E74B5;
	font-weight:bold;}
.MsoChpDefault
	{font-family:"Calibri",sans-serif;}
.MsoPapDefault
	{margin-bottom:8.0pt;
	line-height:107%;}
@page WordSection1
	{size:595.3pt 841.9pt;
	margin:36.0pt 36.0pt 36.0pt 36.0pt;}
div.WordSection1
	{page:WordSection1;}
-->
</style>

</head>

<body lang=ES>

<div class=WordSection1>

<p class=MsoNormal style='line-height:14.25pt;vertical-align:baseline'><b><span
style='color:#253340'>Project Description</span></b><span style='color:#253340'><br>
Easily generate ad-hoc SQL code using LINQ in a strongly typed manner that
allows for compile time validation of sql scripts.<br>
<br>
</span></p>

<p class=MsoNormal style='line-height:23.1pt;background:#F0F1F4;vertical-align:
baseline'><span style='font-size:13.0pt;font-family:"Segoe UI Semibold",sans-serif;
color:#253340;text-transform:uppercase;letter-spacing:.75pt'>Nuget Package</span></p>

<p class=MsoNormal style='line-height:14.25pt;vertical-align:baseline'><span
style='color:#253340'><a href="http://nuget.org/packages/sqlinq"><span
style='color:#2E8BCC;text-decoration:none'>http://nuget.org/packages/sqlinq</span></a><br>
<br>
</span><a href="http://nuget.org/packages/sqlinq"><span style='color:#2E8BCC;
text-decoration:none'><img border=0 width=746 height=72 id="Imagen 1"
src="Doc1_archivos/image001.png" alt="Install SQLinq via Nuget"></span></a><span
style='color:#253340'><br>
<br>
</span></p>

<p class=MsoNormal style='line-height:23.1pt;background:#F0F1F4;vertical-align:
baseline'><span style='font-size:13.0pt;font-family:"Segoe UI Semibold",sans-serif;
color:#253340;text-transform:uppercase;letter-spacing:.75pt'>SQLinq Usage</span></p>

<p class=MsoNormal style='line-height:14.25pt;vertical-align:baseline'><b><span
style='color:#253340'>Step 1:</span></b><span style='color:#253340'>&nbsp;Create
your data object in code (like the following examples) that matches the
database table or view you want to select from. It can either be a class or
interface. You can also name the object and/or its properties differently than
the database by using the SQLinqTable and SQLinqColumn attributes to specify
their name in the database.</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>[SQLinqTable(</span><span
style='font-family:"Courier New";color:#A31515'>&quot;PersonTable&quot;</span><span
style='font-family:"Courier New";color:black'>)]</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:blue'>public</span><span
style='font-family:"Courier New";color:black'> </span><span style='font-family:
"Courier New";color:blue'>class</span><span style='font-family:"Courier New";
color:black'> Person</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>{</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>    </span><span
style='font-family:"Courier New";color:blue'>public</span><span
style='font-family:"Courier New";color:black'> Guid ID { </span><span
style='font-family:"Courier New";color:blue'>get</span><span style='font-family:
"Courier New";color:black'>; </span><span style='font-family:"Courier New";
color:blue'>set</span><span style='font-family:"Courier New";color:black'>; }</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>&nbsp;</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>   
[SQLinqColumn(</span><span style='font-family:"Courier New";color:#A31515'>&quot;First_Name&quot;</span><span
style='font-family:"Courier New";color:black'>)]</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>    </span><span
style='font-family:"Courier New";color:blue'>public</span><span
style='font-family:"Courier New";color:black'> </span><span style='font-family:
"Courier New";color:blue'>string</span><span style='font-family:"Courier New";
color:black'> FirstName { </span><span style='font-family:"Courier New";
color:blue'>get</span><span style='font-family:"Courier New";color:black'>; </span><span
style='font-family:"Courier New";color:blue'>set</span><span style='font-family:
"Courier New";color:black'>; }</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>&nbsp;</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>   
[SQLinqColumn(</span><span style='font-family:"Courier New";color:#A31515'>&quot;Last_Name&quot;</span><span
style='font-family:"Courier New";color:black'>)]</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>    </span><span
style='font-family:"Courier New";color:blue'>public</span><span
style='font-family:"Courier New";color:black'> </span><span style='font-family:
"Courier New";color:blue'>string</span><span style='font-family:"Courier New";
color:black'> LastName { </span><span style='font-family:"Courier New";
color:blue'>get</span><span style='font-family:"Courier New";color:black'>; </span><span
style='font-family:"Courier New";color:blue'>set</span><span style='font-family:
"Courier New";color:black'>; }</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>&nbsp;</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>    </span><span
style='font-family:"Courier New";color:blue'>public</span><span
style='font-family:"Courier New";color:black'> </span><span style='font-family:
"Courier New";color:blue'>int</span><span style='font-family:"Courier New";
color:black'> Age { </span><span style='font-family:"Courier New";color:blue'>get</span><span
style='font-family:"Courier New";color:black'>; </span><span style='font-family:
"Courier New";color:blue'>set</span><span style='font-family:"Courier New";
color:black'>; }</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>}</span></p>

<p class=MsoNormal style='line-height:14.25pt;vertical-align:baseline'><span
style='color:#253340'><br>
<b>Step 2:</b>&nbsp;Use LINQ to generate the ad-hoc SQL query necessary.</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:blue'>var</span><span
style='font-family:"Courier New";color:black'> query = </span><span
style='font-family:"Courier New";color:blue'>from</span><span style='font-family:
"Courier New";color:black'> d </span><span style='font-family:"Courier New";
color:blue'>in</span><span style='font-family:"Courier New";color:black'> </span><span
style='font-family:"Courier New";color:blue'>new</span><span style='font-family:
"Courier New";color:black'> SQLinq&lt;Person&gt;()</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>            </span><span
style='font-family:"Courier New";color:blue'>where</span><span
style='font-family:"Courier New";color:black'> d.FirstName.StartsWith(</span><span
style='font-family:"Courier New";color:#A31515'>&quot;C&quot;</span><span
style='font-family:"Courier New";color:black'>)</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>                
&amp;&amp; d.Age &gt; 18</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>            </span><span
style='font-family:"Courier New";color:blue'>orderby</span><span
style='font-family:"Courier New";color:black'> d.FirstName</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>            </span><span
style='font-family:"Courier New";color:blue'>select</span><span
style='font-family:"Courier New";color:black'> </span><span style='font-family:
"Courier New";color:blue'>new</span><span style='font-family:"Courier New";
color:black'> {</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>               
id = d.ID,</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>               
firstName = d.FirstName</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>            };</span></p>

<p class=MsoNormal style='line-height:14.25pt;vertical-align:baseline'><span
style='color:#253340'><br>
<b>Step 3:</b>&nbsp;Generate the SQL code and necessary query parameter
key/value pairs.</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:blue'>var</span><span
style='font-family:"Courier New";color:black'> queryResult = query.ToSQL();</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>&nbsp;</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:green'>// get the full
SQL code</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:blue'>var</span><span
style='font-family:"Courier New";color:black'> sqlCode = queryResult.ToQuery();</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>&nbsp;</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:green'>// get the query
parameters necessary to execute the above query</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:blue'>var</span><span
style='font-family:"Courier New";color:black'> sqlParameters = queryResult.Parameters;</span></p>

<p class=MsoNormal style='line-height:14.25pt;vertical-align:baseline'><span
style='color:#253340'><br>
<b>Step 4:</b>&nbsp;Create SqlCommand and set the SQL code and Query Parameters</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:blue'>var</span><span
style='font-family:"Courier New";color:black'> cmd = </span><span
style='font-family:"Courier New";color:blue'>new</span><span style='font-family:
"Courier New";color:black'> SqlCommand(dbconnection, sqlCode);</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:blue'>foreach</span><span
style='font-family:"Courier New";color:black'>(</span><span style='font-family:
"Courier New";color:blue'>var</span><span style='font-family:"Courier New";
color:black'> p </span><span style='font-family:"Courier New";color:blue'>in</span><span
style='font-family:"Courier New";color:black'> sqlParameters)</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>{</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>   
cmd.Parameters.AddWithValue(p.Key, p.Value);</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>}</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:green'>// now execute
the command and get the results from the database</span></p>

<p class=MsoNormal style='line-height:23.1pt;background:#F0F1F4;vertical-align:
baseline'><span style='font-size:13.0pt;font-family:"Segoe UI Semibold",sans-serif;
color:#253340;text-transform:uppercase;letter-spacing:.75pt'>SQLinq.Dapper</span></p>

<p class=MsoNormal style='line-height:14.25pt;vertical-align:baseline'><span
style='color:#253340'>SQLinq.Dapper is a small helper library that bridges the
gap between SQLinq and&nbsp;<a href="http://code.google.com/p/dapper-dot-net/"><span
style='color:#2E8BCC;text-decoration:none'>Dapper dot net</span></a>&nbsp;to
allow for queries to be performed more easily.<br>
<br>
<b>SQLinq.Dapper Usage:</b><br>
Here's a simple example of using SQLinq.Dapper:</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>IEnumerable&lt;Person&gt;
data = </span><span style='font-family:"Courier New";color:blue'>null</span><span
style='font-family:"Courier New";color:black'>;</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:blue'>using</span><span
style='font-family:"Courier New";color:black'>(IDbConnection con =
GetDbConnection())</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>{</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>    con.Open();</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>    data =
con.Query(</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>        </span><span
style='font-family:"Courier New";color:blue'>from</span><span style='font-family:
"Courier New";color:black'> p </span><span style='font-family:"Courier New";
color:blue'>in</span><span style='font-family:"Courier New";color:black'>
SQLinq&lt;Person&gt;()</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>        </span><span
style='font-family:"Courier New";color:blue'>where</span><span
style='font-family:"Courier New";color:black'> p.FirstName.StartsWith(</span><span
style='font-family:"Courier New";color:#A31515'>&quot;C&quot;</span><span
style='font-family:"Courier New";color:black'>) &amp;&amp; p.Age &gt; 21</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>        </span><span
style='font-family:"Courier New";color:blue'>orderby</span><span
style='font-family:"Courier New";color:black'> p.FirstName</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>        </span><span
style='font-family:"Courier New";color:blue'>select</span><span
style='font-family:"Courier New";color:black'> p</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>    );</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>    con.Close();</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>}</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:black'>&nbsp;</span></p>

<p class=MsoNormal style='line-height:14.25pt;background:white;vertical-align:
baseline'><span style='font-family:"Courier New";color:green'>// do somthing
with the data that was returned</span></p>

<p class=MsoNormal style='line-height:14.25pt;vertical-align:baseline'><span
style='color:#253340'><br>
<b>Install SQLinq.Dapper via Nuget</b><br>
SQLinq.Dapper can also be installed into your project via Nuget!<br>
<a href="http://nuget.org/packages/SQLinq.Dapper"><span style='color:#2E8BCC;
text-decoration:none'>http://nuget.org/packages/SQLinq.Dapper</span></a><br>
<br>
</span><a href="http://nuget.org/packages/SQLinq.Dapper"><span
style='color:#2E8BCC;text-decoration:none'><img border=0 width=747 height=70
id="Imagen 2" src="Doc1_archivos/image002.png" alt="Install SQLinq via Nuget"></span></a><span
style='color:#253340'><br>
<br>
</span></p>

<p class=MsoNormal style='line-height:23.1pt;background:#F0F1F4;vertical-align:
baseline'><span style='font-size:13.0pt;font-family:"Segoe UI Semibold",sans-serif;
color:#253340;text-transform:uppercase;letter-spacing:.75pt'>Contributors</span></p>

<p class=MsoNormal style='line-height:14.25pt;vertical-align:baseline'><span
style='color:#253340'>This project is maintained by&nbsp;<a
href="http://pietschsoft.com/"><span style='color:#2E8BCC;text-decoration:none'>Chris
Pietschmann</span></a>. He is a Microsoft MVP for Bing Maps, a Co-Founder of&nbsp;<a
href="http://carto.com/"><span style='color:#2E8BCC;text-decoration:none'>Carto
LLC</span></a>, and the Owner of&nbsp;<a href="http://simplovation.com/"><span
style='color:#2E8BCC;text-decoration:none'>Simplovation LLC</span></a>&nbsp;a
software development consulting company that specializes in Mapping/GIS related
application development.</span></p>

<p class=MsoNormal style='line-height:14.25pt;vertical-align:baseline'><span
style='color:#253340'>Last edited&nbsp;May 5, 2013 at 6:34 PM&nbsp;by&nbsp;<a
href="https://www.codeplex.com/site/users/view/crpietschmann"><span
style='color:#2E8BCC;text-decoration:none'>crpietschmann</span></a>, version 15</span></p>

<p class=MsoNormal>&nbsp;</p>

</div>

</body>

</html>