using System.ComponentModel;

namespace YoutubeDownloader.Localization;

public enum Language
{
    [Description("System Default")]
    System,

    [Description("Chinese (Simplified)")]
    ChineseSimplified,

    [Description("English")]
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
