using System.Drawing;
using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Models;

public record Content
(
    [property: JsonPropertyName("cH2FontWeight")] FontWeight? H2FontWeight,
    [property: JsonPropertyName("cH2FontStyle")] FontStyle? H2FontStyle,
    [property: JsonPropertyName("cH2TextDecoration")] TextDecoration? H2TextDecoration,
    [property: JsonPropertyName("cH4FontWeight")] FontWeight? H4FontWeight,
    [property: JsonPropertyName("cH4FontStyle")] FontStyle? H4FontStyle,
    [property: JsonPropertyName("cH4TextDecoration")] TextDecoration? H4TextDecoration,
    [property: JsonPropertyName("cSmallFontWeight")] FontWeight? SmallFontWeight,
    [property: JsonPropertyName("cSmallFontStyle")] FontStyle? SmallFontStyle,
    [property: JsonPropertyName("cSmallTextDecoration")] TextDecoration? SmallTextDecoration,
    [property: JsonPropertyName("cFontWeight")] FontWeight? FontWeight,
    [property: JsonPropertyName("cFontStyle")] FontStyle? FontStyle,
    [property: JsonPropertyName("cTextDecoration")] TextDecoration? TextDecoration,
    [property: JsonPropertyName("cQuoteBgColor")] Color? QuoteBackgroundColor,
    [property: JsonPropertyName("cQuoteBorderColor")] Color? QuoteBorderColor,
    [property: JsonPropertyName("cQuoteFontWeight")] FontWeight? QuoteFontWeight,
    [property: JsonPropertyName("cQuoteFontStyle")] FontStyle? QuoteFontStyle,
    [property: JsonPropertyName("cQuoteTextDecoration")] TextDecoration? QuoteTextDecoration,
    [property: JsonPropertyName("cOwnReplyBgColor")] Color? OwnReplyBackgroundColor,
    [property: JsonPropertyName("cOwnReplyBorderColor")] Color? OwnReplyBorderColor,
    [property: JsonPropertyName("cOwnReplyFontWeight")] FontWeight? OwnReplyFontWeight,
    [property: JsonPropertyName("cOwnReplyFontStyle")] FontStyle? OwnReplyFontStyle,
    [property: JsonPropertyName("cOwnReplyTextDecoration")] TextDecoration? OwnReplyTextDecoration
);
