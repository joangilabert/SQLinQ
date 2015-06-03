﻿//Copyright (c) Chris Pietschmann 2013 (http://pietschsoft.com)
//Licensed under the GNU Library General Public License (LGPL)
//License can be found here: http://sqlinq.codeplex.com/license

using System;
using System.Collections.Generic;
using System.Text;

namespace SQLinq
{
    public class SQLinqInsertResult : ISQLinqResult
    {
        public string Table { get; set; }

        public Dictionary<string, string> Fields { get; set; }

        public IDictionary<string, object> Parameters { get; set; }

        public string ToQuery()
        {
            if (string.IsNullOrWhiteSpace((this.Table ?? string.Empty).Trim()))
            {
                throw new ArgumentException("SQLinqInsertResult.Table is required to have a value.", "Table");
            }
            if (this.Fields == null || this.Fields.Count == 0)
            {
                throw new ArgumentNullException("Fields");
            }
            if (this.Parameters == null || this.Parameters.Count == 0)
            {
                throw new ArgumentNullException("Parameters");
            }

            var fieldList = new StringBuilder();
            var parameterList = new StringBuilder();

            var isFirst = true;
            foreach(var f in this.Fields)
            {
                if (!isFirst)
                {
                    fieldList.Append(", ");
                    parameterList.Append(", ");
                }
                else
                {
                    isFirst = false;
                }

                if (f.Key.StartsWith("["))
                {
                    fieldList.Append(f.Key);
                }
                else
                {
                    fieldList.Append("[");
                    fieldList.Append(f.Key);
                    fieldList.Append("]");
                }

                parameterList.Append(f.Value);
            }

            return string.Format("INSERT {0} ({1}) VALUES ({2})", this.Table, fieldList.ToString(), parameterList.ToString());
        }
    }
}
