using System.Drawing;
using System.Text.Json.Serialization;

namespace TweakblogsExportReader.Models;

public record Content
(
    [property: JsonPropertyName("cBgColor")] Color? BackgroundColor,
    [property: JsonPropertyName("cBorderColor")] Color? BorderColor,
    [property: JsonPropertyName("cBorderSize")] byte BorderSize,
    [property: JsonPropertyName("cBorderType")] BorderType? BorderType,

    [property: JsonPropertyName("cH2FontFamily")] string? H2FontFamily,
    [property: JsonPropertyName("cH2FontSize")] byte H2FontSize,
    [property: JsonPropertyName("cH2FontColor")] Color? H2FontColor,
    [property: JsonPropertyName("cH2FontWeight")] FontWeight? H2FontWeight,
    [property: JsonPropertyName("cH2FontStyle")] FontStyle? H2FontStyle,
    [property: JsonPropertyName("cH2TextDecoration")] TextDecoration? H2TextDecoration,

    [property: JsonPropertyName("cH4FontFamily")] string? H4FontFamily,
    [property: JsonPropertyName("cH4FontSize")] byte H4FontSize,
    [property: JsonPropertyName("cH4FontColor")] Color? H4FontColor,
    [property: JsonPropertyName("cH4FontWeight")] FontWeight? H4FontWeight,
    [property: JsonPropertyName("cH4FontStyle")] FontStyle? H4FontStyle,
    [property: JsonPropertyName("cH4TextDecoration")] TextDecoration? H4TextDecoration,

    [property: JsonPropertyName("cSmallFontFamily")] string? SmallFontFamily,
    [property: JsonPropertyName("cSmallFontSize")] byte SmallFontSize,
    [property: JsonPropertyName("cSmallFontColor")] Color? SmallFontColor,
    [property: JsonPropertyName("cSmallFontWeight")] FontWeight? SmallFontWeight,
    [property: JsonPropertyName("cSmallFontStyle")] FontStyle? SmallFontStyle,
    [property: JsonPropertyName("cSmallTextDecoration")] TextDecoration? SmallTextDecoration,

    [property: JsonPropertyName("cFontFamily")] string? FontFamily,
    [property: JsonPropertyName("cFontSize")] byte FontSize,
    [property: JsonPropertyName("cFontColor")] Color? FontColor,
    [property: JsonPropertyName("cFontWeight")] FontWeight? FontWeight,
    [property: JsonPropertyName("cFontStyle")] FontStyle? FontStyle,
    [property: JsonPropertyName("cTextDecoration")] TextDecoration? TextDecoration,

    [property: JsonPropertyName("cHeader1FontFamily")] string? Header1FontFamily,
    [property: JsonPropertyName("cHeader1FontSize")] byte Header1FontSize,
    [property: JsonPropertyName("cHeader1FontColor")] Color? Header1FontColor,
    [property: JsonPropertyName("cHeader1FontWeight")] FontWeight? Header1FontWeight,
    [property: JsonPropertyName("cHeader1FontStyle")] FontStyle? Header1FontStyle,
    [property: JsonPropertyName("cHeader1TextDecoration")] TextDecoration? Header1TextDecoration,

    [property: JsonPropertyName("cHeader2FontFamily")] string? Header2FontFamily,
    [property: JsonPropertyName("cHeader2FontSize")] byte Header2FontSize,
    [property: JsonPropertyName("cHeader2FontColor")] Color? Header2FontColor,
    [property: JsonPropertyName("cHeader2FontWeight")] FontWeight? Header2FontWeight,
    [property: JsonPropertyName("cHeader2FontStyle")] FontStyle? Header2FontStyle,
    [property: JsonPropertyName("cHeader2TextDecoration")] TextDecoration? Header2TextDecoration,

    [property: JsonPropertyName("cHeader3FontFamily")] string? Header3FontFamily,
    [property: JsonPropertyName("cHeader3FontSize")] byte Header3FontSize,
    [property: JsonPropertyName("cHeader3FontColor")] Color? Header3FontColor,
    [property: JsonPropertyName("cHeader3FontWeight")] FontWeight? Header3FontWeight,
    [property: JsonPropertyName("cHeader3FontStyle")] FontStyle? Header3FontStyle,
    [property: JsonPropertyName("cHeader3TextDecoration")] TextDecoration? Header3TextDecoration,

    [property: JsonPropertyName("cQuoteBgColor")] Color? QuoteBackgroundColor,
    [property: JsonPropertyName("cQuoteBorderColor")] Color? QuoteBorderColor,
    [property: JsonPropertyName("cQuoteBorderSize")] int? QuoteBorderSize,
    [property: JsonPropertyName("cQuoteBorderType")] BorderType? QuoteBorderType,
    [property: JsonPropertyName("cQuoteFontFamily")] string? QuoteFontFamily,
    [property: JsonPropertyName("cQuoteFontSize")] byte QuoteFontSize,
    [property: JsonPropertyName("cQuoteFontColor")] Color? QuoteFontColor,
    [property: JsonPropertyName("cQuoteFontWeight")] FontWeight? QuoteFontWeight,
    [property: JsonPropertyName("cQuoteFontStyle")] FontStyle? QuoteFontStyle,
    [property: JsonPropertyName("cQuoteTextDecoration")] TextDecoration? QuoteTextDecoration,

    [property: JsonPropertyName("cOwnReplyBgColor")] Color? OwnReplyBackgroundColor,
    [property: JsonPropertyName("cOwnReplyBorderColor")] Color? OwnReplyBorderColor,
    [property: JsonPropertyName("cOwnReplyFontFamily")] string? OwnReplyFontFamily,
    [property: JsonPropertyName("cOwnReplyFontSize")] byte OwnReplyFontSize,
    [property: JsonPropertyName("cOwnReplyFontColor")] Color? OwnReplyFontColor,
    [property: JsonPropertyName("cOwnReplyFontWeight")] FontWeight? OwnReplyFontWeight,
    [property: JsonPropertyName("cOwnReplyFontStyle")] FontStyle? OwnReplyFontStyle,
    [property: JsonPropertyName("cOwnReplyTextDecoration")] TextDecoration? OwnReplyTextDecoration
);