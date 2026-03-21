using System.Collections.Generic;

namespace YoutubeDownloader.Localization;

public partial class LocalizationManager
{
    private static readonly IReadOnlyDictionary<string, string> ChineseLocalization =
        new Dictionary<string, string>
        {
            [nameof(FFmpegPathLabel)] = "FFmpeg 路径",
            [nameof(FFmpegPathTooltip)] = "FFmpeg 可执行文件的路径。留空则使用自动检测。",
            [nameof(FFmpegPathWatermark)] = "自动检测",

            [nameof(InjectSubtitlesLabel)] = "注入字幕",
            [nameof(InjectSubtitlesTooltip)] = "将字幕（如果可用）注入到下载的文件中",
            [nameof(InjectTagsLabel)] = "注入媒体标签",
            [nameof(InjectTagsTooltip)] = "将媒体标签（如果可用）注入到下载的文件中",
            [nameof(SkipExistingFilesLabel)] = "跳过已存在的文件",
            [nameof(SkipExistingFilesTooltip)] =
                "下载多个视频时，跳过输出目录中已存在匹配文件的视频",
            [nameof(FileNameTemplateLabel)] = "文件名模板",
            [nameof(FileNameTemplateTooltip)] = """
                用于生成下载视频文件名的模板。

                可用标记：
                **$num** — 视频在列表中的位置（如果适用）
                **$id** — 视频 ID
                **$title** — 视频标题
                **$author** — 视频作者
                """,
            [nameof(ParallelLimitLabel)] = "并行下载限制",
            [nameof(ParallelLimitTooltip)] = "允许同时进行的下载任务数量",
            [nameof(FFmpegPathLabel)] = "FFmpeg 路径",
            [nameof(FFmpegPathTooltip)] = "FFmpeg 可执行文件的路径。留空则使用自动检测。",
            [nameof(FFmpegPathWatermark)] = "自动检测",
            [nameof(FFmpegPathResetTooltip)] = "重置为自动检测",
            [nameof(FFmpegPathBrowseTooltip)] = "浏览 FFmpeg 可执行文件",

            // Auth Setup (身份验证设置)
            [nameof(AuthenticationTitle)] = "身份验证",
            [nameof(AuthenticatedText)] = "你当前已通过身份验证",
            [nameof(LogOutButton)] = "退出登录",
            [nameof(LoadingText)] = "正在加载...",

            // Download Single Setup (单个下载设置)
            [nameof(CopyMenuItem)] = "复制",
            [nameof(LiveLabel)] = "直播",
            [nameof(AudioLabel)] = "音频",
            [nameof(FormatLabel)] = "格式",

            // Download Multiple Setup (批量下载设置)
            [nameof(ContainerLabel)] = "封装格式",
            [nameof(VideoQualityLabel)] = "视频质量",

            // Common buttons (常用按钮)
            [nameof(CloseButton)] = "关闭",
            [nameof(DownloadButton)] = "下载",
            [nameof(CancelButton)] = "取消",
            [nameof(SettingsButton)] = "设置",

            // Dialog messages (对话框消息)
            [nameof(UkraineSupportTitle)] = "感谢你支持乌克兰！",
            [nameof(UkraineSupportMessage)] = """
                由于俄罗斯正对我的国家发动一场种族灭绝战争，我向所有在我们的自由之战中继续支持乌克兰的人表示感谢。

                点击“了解更多”以寻找你可以提供帮助的途径。
                """,
            [nameof(LearnMoreButton)] = "了解更多",
            [nameof(UnstableBuildTitle)] = "不稳定版本警告",
            [nameof(UnstableBuildMessage)] = """
                你正在使用 {0} 的开发版本。这些版本未经严格测试，可能包含漏洞。

                开发版本已禁用自动更新。

                如果你想下载稳定版本，请点击“查看发布版本”。
                """,
            [nameof(SeeReleasesButton)] = "查看发布版本",
            [nameof(FFmpegMissingTitle)] = "缺少 FFmpeg",
            [nameof(FFmpegMissingMessage)] = """
                {0} 需要 FFmpeg 才能工作。请下载它并将其放在应用程序目录中或系统 PATH 变量中，或者在设置中配置其位置。

                或者，你也可以下载集成了 FFmpeg 的 {0} 版本。请寻找未标记为 *.Bare 的发布资源。

                点击“下载”跳转到 FFmpeg 下载页面。
                """,
            [nameof(FFmpegPathMissingMessage)] = """
                此应用需要 FFmpeg 才能运行，但配置的路径不存在：
                {0}

                请在设置中更新 FFmpeg 路径，或将其清空以使用自动检测。
                """,
            [nameof(FFmpegMissingSearchedLabel)] =
                "在以下目录中搜索了 '{0}'：",
            [nameof(NothingFoundTitle)] = "未找到内容",
            [nameof(NothingFoundMessage)] =
                "无法根据你提供的查询或 URL 找到任何视频",
            [nameof(ErrorTitle)] = "错误",
            [nameof(UpdateDownloadingMessage)] = "正在下载更新至 {0} v{1}...",
            [nameof(UpdateReadyMessage)] =
                "更新已下载，将在你退出时安装",
            [nameof(UpdateInstallNowButton)] = "立即安装",
            [nameof(UpdateFailedMessage)] = "应用程序更新失败",
        };
}
