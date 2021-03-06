﻿//Copyright (c) Chris Pietschmann 2013 (http://pietschsoft.com)
//Licensed under the GNU Library General Public License (LGPL)
//License can be found here: http://sqlinq.codeplex.com/license

using SQLinq.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace SQLinq
{
    public class SQLinqInsert<T> : ISQLinqInsert
    {
        public SQLinqInsert(T data)
        {
            this.Data = data;
        }

        public SQLinqInsert(T data, string tableNameOverride)
            : this(data)
        {
            this.TableNameOverride = tableNameOverride;
        }

        public T Data { get; set; }
        public string TableNameOverride { get; set; }

        public ISQLinqResult ToSQL(int existingParameterCount = 0, string parameterNamePrefix = SqlExpressionCompiler.DefaultParameterNamePrefix)
        {
            int _parameterNumber = existingParameterCount;
            _parameterNumber++;

            var type = this.Data.GetType();
            var parameters = new Dictionary<string, object>();
            var fields = new Dictionary<string, string>();

            // Get Table / View Name
            var tableName = this.GetTableName();

            foreach (var p in type.GetProperties())
            {
                var includeInInsert = true;
                var fieldName = p.Name;
                var attr = p.GetCustomAttributes(typeof(SQLinqColumnAttribute), true).FirstOrDefault() as SQLinqColumnAttribute;
                if (attr != null)
                {
                    includeInInsert = attr.Insert;
                    if (!string.IsNullOrEmpty(attr.Column))
                    {
                        fieldName = attr.Column;
                    }
                }

                if (includeInInsert)
                {
                    var parameterName = "@" + parameterNamePrefix + _parameterNumber.ToString();

                    fields.Add(fieldName, parameterName);
                    parameters.Add(parameterName, p.GetValue(this.Data, null));

                    _parameterNumber++;
                }
            }

            return new SQLinqInsertResult
            {
                Table = tableName,
                Fields = fields,
                Parameters = parameters
            };
        }

        private string GetTableName()
        {
            var tableName = string.Empty;
            if (!string.IsNullOrEmpty(this.TableNameOverride))
            {
                tableName = this.TableNameOverride;
            }
            else
            {
                // Get Table / View Name
                var type = this.Data.GetType();
                tableName = type.Name;
                var tableAttribute = type.GetCustomAttributes(typeof(SQLinqTableAttribute), false).FirstOrDefault() as SQLinqTableAttribute;
                if (tableAttribute != null)
                {
                    // Table / View name is explicitly set, use that instead
                    tableName = tableAttribute.Table;
                }
            }

            return string.Format("[{0}]", tableName);
        }
    }
}
