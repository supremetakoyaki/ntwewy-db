namespace NTwewyDb
{
    public class Chapter
    {
        public byte Id { get; set; }
        public string ChapterName { get; set; }
        public string ChapterTitle { get; set; }
        public string ChapterSummary { get; set; }
        public string ChapterBg { get; set; }
        public string ChapterIcon { get; set; }
        public string LogTextFile { get; set; }
        public byte[] SubmissionSkill { get; set; }
        public uint[] PigNoise { get; set; }
        public uint[] DiveId { get; set; }
        public short StruggleId { get; set; }

        public Chapter(byte id, string chapterName, string chapterTitle, string chapterSummary, string chapterBg, string chapterIcon, string logTextFile, byte[] submissionSkill, uint[] pigNoise, uint[] diveId, short struggleId)
        {
            Id = id;
            ChapterName = chapterName;
            ChapterTitle = chapterTitle;
            ChapterSummary = chapterSummary;
            ChapterBg = chapterBg;
            ChapterIcon = chapterIcon;
            LogTextFile = logTextFile;
            SubmissionSkill = submissionSkill;
            PigNoise = pigNoise;
            DiveId = diveId;
            StruggleId = struggleId;
        }
    }
}
