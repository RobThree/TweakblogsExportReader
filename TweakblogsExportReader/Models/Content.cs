using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Models;

public record Content
(
    [property: JsonPropertyName("cH2FontWeight")] string? H2FontWeight,
    [property: JsonPropertyName("cH2FontStyle")] string? H2FontStyle,
    [property: JsonPropertyName("cH2TextDecoration")] string? H2TextDecoration,
    [property: JsonPropertyName("cH4FontWeight")] string? H4FontWeight,
    [property: JsonPropertyName("cH4FontStyle")] string? H4FontStyle,
    [property: JsonPropertyName("cH4TextDecoration")] string? H4TextDecoration,
    [property: JsonPropertyName("cSmallFontWeight")] string? SmallFontWeight,
    [property: JsonPropertyName("cSmallFontStyle")] string? SmallFontStyle,
    [property: JsonPropertyName("cSmallTextDecoration")] string? SmallTextDecoration,
    [property: JsonPropertyName("cFontWeight")] string? FontWeight,
    [property: JsonPropertyName("cFontStyle")] string? FontStyle,
    [property: JsonPropertyName("cTextDecoration")] string? TextDecoration,
    [property: JsonPropertyName("cQuoteBgColor")] string? QuoteBackgroundColor,
    [property: JsonPropertyName("cQuoteBorderColor")] string? QuoteBorderColor,
    [property: JsonPropertyName("cQuoteFontWeight")] string? QuoteFontWeight,
    [property: JsonPropertyName("cQuoteFontStyle")] string? QuoteFontStyle,
    [property: JsonPropertyName("cQuoteTextDecoration")] string? QuoteTextDecoration,
    [property: JsonPropertyName("cOwnReplyBgColor")] string? OwnReplyBackgroundColor,
    [property: JsonPropertyName("cOwnReplyBorderColor")] string? OwnReplyBorderColor,
    [property: JsonPropertyName("cOwnReplyFontWeight")] string? OwnReplyFontWeight,
    [property: JsonPropertyName("cOwnReplyFontStyle")] string? OwnReplyFontStyle,
    [property: JsonPropertyName("cOwnReplyTextDecoration")] string? OwnReplyTextDecoration
);