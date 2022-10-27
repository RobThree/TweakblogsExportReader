using System.Drawing;
using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Models;

public record Content
(
    [property: JsonPropertyName("cH2Family")] string? H2FontFamily,
    [property: JsonPropertyName("cH2Size")] uint? H2FontSize,
    [property: JsonPropertyName("cH2Color")] Color? H2FontColor,
    [property: JsonPropertyName("cH2FontWeight")] FontWeight? H2FontWeight,
    [property: JsonPropertyName("cH2FontStyle")] FontStyle? H2FontStyle,
    [property: JsonPropertyName("cH2TextDecoration")] TextDecoration? H2TextDecoration,

    [property: JsonPropertyName("cH4Family")] string? H4FontFamily,
    [property: JsonPropertyName("cH4Size")] uint? H4FontSize,
    [property: JsonPropertyName("cH4Color")] Color? H4FontColor,
    [property: JsonPropertyName("cH4FontWeight")] FontWeight? H4FontWeight,
    [property: JsonPropertyName("cH4FontStyle")] FontStyle? H4FontStyle,
    [property: JsonPropertyName("cH4TextDecoration")] TextDecoration? H4TextDecoration,

    [property: JsonPropertyName("cSmallFontFamily")] string? SmallFontFamily,
    [property: JsonPropertyName("cSmallFontSize")] uint? SmallFontSize,
    [property: JsonPropertyName("cSmallFontColor")] Color? SmallFontColor,
    [property: JsonPropertyName("cSmallFontWeight")] FontWeight? SmallFontWeight,
    [property: JsonPropertyName("cSmallFontStyle")] FontStyle? SmallFontStyle,
    [property: JsonPropertyName("cSmallTextDecoration")] TextDecoration? SmallTextDecoration,

    [property: JsonPropertyName("cFontFamily")] string? FontFamily,
    [property: JsonPropertyName("cFontSize")] uint? FontSize,
    [property: JsonPropertyName("cFontColor")] Color? FontColor,
    [property: JsonPropertyName("cFontWeight")] FontWeight? FontWeight,
    [property: JsonPropertyName("cFontStyle")] FontStyle? FontStyle,
    [property: JsonPropertyName("cTextDecoration")] TextDecoration? TextDecoration,

    [property: JsonPropertyName("cHeader1Family")] string? Header1FontFamily,
    [property: JsonPropertyName("cHeader1Size")] uint? Header1FontSize,
    [property: JsonPropertyName("cHeader1Color")] Color? Header1FontColor,
    [property: JsonPropertyName("cHeader1Weight")] FontWeight? Header1FontWeight,
    [property: JsonPropertyName("cHeader1Style")] FontStyle? Header1FontStyle,
    [property: JsonPropertyName("cHeader1Decoration")] TextDecoration? Header1TextDecoration,

    [property: JsonPropertyName("cHeader2Family")] string? Header2FontFamily,
    [property: JsonPropertyName("cHeader2Size")] uint? Header2FontSize,
    [property: JsonPropertyName("cHeader2Color")] Color? Header2FontColor,
    [property: JsonPropertyName("cHeader2Weight")] FontWeight? Header2FontWeight,
    [property: JsonPropertyName("cHeader2Style")] FontStyle? Header2FontStyle,
    [property: JsonPropertyName("cHeader2Decoration")] TextDecoration? Header2TextDecoration,

    [property: JsonPropertyName("cHeader3Family")] string? Header3FontFamily,
    [property: JsonPropertyName("cHeader3Size")] uint? Header3FontSize,
    [property: JsonPropertyName("cHeader3Color")] Color? Header3FontColor,
    [property: JsonPropertyName("cHeader3Weight")] FontWeight? Header3FontWeight,
    [property: JsonPropertyName("cHeader3Style")] FontStyle? Header3FontStyle,
    [property: JsonPropertyName("cHeader3Decoration")] TextDecoration? Header3TextDecoration,

    [property: JsonPropertyName("cQuoteBgColor")] Color? QuoteBackgroundColor,
    [property: JsonPropertyName("cQuoteBorderColor")] Color? QuoteBorderColor,
    [property: JsonPropertyName("cQuoteBorderSize")] int? QuoteBorderSize,
    [property: JsonPropertyName("cQuoteFontFamily")] string? QuoteFontFamily,
    [property: JsonPropertyName("cQuoteFontSize")] uint? QuoteFontSize,
    [property: JsonPropertyName("cQuoteFontColor")] Color? QuoteFontColor,
    [property: JsonPropertyName("cQuoteFontWeight")] FontWeight? QuoteFontWeight,
    [property: JsonPropertyName("cQuoteFontStyle")] FontStyle? QuoteFontStyle,
    [property: JsonPropertyName("cQuoteBorderType")] BorderType? QuoteBorderType,
    [property: JsonPropertyName("cQuoteTextDecoration")] TextDecoration? QuoteTextDecoration,

    [property: JsonPropertyName("cOwnReplyBgColor")] Color? OwnReplyBackgroundColor,
    [property: JsonPropertyName("cOwnReplyBorderColor")] Color? OwnReplyBorderColor,
    [property: JsonPropertyName("cOwnReplyFontFamily")] string? OwnReplyFontFamily,
    [property: JsonPropertyName("cOwnReplyFontSize")] uint? OwnReplyFontSize,
    [property: JsonPropertyName("cOwnReplyFontColor")] Color? OwnReplyFontColor,
    [property: JsonPropertyName("cOwnReplyFontWeight")] FontWeight? OwnReplyFontWeight,
    [property: JsonPropertyName("cOwnReplyFontStyle")] FontStyle? OwnReplyFontStyle,
    [property: JsonPropertyName("cOwnReplyTextDecoration")] TextDecoration? OwnReplyTextDecoration
);