﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMarkdown.MarkdownLibrary.HtmlComponents
{
    public class HtmlDocument
    {
        private List<HtmlComponent> _components;

        public HtmlDocument(List<HtmlComponent> components)
        {
            _components = components;
        }

        public override string ToString()
        {
            string output = string.Empty;
            output += "<link rel=\"stylesheet\" href=\"Styles/github-markdown.css\">" +
                      "<style>.markdown - body {box - sizing: border - box;min - width: 200px;max - width: 980px;margin: 0 auto;padding: 45px;}</style >" +
                      "<article class=\"markdown-body\">";
            
            for (int i = 0; i < _components.Count; i++)
            {
                output += _components[i].ToString();
            }

            output += "</article>";

            return output;
        }
    }
}