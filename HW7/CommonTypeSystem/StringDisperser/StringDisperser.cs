namespace StringDisperser
{
    using System;
    using System.Collections;
    using System.Text;

    public class StringDisperser : ICloneable, IComparable<StringDisperser>,IEnumerable
    {
        private string[] text;

        public StringDisperser(params string[] text)
        {
            this.Text = text;
        }

        public string[] Text
        {
            get
            {
                return this.text;
            }

            set
            {
                if (value.Length == 0 || value==null)
                {
                    throw new ArgumentNullException("String args cannot be zero or null");
                }

                this.text = value;
            }
        }

        public override bool Equals(object obj)
        {
            StringDisperser stringDisperser = obj as StringDisperser;

            if (stringDisperser == null)
            {
                return false;
            }

            return this.Text.Equals(stringDisperser.Text);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var str in this.Text)
            {
                result.AppendFormat("{0} ", str);
            }

            result.AppendLine();

            return result.ToString();
        }

        public override int GetHashCode()
        {
            return this.Text.GetHashCode();
        }

        public static bool operator ==(StringDisperser str1, StringDisperser str2)
        {
            return object.Equals(str1, str2);
        }

        public static bool operator !=(StringDisperser str1, StringDisperser str2)
        {
            return !object.Equals(str1, str2);
        }

        public object Clone()
        {
            string[] newArr = new string[this.Text.Length];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = (string)this.Text[i].Clone();
            }

            return new StringDisperser(newArr);
        }

        public int CompareTo(StringDisperser other)
        {
            return string.Concat(this.Text).CompareTo(string.Concat(other.Text));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            string str = string.Concat(this.Text);

            for (int i = 0; i < str.Length; i++)
            {
                yield return str[i];
            }
        }
    }
}
