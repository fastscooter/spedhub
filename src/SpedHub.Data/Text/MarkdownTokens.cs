namespace SpedHub.Data.Text
{
    public static class MarkdownTokens
    {
        internal static MarkdownToken None = new(MarkdownTokenType.None, "");
        internal static MarkdownToken Dot = new(MarkdownTokenType.Dot, ".");
        internal static MarkdownToken PoundSign = new(MarkdownTokenType.PoundSign, "#");
        internal static MarkdownToken PlusSign = new(MarkdownTokenType.PlusSign, "+");
        internal static MarkdownToken MinusSign = new(MarkdownTokenType.MinusSign, "-");
        internal static MarkdownToken ExclamationMark = new(MarkdownTokenType.ExclamationMark, "!");
        internal static MarkdownToken Backslash = new(MarkdownTokenType.Backslash, "\\");
        internal static MarkdownToken Backtick = new(MarkdownTokenType.Backtick, "`");
        internal static MarkdownToken Asterisk = new(MarkdownTokenType.Asterisk, "*");
        internal static MarkdownToken DoubleAsterisk = new(MarkdownTokenType.DoubleAsterisk, "**");
        internal static MarkdownToken TripleAsterisk = new(MarkdownTokenType.TripleAsterisk, "***");
        internal static MarkdownToken Underscore = new(MarkdownTokenType.Underscore, "_");
        internal static MarkdownToken DoubleUnderscore = new(MarkdownTokenType.DoubleUnderscore, "__");
        internal static MarkdownToken TripleUnderscore = new(MarkdownTokenType.TripleUnderscore, "___");
        internal static MarkdownToken OpenCurlyBrace = new(MarkdownTokenType.OpenCurlyBrace, "{");
        internal static MarkdownToken OpenBracket = new(MarkdownTokenType.OpenBracket, "[");
        internal static MarkdownToken OpenParenthesis = new(MarkdownTokenType.OpenParenthesis, "(");
        internal static MarkdownToken OpenAngleBracket = new(MarkdownTokenType.OpenAngleBracket, "<");
        internal static MarkdownToken CloseBracket = new(MarkdownTokenType.CloseBracket, "]");
        internal static MarkdownToken CloseParenthesis = new(MarkdownTokenType.CloseParenthesis, ")");
        internal static MarkdownToken CloseCurlyBrace = new(MarkdownTokenType.CloseCurlyBrace, "}");
        internal static MarkdownToken CloseAngledBracket = new(MarkdownTokenType.CloseAngledBracket, ">");
        internal static MarkdownToken Pipe = new(MarkdownTokenType.Pipe, "|");
        internal static MarkdownToken Heading1 = new(MarkdownTokenType.Heading1, "# ");
        internal static MarkdownToken Heading2 = new(MarkdownTokenType.Heading2, "## ");
        internal static MarkdownToken Heading3 = new(MarkdownTokenType.Heading3, "### ");
        internal static MarkdownToken Heading4 = new(MarkdownTokenType.Heading4, "#### ");
        internal static MarkdownToken Heading5 = new(MarkdownTokenType.Heading5, "##### ");
        internal static MarkdownToken Heading6 = new(MarkdownTokenType.Heading6, "###### ");
    }
}
