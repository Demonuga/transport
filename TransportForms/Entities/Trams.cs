//
//
//  Generated by StarUML(tm) C# Add-In
//
//  @ Project : Untitled
//  @ File Name : Metal.cs
//  @ Date : 25.02.2015
//  @ Author : 
//
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Trams : BigTransport
    {
        private string condition;

        public string Condition
        {
            get { return condition; }
            set { condition = value; }
        }
    }
}