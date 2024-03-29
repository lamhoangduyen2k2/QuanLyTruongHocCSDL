﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Helpers.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DataNameAttribute : Attribute
    {
        protected List<string> _valueNames { get; set; }

        public List<string> ValueNames
        {
            get
            {
                return _valueNames;
            }
            set
            {
                _valueNames = value;
            }
        }

        public DataNameAttribute()
        {
            _valueNames = new List<string>();
        }

        public DataNameAttribute(params string[] valueNames)
        {
            _valueNames = valueNames.ToList();
        }
    }
}
