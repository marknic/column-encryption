﻿using System;
using System.Collections.Generic;

namespace Microsoft.ColumnEncryption.Data
{
    /// <summary> Holds all information about a column and its data </summary>
    public class ColumnData
    {
        /// <summary> Column Name </summary>
        public string Name { get; }

        /// <summary>
        /// Data type of data within this column.
        /// Defaults to string if not specified.
        /// </summary>
        public Type Type { get; }

        /// <summary> Actual column data </summary>
        public IList<object> Data { get; set; }

        /// <summary> Initializes a new instance of <see cref="ColumnData"/> </summary>
        /// <param name="Name"> Column name </param>
        public ColumnData(string Name) : this(Name, typeof(string))
        {
        }

        /// <summary> Initializes a new instance of <see cref="ColumnData"/> </summary>
        /// <param name="name"> Column name </param>
        /// <param name="type"> Column data type </param>
        public ColumnData(string name, Type type)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            if (type == null) throw new ArgumentNullException(nameof(type));

            this.Name = name;
            this.Type = type;
            this.Data = new List<object>();
        }
    }
}