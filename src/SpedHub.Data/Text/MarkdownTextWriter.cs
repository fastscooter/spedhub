using System.Drawing;
using System.Text;

namespace SpedHub.Data.Text
{
    public static class MarkdownStrings
    {
        public const string Heading1 = "# ";
        public const string Heading2 = "## ";
        public const string Heading3 = "### ";
        public const string Heading4 = "#### ";
        public const string Heading5 = "##### ";
        public const string Heading6 = "###### ";

        public const string Dot = ".";
        public const string PoundSign = "#";
        public const string PlusSign = "+";
        public const string MinusSign = "-";
        public const string ExclamationMark = "!";
        public const string Backslash = "\\";
        public const string Backtick = "`";
        public const string Asterisk = "*";
        public const string DoubleAsterisk = "**";
        public const string TripleAsterisk = "***";
        public const string Underscore = "_";
        public const string DoubleUnderscore = "__";
        public const string TripleUnderscore = "___";
        public const string OpenCurlyBrace = "{";
        public const string OpenBracket = "[";
        public const string OpenParenthesis = "(";
        public const string OpenAngleBracket = "<";
        public const string CloseBracket = "]";
        public const string CloseParenthesis = ")";
        public const string CloseCurlyBrace = "}";
        public const string CloseAngledBracket = ">";
        public const string Pipe = "|";

    }

    public enum MarkdownTokenType
    {
        None,
        Dot,
        PoundSign,
        PlusSign,
        MinusSign,
        ExclamationMark,
        Backslash,
        Backtick,
        Asterisk,
        DoubleAsterisk,
        TripleAsterisk,
        Underscore,
        DoubleUnderscore,
        TripleUnderscore,
        OpenCurlyBrace,
        OpenBracket,
        OpenParenthesis,
        OpenAngleBracket,
        CloseBracket,
        CloseParenthesis,
        CloseCurlyBrace,
        CloseAngledBracket,
        Pipe,
        Heading1,
        Heading2,
        Heading3,
        Heading4,
        Heading5,
        Heading6
    }
    public class MarkdownTextWriter: TextWriter
    {
        public MarkdownTextWriter(StringBuilder sb)
        {
            Builder = sb;
        }

        public StringBuilder Builder;

        public string BoldCharacters = "**";

        public string ItalicCharacters = "*";

        public string BoldItalicCharacters = "***";

        public string BulletListCharacters = "+";
        public override Encoding Encoding => Encoding.UTF8;


        public override void Write(string? value)
        {
            if(!string.IsNullOrEmpty(value))
                Builder = Builder.Append(value);
        }

        public override void WriteLine() =>
            Builder.AppendLine();

        public override void WriteLine(string? value)
        {
            if(!string.IsNullOrEmpty(value))
                Builder = Builder.AppendLine(value);
        }

        private void WriteToken(MarkdownToken token)
        {
            Write(token.Value);
        }

        public void WriteBodyText(string value, bool newLine = true)
        {
            if(newLine)
                WriteLine(value);
            else
                Write(value);
        }

        public void WriteBold(string value, bool newLine = true)
        {
            Write(BoldCharacters);
            Write(value);
            Write(BoldCharacters);
            if(newLine)
            {
                WriteLine();
            }
        }

        public void WriteItalic(string value, bool newLine = true)
        {
            Write(ItalicCharacters);
            Write(value);
            Write(ItalicCharacters);
            if(newLine)
            {
                WriteLine();
            }
        }

        public void WriteBoldItalic(string value, bool newLine = true)
        {
            Write(BoldItalicCharacters);
            Write(value);
            Write(BoldItalicCharacters);
            if(newLine)
            {
                WriteLine();
            }
        }

        public void WriteHeading1(string value, bool newLine = true)
        {
            Write(MarkdownStrings.Heading1);
            if(newLine)
                WriteLine(value);
            else
                Write(value);
        }

        public void WriteHeading2(string value, bool newLine = true)
        {
            Write(MarkdownStrings.Heading2);
            if(newLine)
                WriteLine(value);
            else
                Write(value);
        }

        public void WriteHeading3(string value, bool newLine = true)
        {
            Write(MarkdownStrings.Heading3);
            if(newLine)
                WriteLine(value);
            else
                Write(value);
        }

        public void WriteHeading4(string value, bool newLine = true)
        {
            Write(MarkdownStrings.Heading4);
            if(newLine)
                WriteLine(value);
            else
                Write(value);
        }

        public void WriteHeading5(string value, bool newLine = true)
        {
            Write(MarkdownStrings.Heading5);
            if(newLine)
                WriteLine(value);
            else
                Write(value);
        }

        public void WriteHeading6(string value, bool newLine = true)
        {
            Write(MarkdownStrings.Heading6);
            if(newLine)
                WriteLine(value);
            else
                Write(value);
        }
    }
}
