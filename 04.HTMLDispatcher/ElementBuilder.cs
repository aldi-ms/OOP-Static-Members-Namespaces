using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HTMLDispatcher
{
    public class ElementBuilder
    {
        private string element;
        private string content;
        private List<HtmlAttribute> attributes;

        public ElementBuilder(string elementName)
        {
            this.attributes = new List<HtmlAttribute>();
            if (!string.IsNullOrEmpty(elementName))
            {
                this.element = elementName;
            }
            else
            {
                throw new ArgumentException(
                    "Element name cannot be null or empty string!",
                    "elementName");
            }
        }

        public string Element
        {
            get { return this.element; }
        }

        public string Content
        {
            get { return this.content; }
        }

        /// <summary>
        /// Add attributes to our HTML element.
        /// </summary>
        /// <param name="attr">Attribute name.</param>
        /// <param name="value">Attribute value.</param>
        public void AddAttribute(string attr, string value)
        {
            if (!string.IsNullOrEmpty(attr))
            {
                this.attributes.Add(new HtmlAttribute(attr, value));
            }
            else
            {
                throw new ArgumentException(
                    "Attribute name cannot be null or empty string!",
                    "attr");
            }
        }

        /// <summary>
        /// Adds content (text) to the current element. Overwrites old content (if any).
        /// </summary>
        /// <param name="content">The content we want to add.</param>
        public void AddContent(string content)
        {
            if (content != null)
            {
                this.content = content;
            }
            else
            {
                this.content = "";
            }
        }

        /// <summary>
        /// Returns the element "e", "n" number of times. Works only on element name (content and attributes are not parsed)!
        /// Use e.Element to get the multiplied elements.
        /// </summary>
        /// <returns></returns>
        public static ElementBuilder operator *(ElementBuilder e, int n)
        {
            StringBuilder sb = new StringBuilder();

            if (n > 1)
            {
                sb.AppendFormat("<{0}></{0}", e.Element);

                for (int i = 0; i < n-1; i++)
                {
                    sb.AppendFormat("><{0}></{0}", e.Element);
                }
                sb.Append(">");
            }

            return new ElementBuilder(sb.ToString());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            // open tag
            sb.AppendFormat("<{0}", this.Element);

            // add attributes if any
            foreach (HtmlAttribute attr in this.attributes)
            {
                sb.AppendFormat(" {0}", attr.ToString());
            }

            // add the content and close tag
            sb.AppendFormat(">{0}</{1}>", this.Content, this.Element);

            return sb.ToString();
        }

        private class HtmlAttribute
        {
            private string Attribute { get; set; }
            private string Value { get; set; }

            public HtmlAttribute(string attr, string value)
            {
                this.Attribute = attr;
                this.Value = value;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(this.Attribute);

                if (!string.IsNullOrEmpty(this.Value))
                {
                    sb.AppendFormat("=\"{0}\"", this.Value);
                }

                return sb.ToString();
            }
        }
    }
}
