using System.ComponentModel;

namespace YoutubeDownloader.Localization;

public enum Language
{
    System,

    [Description("Chinese (Simplified)")]
    ChineseSimplified,

    English,

    [Description("Français")]
    French,

    [Description("Deutsch")]
    German,

    [Description("Español")]
    Spanish,

    [Description("Українська")]
    Ukrainian,
}
