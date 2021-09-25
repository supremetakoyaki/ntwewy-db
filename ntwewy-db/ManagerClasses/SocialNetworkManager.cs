using System.Collections.Generic;
using System.Linq;

namespace NTwewyDb
{
    public class SocialNetworkManager
    {
        private readonly Dictionary<ushort, Skill> Skills = new Dictionary<ushort, Skill>()
        {
            { 0,         new Skill(0, "SKL_Name_0001", "SKL_Info_0001", 1, new float[] { 0f,0 }, -1, null, 0) },
            { 1,         new Skill(1, "SKL_Name_0002", "SKL_Info_0002", 3, new float[] { 0f,0 }, -1, null, 1) },
            { 2,         new Skill(2, "SKL_Name_0003", "SKL_Info_0003", 8, new float[] { 0f,0 }, -1, null, 2) },
            { 3,         new Skill(3, "SKL_Name_0004", "SKL_Info_0004", 2, new float[] { 0f,0 }, -1, null, 3) },
            { 4,         new Skill(4, "SKL_Name_0005", "SKL_Info_0005", 3, new float[] { 0.1f,0 }, -1, null, 4) },
            { 5,         new Skill(5, "SKL_Name_0005", "SKL_Info_0005", 3, new float[] { 0.1f,0 }, -1, null, 5) },
            { 6,         new Skill(6, "SKL_Name_0006", "SKL_Info_0006", 3, new float[] { 0.1f,0 }, -1, null, 6) },
            { 7,         new Skill(7, "SKL_Name_0006", "SKL_Info_0006", 3, new float[] { 0.1f,0 }, -1, null, 7) },
            { 8,         new Skill(8, "SKL_Name_0007", "SKL_Info_0007", 2, new float[] { 0f,0 }, -1, "reward_img_000", 8) },
            { 9,         new Skill(9, "SKL_Name_0008", "SKL_Info_0008", 3, new float[] { 0f,0 }, -1, "reward_img_001", 9) },
            { 10,         new Skill(10, "SKL_Name_0009", "SKL_Info_0009", 5, new float[] { 0f,0 }, -1, "reward_img_006", 10) },
            { 11,         new Skill(11, "SKL_Name_0010", "SKL_Info_0010", 4, new float[] { 5f,0 }, -1, null, 11) },
            { 12,         new Skill(12, "SKL_Name_0010", "SKL_Info_0010", 4, new float[] { 5f,0 }, -1, null, 12) },
            { 13,         new Skill(13, "SKL_Name_0010", "SKL_Info_0010", 4, new float[] { 5f,0 }, -1, null, 13) },
            { 14,         new Skill(14, "SKL_Name_0011", "SKL_Info_0011", 3, new float[] { 15f,0 }, -1, "reward_img_011", 14) },
            { 15,         new Skill(15, "SKL_Name_0012", "SKL_Info_0012", 3, new float[] { 0.4f,0 }, -1, "reward_img_011", 15) },
            { 16,         new Skill(16, "SKL_Name_0013", "SKL_Info_0013", 4, new float[] { 4f,0 }, -1, "reward_img_005", 16) },
            { 17,         new Skill(17, "SKL_Name_0014", "SKL_Info_0014", 4, new float[] { 4f,0 }, -1, "reward_img_005", 17) },
            { 18,         new Skill(18, "SKL_Name_0015", "SKL_Info_0015", 3, new float[] { 0.2f,1 }, -1, null, 18) },
            { 19,         new Skill(19, "SKL_Name_0016", "SKL_Info_0016", 3, new float[] { 0.2f,1 }, -1, null, 19) },
            { 20,         new Skill(20, "SKL_Name_0017", "SKL_Info_0017", 3, new float[] { 0.2f,1 }, -1, null, 20) },
            { 21,         new Skill(21, "SKL_Name_0018", "SKL_Info_0018", 3, new float[] { 0.2f,1 }, -1, null, 21) },
            { 22,         new Skill(22, "SKL_Name_0019", "SKL_Info_0019", 3, new float[] { 0.2f,1 }, -1, null, 22) },
            { 23,         new Skill(23, "SKL_Name_0020", "SKL_Info_0020", 3, new float[] { 0.2f,1 }, -1, null, 23) },
            { 24,         new Skill(24, "SKL_Name_0021", "SKL_Info_0021", 3, new float[] { 0.2f,1 }, -1, null, 24) },
            { 25,         new Skill(25, "SKL_Name_0022", "SKL_Info_0022", 6, new float[] { 0.2f,3 }, -1, null, 25) },
            { 26,         new Skill(26, "SKL_Name_0023", "SKL_Info_0023", 3, new float[] { 1.5f,0 }, -1, null, 26) },
            { 27,         new Skill(27, "SKL_Name_0024", "SKL_Info_0024", 4, new float[] { 0f,0 }, -1, null, 27) },
            { 28,         new Skill(28, "SKL_Name_0024", "SKL_Info_0024", 4, new float[] { 0f,0 }, -1, null, 28) },
            { 29,         new Skill(29, "SKL_Name_0025", "SKL_Info_0025", 4, new float[] { 5f,0 }, -1, null, 29) },
            { 30,         new Skill(30, "SKL_Name_0025", "SKL_Info_0025", 4, new float[] { 5f,0 }, -1, null, 30) },
            { 31,         new Skill(31, "SKL_Name_0026", "SKL_Info_0026", 10, new float[] { 0f,0 }, -1, "reward_img_007", 31) },
            { 32,         new Skill(32, "SKL_Name_0027", "SKL_Info_0027", 8, new float[] { 0f,0 }, -1, "reward_img_013", 32) },
            { 33,         new Skill(33, "SKL_Name_0028", "SKL_Info_0028", 6, new float[] { 0f,0 }, -1, "reward_img_010", 33) },
            { 34,         new Skill(34, "SKL_Name_0028", "SKL_Info_0028", 6, new float[] { 0f,0 }, -1, "reward_img_010", 34) },
            { 35,         new Skill(35, "SKL_Name_0028", "SKL_Info_0028", 6, new float[] { 0f,0 }, -1, "reward_img_010", 35) },
            { 36,         new Skill(36, "SKL_Name_0028", "SKL_Info_0028", 6, new float[] { 0f,0 }, -1, "reward_img_010", 36) },
            { 37,         new Skill(37, "SKL_Name_0028", "SKL_Info_0028", 6, new float[] { 0f,0 }, -1, "reward_img_010", 37) },
            { 38,         new Skill(38, "SKL_Name_0028", "SKL_Info_0028", 6, new float[] { 0f,0 }, -1, "reward_img_010", 38) },
            { 39,         new Skill(39, "SKL_Name_0029", "SKL_Info_0029", 3, new float[] { 10f,0 }, -1, null, 39) },
            { 40,         new Skill(40, "SKL_Name_0029", "SKL_Info_0029", 3, new float[] { 10f,0 }, -1, null, 40) },
            { 41,         new Skill(41, "SKL_Name_0030", "SKL_Info_0030", 5, new float[] { 0f,0 }, -1, "reward_img_004", 41) },
            { 42,         new Skill(42, "SKL_Name_0032", "SKL_Info_0032", 5, new float[] { 0f,0 }, -1, "reward_img_009", 42) },
            { 43,         new Skill(43, "SKL_Name_0031", "SKL_Info_0031", 3, new float[] { 0f,0 }, -1, "reward_img_008", 43) },
            { 44,         new Skill(44, "SKL_Name_0035", "SKL_Info_0035", 5, new float[] { 1f,0 }, -1, null, 44) },
            { 45,         new Skill(45, "SKL_Name_0036", "SKL_Info_0036", 2, new float[] { 0f,0 }, -1, "reward_img_003", 45) },
            { 46,         new Skill(46, "SKL_Name_0037", "SKL_Info_0037", 5, new float[] { 0f,0 }, -1, null, 46) },
            { 47,         new Skill(47, "SKL_Name_0038", "SKL_Info_0038", 5, new float[] { 0f,0 }, -1, "reward_img_002", 47) },
            { 48,         new Skill(48, "SKL_Name_0039", "SKL_Info_0039", 5, new float[] { 0f,0 }, -1, "reward_img_014", 48) },
            { 49,         new Skill(49, "SKL_Name_0040", "SKL_Info_0040", 5, new float[] { 0f,0 }, -1, "reward_img_012", 49) },
            { 50,         new Skill(50, "SKL_Name_0041", "SKL_Info_0041", 5, new float[] { 0f,0 }, -1, null, 50) },
            { 51,         new Skill(51, "SKL_Name_0041", "SKL_Info_0041", 5, new float[] { 0f,0 }, -1, null, 51) },
            { 52,         new Skill(52, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 0f,0 }, 5107, null, 52) },
            { 53,         new Skill(53, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 1f,0 }, -1, null, 53) },
            { 54,         new Skill(54, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 2f,0 }, -1, null, 54) },
            { 55,         new Skill(55, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 6f,0 }, 10810, null, 55) },
            { 56,         new Skill(56, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 7f,0 }, 11206, null, 56) },
            { 57,         new Skill(57, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 9f,0 }, -1, null, 57) },
            { 58,         new Skill(58, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 10f,0 }, -1, null, 58) },
            { 59,         new Skill(59, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 11f,0 }, -1, null, 59) },
            { 60,         new Skill(60, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 12f,0 }, 5107, null, 60) },
            { 61,         new Skill(61, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 13f,0 }, 5107, null, 61) },
            { 62,         new Skill(62, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 14f,0 }, 5108, null, 62) },
            { 63,         new Skill(63, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 18f,0 }, 10602, null, 63) },
            { 64,         new Skill(64, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 19f,0 }, -1, null, 64) },
            { 65,         new Skill(65, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 20f,0 }, 5107, null, 65) },
            { 66,         new Skill(66, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 21f,0 }, -1, null, 66) },
            { 67,         new Skill(67, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 22f,0 }, 11108, null, 67) },
            { 68,         new Skill(68, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 23f,0 }, 10206, null, 68) },
            { 69,         new Skill(69, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 3f,0 }, 10217, null, 69) },
            { 70,         new Skill(70, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 4f,0 }, 10117, null, 70) },
            { 71,         new Skill(71, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 5f,0 }, 11318, null, 71) },
            { 72,         new Skill(72, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 15f,0 }, 11014, null, 72) },
            { 73,         new Skill(73, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 16f,0 }, 5108, null, 73) },
            { 74,         new Skill(74, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 17f,0 }, -1, null, 74) },
            { 75,         new Skill(75, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 24f,0 }, -1, null, 75) },
            { 76,         new Skill(76, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 25f,0 }, -1, null, 76) },
            { 77,         new Skill(77, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 26f,0 }, -1, null, 77) },
            { 78,         new Skill(78, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 27f,0 }, 10421, null, 78) },
            { 79,         new Skill(79, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 28f,0 }, 10300, null, 79) },
            { 80,         new Skill(80, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 34f,0 }, 10511, null, 80) },
            { 81,         new Skill(81, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 35f,0 }, -1, null, 81) },
            { 82,         new Skill(82, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 36f,0 }, 5108, null, 82) },
            { 83,         new Skill(83, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 39f,0 }, -1, null, 83) },
            { 84,         new Skill(84, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 40f,0 }, 5108, null, 84) },
            { 85,         new Skill(85, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 41f,0 }, 11412, null, 85) },
            { 86,         new Skill(86, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 42f,0 }, 10101, null, 86) },
            { 87,         new Skill(87, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 43f,0 }, 5108, null, 87) },
            { 88,         new Skill(88, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 44f,0 }, -1, null, 88) },
            { 89,         new Skill(89, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 45f,0 }, 10702, null, 89) },
            { 90,         new Skill(90, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 29f,0 }, 10814, null, 90) },
            { 91,         new Skill(91, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 30f,0 }, -1, null, 91) },
            { 92,         new Skill(92, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 31f,0 }, 10913, null, 92) },
            { 93,         new Skill(93, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 32f,0 }, 11202, null, 93) },
            { 94,         new Skill(94, "Sphere_Reward_Item", "Com_ItemName", 2, new float[] { 46f,0 }, 11507, null, 94) },
            { 95,         new Skill(95, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 37f,0 }, -1, null, 95) },
            { 96,         new Skill(96, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 38f,0 }, -1, null, 96) },
            { 97,         new Skill(97, "SKL_Name_0033", "SKL_Info_0033", 1, new float[] { 33f,0 }, -1, null, 97) },
            { 98,         new Skill(98, "SKL_Name_0027", "SKL_Info_0027", 8, new float[] { 0f,0 }, -1, "reward_img_013", 98) }
        };

        private readonly Dictionary<ushort, SkillTree> SkillTreeItems = new Dictionary<ushort, SkillTree>()
        {
            { 0,         new SkillTree(0, "CHR_Name_0001_board", new string[] { "CHR_Info_0001_1","CHR_Info_0001_2" }, false, 16039000, "Day_Name_w1d4", "Com_Blank", -1, 0, -1, 8, "CHR_Main_001", 0, 0, -1, 0) },
            { 1,         new SkillTree(1, "CHR_Name_0002_board", new string[] { "CHR_Info_0002_1","CHR_Info_0002_2" }, false, 31010100, "Day_Name_w2d7", "Com_Blank", -1, 0, -1, 32, "CHR_Main_002", 0, 14, 0, 1) },
            { 2,         new SkillTree(2, "CHR_Name_0002", new string[] { "Com_Blank" }, false, -1, "Com_Blank", "Com_Blank", -1, 0, -1, -1, "CHR_Main_003", -1, -1, -1, 2) },
            { 3,         new SkillTree(3, "CHR_Name_0003_board", new string[] { "CHR_Info_0003" }, false, -1, "Day_Name_w1d4", "Com_Blank", -1, 0, -1, 0, "CHR_Main_004", 0, 0, 0, 3) },
            { 4,         new SkillTree(4, "CHR_Name_0004_board", new string[] { "CHR_Info_0004" }, false, -1, "Day_Name_w1d4", "Com_Blank", -1, 0, -1, 3, "CHR_Main_005", 3, 3, 0, 4) },
            { 5,         new SkillTree(5, "CHR_Name_0005_board", new string[] { "CHR_Info_0005_1","CHR_Info_0005_2" }, false, 23013000, "Day_Name_w2d2", "Com_Blank", -1, 0, -1, 9, "CHR_Main_006", 9, 9, 0, 5) },
            { 6,         new SkillTree(6, "CHR_Name_0006_board", new string[] { "CHR_Info_0006" }, false, -1, "Day_Name_w3d4", "Com_Blank", -1, 0, -1, 22, "CHR_Main_007", 18, 18, 0, 6) },
            { 7,         new SkillTree(7, "CHR_Name_0007_board", new string[] { "CHR_Info_0007_1","CHR_Info_0007_2" }, false, 17030100, "Day_Name_w1d4", "Com_Blank", -1, 0, -1, 1, "CHR_Main_008", 1, 1, 0, 7) },
            { 8,         new SkillTree(8, "CHR_Name_0010_board", new string[] { "CHR_Info_0010_1","CHR_Info_0010_2" }, false, 31010100, "Day_Name_w2d7", "Com_Blank", -1, 0, -1, 36, "CHR_Main_009", 4, 14, 11, 8) },
            { 9,         new SkillTree(9, "CHR_Name_0011_board", new string[] { "CHR_Info_0011_1","CHR_Info_0011_2" }, false, 38010200, "Day_Name_w1d5", "Com_Blank", -1, 0, -1, 12, "CHR_Main_010", 4, 5, 14, 9) },
            { 10,         new SkillTree(10, "CHR_Name_0012_board", new string[] { "CHR_Info_0012_1","CHR_Info_0012_2" }, false, 36010200, "Day_Name_w2d1", "Com_Blank", -1, 0, -1, 98, "CHR_Main_011", 8, 8, 11, 10) },
            { 11,         new SkillTree(11, "CHR_Name_0013_board", new string[] { "CHR_Info_0013_1","CHR_Info_0013_2" }, false, 31010100, "Day_Name_w3d6", "Com_Blank", -1, 0, -1, 38, "CHR_Main_012", 4, 20, 1, 11) },
            { 12,         new SkillTree(12, "CHR_Name_0014_board", new string[] { "CHR_Info_0014_1","CHR_Info_0014_2" }, false, 38500100, "Day_Name_w3d8", "Com_Blank", -1, 0, -1, 50, "CHR_Main_013", 15, 22, 13, 12) },
            { 13,         new SkillTree(13, "CHR_Name_0015_board", new string[] { "CHR_Info_0015" }, false, -1, "Day_Name_w2d3", "Com_Blank", -1, 0, -1, 43, "CHR_Main_014", 4, 10, 1, 13) },
            { 14,         new SkillTree(14, "CHR_Name_0016_board", new string[] { "CHR_Info_0016" }, false, -1, "Day_Name_w1d5", "Com_Blank", -1, 0, -1, 7, "CHR_Main_015", 5, 5, 1, 14) },
            { 15,         new SkillTree(15, "CHR_Name_0017_board", new string[] { "CHR_Info_0017" }, false, -1, "Day_Name_w1d5", "Com_Blank", -1, 0, -1, 33, "CHR_Main_016", 5, 5, 33, 15) },
            { 16,         new SkillTree(16, "CHR_Name_0018_board", new string[] { "CHR_Info_0018_1","CHR_Info_0018_2" }, false, 25011050, "Day_Name_w3d3", "Com_Blank", -1, 0, -1, 37, "CHR_Main_017", 4, 17, 3, 16) },
            { 17,         new SkillTree(17, "CHR_Name_0019_board", new string[] { "CHR_Info_0019_1","CHR_Info_0019_2" }, false, 27010100, "Day_Name_w2d6", "Com_Blank", -1, 0, -1, 17, "CHR_Main_018", 5, 13, 34, 17) },
            { 18,         new SkillTree(18, "CHR_Name_0020_board", new string[] { "CHR_Info_0020" }, false, -1, "Day_Name_w3d9", "Com_Blank", -1, 0, -1, 41, "CHR_Main_019", 23, 23, 19, 18) },
            { 19,         new SkillTree(19, "CHR_Name_0030_board", new string[] { "CHR_Info_0030" }, false, -1, "Day_Name_w3d9", "Com_Blank", -1, 0, -1, 2, "CHR_Main_020", 23, 23, 6, 19) },
            { 20,         new SkillTree(20, "CHR_Name_0031_board", new string[] { "CHR_Info_0031" }, false, -1, "Day_Name_w3d5", "Com_Blank", -1, 0, -1, 21, "CHR_Main_021", 19, 19, 7, 20) },
            { 21,         new SkillTree(21, "CHR_Name_0032_board", new string[] { "CHR_Info_0032_1","CHR_Info_0032_2" }, false, 35010100, "Day_Name_w2d3", "Com_Blank", -1, 0, -1, 26, "CHR_Main_022", 4, 10, 5, 21) },
            { 22,         new SkillTree(22, "CHR_Name_0033_board", new string[] { "CHR_Info_0033_1","CHR_Info_0033_2" }, false, 35010100, "Day_Name_w2d3", "Com_Blank", -1, 0, -1, 25, "CHR_Main_023", 10, 10, 21, 22) },
            { 23,         new SkillTree(23, "CHR_Name_0034_board", new string[] { "CHR_Info_0034" }, false, -1, "Day_Name_w3d9", "Com_Blank", -1, 0, -1, 18, "CHR_Main_024", 23, 23, 6, 23) },
            { 24,         new SkillTree(24, "CHR_Name_0035_board", new string[] { "CHR_Info_0035" }, false, -1, "Day_Name_w3d9", "Com_Blank", -1, 0, -1, 23, "CHR_Main_025", 23, 23, 5, 24) },
            { 25,         new SkillTree(25, "CHR_Name_0036", new string[] { "Com_Blank" }, false, -1, "Com_Blank", "Com_Blank", -1, 0, -1, -1, "CHR_Main_026", -1, -1, -1, 25) },
            { 26,         new SkillTree(26, "CHR_Name_0153", new string[] { "Com_Unknown","CHR_Info_0153" }, true, -1, "Day_Name_w1d4", "LOC_Name_chid", -1, 0, 1010, 46, "CHR_Sab_001", 4, 4, 4, 26) },
            { 27,         new SkillTree(27, "CHR_Name_0307", new string[] { "Com_Unknown","CHR_Info_0307" }, true, -1, "Day_Name_w2d5", "LOC_Name_104f", -1, 0, 1020, 20, "CHR_Sab_002", 12, 12, 26, 27) },
            { 28,         new SkillTree(28, "CHR_Name_0303", new string[] { "Com_Unknown","CHR_Info_0303" }, true, -1, "Day_Name_w1d4", "LOC_Name_dgen", -1, 0, 1030, 6, "CHR_Sab_003", 4, 4, 7, 28) },
            { 29,         new SkillTree(29, "CHR_Name_0301", new string[] { "Com_Unknown","CHR_Info_0301" }, true, -1, "Day_Name_w1d5", "LOC_Name_dgen", -1, 0, 1040, 5, "CHR_Sab_004", 5, 5, 28, 29) },
            { 30,         new SkillTree(30, "CHR_Name_0302", new string[] { "Com_Unknown","CHR_Info_0302" }, true, -1, "Day_Name_w2d4", "LOC_Name_dgen", -1, 0, 1050, 14, "CHR_Sab_005", 11, 11, 87, 30) },
            { 31,         new SkillTree(31, "CHR_Name_0154", new string[] { "Com_Unknown","CHR_Info_0154" }, true, -1, "Day_Name_w2d1", "LOC_Name_hara", -1, 0, 1060, 47, "CHR_Sab_006", 8, 8, 3, 31) },
            { 32,         new SkillTree(32, "CHR_Name_0155", new string[] { "Com_Unknown","CHR_Info_0155" }, true, -1, "Day_Name_w2d7", "LOC_Name_suto", -1, 0, 1070, 24, "CHR_Sab_007", 14, 14, 31, 32) },
            { 33,         new SkillTree(33, "CHR_Name_0304", new string[] { "Com_Unknown","CHR_Info_0304" }, true, -1, "Day_Name_w1d4", "LOC_Name_hika", -1, 0, 1080, 48, "CHR_Sab_008", 4, 4, 4, 33) },
            { 34,         new SkillTree(34, "CHR_Name_0305", new string[] { "Com_Unknown","CHR_Info_0305" }, true, -1, "Day_Name_w2d4", "LOC_Name_west", -1, 0, 1090, 16, "CHR_Sab_009", 11, 11, 68, 34) },
            { 35,         new SkillTree(35, "CHR_Name_0306", new string[] { "Com_Unknown","CHR_Info_0306" }, true, -1, "Day_Name_w3d1", "LOC_Name_chid", -1, 0, 1100, 42, "CHR_Sab_010", 15, 15, 16, 35) },
            { 36,         new SkillTree(36, "CHR_Name_0200", new string[] { "Com_Unknown","CHR_Info_0200" }, true, -1, "Day_Name_w1d7", "LOC_Name_scra", -1, 0, 1110, 10, "CHR_Sab_011", 7, 7, 7, 36) },
            { 37,         new SkillTree(37, "CHR_Name_0201", new string[] { "Com_Unknown","CHR_Info_0201" }, true, -1, "Day_Name_w2d7", "LOC_Name_hika", -1, 0, 1120, 44, "CHR_Sab_012", 14, 14, 13, 37) },
            { 38,         new SkillTree(38, "CHR_Name_0156", new string[] { "Com_Unknown","CHR_Info_0156" }, true, -1, "Day_Name_w2d2", "LOC_Name_kado", -1, 0, 1130, 27, "CHR_Sab_013", 9, 9, 4, 38) },
            { 39,         new SkillTree(39, "CHR_Name_0300", new string[] { "Com_Unknown","CHR_Info_0300" }, true, -1, "Day_Name_w3d2", "LOC_Name_aest", -1, 0, 1140, 28, "CHR_Sab_014", 16, 16, 38, 39) },
            { 40,         new SkillTree(40, "CHR_Name_0313", new string[] { "Com_Unknown","CHR_Info_0313" }, true, -1, "Day_Name_w3d1", "LOC_Name_hodo", -1, 0, 1150, 19, "CHR_Sab_015", 15, 15, 95, 40) },
            { 41,         new SkillTree(41, "CHR_Name_0317", new string[] { "Com_Unknown","CHR_Info_0317" }, true, -1, "Day_Name_w2d5", "LOC_Name_hodo", -1, 0, 1160, 34, "CHR_Sab_016", 12, 12, 5, 41) },
            { 42,         new SkillTree(42, "CHR_Name_0151", new string[] { "Com_Unknown","CHR_Info_0151" }, true, -1, "Day_Name_w1d5", "LOC_Name_scra", -1, 0, 1170, 49, "CHR_Sab_017", 5, 5, 4, 42) },
            { 43,         new SkillTree(43, "CHR_Name_0318", new string[] { "Com_Unknown","CHR_Info_0318" }, true, -1, "Day_Name_w2d5", "LOC_Name_scra", -1, 0, 1180, 13, "CHR_Sab_018", 12, 12, 95, 43) },
            { 44,         new SkillTree(44, "CHR_Name_0314", new string[] { "Com_Unknown","CHR_Info_0314" }, true, -1, "Day_Name_w1d5", "LOC_Name_spin", -1, 0, 1310, 45, "CHR_Mob_001", 5, 5, 7, 44) },
            { 45,         new SkillTree(45, "CHR_Name_0310", new string[] { "Com_Unknown","CHR_Info_0310" }, true, -1, "Day_Name_w1d7", "LOC_Name_cent", -1, 0, 1320, 51, "CHR_Mob_002", 7, 7, 46, 45) },
            { 46,         new SkillTree(46, "CHR_Name_0309", new string[] { "Com_Unknown","CHR_Info_0309" }, true, -1, "Day_Name_w2d2", "LOC_Name_hara", -1, 0, 1330, 39, "CHR_Mob_003", 9, 9, 91, 46) },
            { 47,         new SkillTree(47, "CHR_Name_0311", new string[] { "Com_Unknown","CHR_Info_0311" }, true, -1, "Day_Name_w2d4", "LOC_Name_dgen", -1, 0, 1340, 15, "CHR_Mob_004", 11, 11, 83, 47) },
            { 48,         new SkillTree(48, "CHR_Name_0316", new string[] { "Com_Unknown","CHR_Info_0316" }, true, -1, "Day_Name_w3d1", "LOC_Name_udag", -1, 0, 1350, 35, "CHR_Mob_005", 15, 15, 105, 48) },
            { 49,         new SkillTree(49, "CHR_Name_0312", new string[] { "Com_Unknown","CHR_Info_0312" }, true, -1, "Day_Name_w3d2", "LOC_Name_dgen", -1, 0, 1360, 40, "CHR_Mob_006", 16, 16, 46, 49) },
            { 50,         new SkillTree(50, "CHR_Name_0315", new string[] { "Com_Unknown","CHR_Info_0315" }, true, -1, "Day_Name_w3d4", "LOC_Name_hika", -1, 0, 1370, 29, "CHR_Mob_007", 18, 18, 1, 50) },
            { 51,         new SkillTree(51, "CHR_Name_0150", new string[] { "Com_Unknown","CHR_Info_0150" }, true, -1, "Day_Name_w3d6", "LOC_Name_kado", -1, 0, 1380, 31, "CHR_Mob_008", 20, 20, 42, 51) },
            { 52,         new SkillTree(52, "", new string[] { "Com_Blank" }, false, -1, "Com_Blank", "Com_Blank", -1, 0, -1, -1, "CHR_Mob_009", -1, -1, -1, 52) },
            { 53,         new SkillTree(53, "", new string[] { "Com_Blank" }, false, -1, "Com_Blank", "Com_Blank", -1, 0, -1, -1, "CHR_Mob_010", -1, -1, -1, 53) },
            { 54,         new SkillTree(54, "CHR_Name_0309", new string[] { "Com_Blank" }, false, -1, "Com_Blank", "Com_Blank", -1, 0, -1, -1, "CHR_Mob_011", -1, -1, -1, 54) },
            { 55,         new SkillTree(55, "", new string[] { "Com_Blank" }, false, -1, "Com_Blank", "Com_Blank", -1, 0, -1, -1, "CHR_Mob_012", -1, -1, -1, 55) },
            { 56,         new SkillTree(56, "CHR_Name_0311", new string[] { "Com_Blank" }, false, -1, "Com_Blank", "Com_Blank", -1, 0, -1, -1, "CHR_Mob_013", -1, -1, -1, 56) },
            { 57,         new SkillTree(57, "", new string[] { "Com_Blank" }, false, -1, "Com_Blank", "Com_Blank", -1, 0, -1, -1, "CHR_Mob_014", -1, -1, -1, 57) },
            { 58,         new SkillTree(58, "", new string[] { "Com_Blank" }, false, -1, "Com_Blank", "Com_Blank", -1, 0, -1, -1, "CHR_Mob_015", -1, -1, -1, 58) },
            { 59,         new SkillTree(59, "", new string[] { "Com_Blank" }, false, -1, "Com_Blank", "Com_Blank", -1, 0, -1, -1, "CHR_Mob_016", -1, -1, -1, 59) },
            { 60,         new SkillTree(60, "", new string[] { "Com_Blank" }, false, -1, "Com_Blank", "Com_Blank", -1, 0, -1, -1, "CHR_Mob_017", -1, -1, -1, 60) },
            { 61,         new SkillTree(61, "", new string[] { "Com_Blank" }, false, -1, "Com_Blank", "Com_Blank", -1, 0, -1, -1, "CHR_Mob_018", -1, -1, -1, 61) },
            { 62,         new SkillTree(62, "CHR_Name_0319", new string[] { "Com_Unknown","CHR_Info_0319" }, true, -1, "Day_Name_w3d2", "LOC_Name_hodo", -1, 0, 1290, 30, "CHR_Mob_019", 16, 16, 95, 62) },
            { 63,         new SkillTree(63, "CHR_Name_0308", new string[] { "Com_Unknown","CHR_Info_0308" }, true, -1, "Day_Name_w3d4", "LOC_Name_kado", -1, 0, 1300, 4, "CHR_Mob_020", 18, 18, 98, 63) },
            { 64,         new SkillTree(64, "CHR_Name_0101", new string[] { "CHR_Info_0101_1","CHR_Info_0101_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 0, 3, -1, 52, "CHR_Shop_001", 4, 4, 15, 64) },
            { 65,         new SkillTree(65, "CHR_Name_0102", new string[] { "CHR_Info_0102_1","CHR_Info_0102_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 1, 3, -1, 53, "CHR_Shop_002", 4, 4, 66, 65) },
            { 66,         new SkillTree(66, "CHR_Name_0103", new string[] { "CHR_Info_0103_1","CHR_Info_0103_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 2, 3, -1, 54, "CHR_Shop_003", 4, 4, 3, 66) },
            { 67,         new SkillTree(67, "CHR_Name_0107", new string[] { "CHR_Info_0107_1","CHR_Info_0107_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 6, 3, -1, 55, "CHR_Shop_004", 4, 4, 73, 67) },
            { 68,         new SkillTree(68, "CHR_Name_0108", new string[] { "CHR_Info_0108_1","CHR_Info_0108_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 7, 3, -1, 56, "CHR_Shop_005", 4, 4, 3, 68) },
            { 69,         new SkillTree(69, "CHR_Name_0110", new string[] { "CHR_Info_0110_1","CHR_Info_0110_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 8, 3, -1, 57, "CHR_Shop_006", 4, 4, 87, 69) },
            { 70,         new SkillTree(70, "CHR_Name_0111", new string[] { "CHR_Info_0111_1","CHR_Info_0111_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 9, 3, -1, 58, "CHR_Shop_007", 4, 4, 87, 70) },
            { 71,         new SkillTree(71, "CHR_Name_0112", new string[] { "CHR_Info_0112_1","CHR_Info_0112_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 10, 3, -1, 59, "CHR_Shop_008", 4, 4, 26, 71) },
            { 72,         new SkillTree(72, "CHR_Name_0113", new string[] { "CHR_Info_0113_1","CHR_Info_0113_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 11, 3, -1, 60, "CHR_Shop_009", 4, 4, 73, 72) },
            { 73,         new SkillTree(73, "CHR_Name_0114", new string[] { "CHR_Info_0114_1","CHR_Info_0114_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 12, 3, -1, 61, "CHR_Shop_010", 4, 4, 26, 73) },
            { 74,         new SkillTree(74, "CHR_Name_0115", new string[] { "CHR_Info_0115_1","CHR_Info_0115_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 13, 3, -1, 62, "CHR_Shop_011", 4, 4, 73, 74) },
            { 75,         new SkillTree(75, "CHR_Name_0119", new string[] { "CHR_Info_0119_1","CHR_Info_0119_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 17, 3, -1, 63, "CHR_Shop_012", 4, 4, 68, 75) },
            { 76,         new SkillTree(76, "CHR_Name_0120", new string[] { "CHR_Info_0120_1","CHR_Info_0120_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 18, 3, -1, 64, "CHR_Shop_013", 4, 4, 73, 76) },
            { 77,         new SkillTree(77, "CHR_Name_0121", new string[] { "CHR_Info_0121_1","CHR_Info_0121_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 19, 3, -1, 65, "CHR_Shop_014", 4, 4, 4, 77) },
            { 78,         new SkillTree(78, "CHR_Name_0122", new string[] { "CHR_Info_0122_1","CHR_Info_0122_2" }, true, -1, "Day_Name_w1d5", "Com_Blank", 20, 3, -1, 66, "CHR_Shop_015", 5, 5, 66, 78) },
            { 79,         new SkillTree(79, "CHR_Name_0123", new string[] { "CHR_Info_0123_1","CHR_Info_0123_2" }, true, -1, "Day_Name_w1d5", "Com_Blank", 21, 3, -1, 67, "CHR_Shop_016", 5, 5, 44, 79) },
            { 80,         new SkillTree(80, "CHR_Name_0124", new string[] { "CHR_Info_0124_1","CHR_Info_0124_2" }, true, -1, "Day_Name_w1d5", "Com_Blank", 22, 3, -1, 68, "CHR_Shop_017", 5, 5, 26, 80) },
            { 81,         new SkillTree(81, "CHR_Name_0104", new string[] { "CHR_Info_0104_1","CHR_Info_0104_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 3, 3, -1, 69, "CHR_Shop_018", 4, 4, 80, 81) },
            { 82,         new SkillTree(82, "CHR_Name_0105", new string[] { "CHR_Info_0105_1","CHR_Info_0105_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 4, 3, -1, 70, "CHR_Shop_019", 4, 4, 44, 82) },
            { 83,         new SkillTree(83, "CHR_Name_0106", new string[] { "CHR_Info_0106_1","CHR_Info_0106_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 5, 3, -1, 71, "CHR_Shop_020", 4, 4, 32, 83) },
            { 84,         new SkillTree(84, "CHR_Name_0116", new string[] { "CHR_Info_0116_1","CHR_Info_0116_2" }, true, -1, "Day_Name_w1d6", "Com_Blank", 14, 3, -1, 72, "CHR_Shop_021", 6, 6, 31, 84) },
            { 85,         new SkillTree(85, "CHR_Name_0117", new string[] { "CHR_Info_0117_1","CHR_Info_0117_2" }, true, -1, "Day_Name_w1d6", "Com_Blank", 15, 3, -1, 73, "CHR_Shop_022", 6, 6, 77, 85) },
            { 86,         new SkillTree(86, "CHR_Name_0118", new string[] { "CHR_Info_0118_1","CHR_Info_0118_2" }, true, -1, "Day_Name_w1d6", "Com_Blank", 16, 3, -1, 74, "CHR_Shop_023", 6, 6, 66, 86) },
            { 87,         new SkillTree(87, "CHR_Name_0125", new string[] { "CHR_Info_0125_1","CHR_Info_0125_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 23, 3, -1, 75, "CHR_Shop_024", 4, 4, 29, 87) },
            { 88,         new SkillTree(88, "CHR_Name_0126", new string[] { "CHR_Info_0126_1","CHR_Info_0126_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 24, 3, -1, 76, "CHR_Shop_025", 4, 4, 87, 88) },
            { 89,         new SkillTree(89, "CHR_Name_0127", new string[] { "CHR_Info_0127_1","CHR_Info_0127_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 25, 3, -1, 77, "CHR_Shop_026", 4, 4, 70, 89) },
            { 90,         new SkillTree(90, "CHR_Name_0128m", new string[] { "CHR_Info_0128m_1","CHR_Info_0128m_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 26, 3, -1, 78, "CHR_Shop_027", 4, 4, 38, 90) },
            { 91,         new SkillTree(91, "CHR_Name_0128f", new string[] { "CHR_Info_0128f_1","CHR_Info_0128f_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 26, 3, -1, 11, "CHR_Shop_028", 4, 4, 90, 91) },
            { 92,         new SkillTree(92, "CHR_Name_0129", new string[] { "CHR_Info_0129_1","CHR_Info_0129_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 27, 3, -1, 79, "CHR_Shop_029", 4, 4, 85, 92) },
            { 93,         new SkillTree(93, "CHR_Name_0135", new string[] { "CHR_Info_0135_1","CHR_Info_0135_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 33, 3, -1, 80, "CHR_Shop_030", 4, 4, 94, 93) },
            { 94,         new SkillTree(94, "CHR_Name_0136", new string[] { "CHR_Info_0136_1","CHR_Info_0136_2" }, true, -1, "Day_Name_w1d4", "Com_Blank", 34, 3, -1, 81, "CHR_Shop_031", 4, 4, 79, 94) },
            { 95,         new SkillTree(95, "CHR_Name_0137", new string[] { "CHR_Info_0137_1","CHR_Info_0137_2" }, true, -1, "Day_Name_w1d7", "Com_Blank", 35, 3, -1, 82, "CHR_Shop_032", 7, 7, 36, 95) },
            { 96,         new SkillTree(96, "CHR_Name_0140", new string[] { "CHR_Info_0140_1","CHR_Info_0140_2" }, true, -1, "Day_Name_w2d1", "Com_Blank", 38, 3, -1, 83, "CHR_Shop_033", 8, 8, 78, 96) },
            { 97,         new SkillTree(97, "CHR_Name_0141", new string[] { "CHR_Info_0141_1","CHR_Info_0141_2" }, true, -1, "Day_Name_w2d1", "Com_Blank", 39, 3, -1, 84, "CHR_Shop_034", 8, 8, 31, 97) },
            { 98,         new SkillTree(98, "CHR_Name_0142", new string[] { "CHR_Info_0142_1","CHR_Info_0142_2" }, true, -1, "Day_Name_w2d1", "Com_Blank", 40, 3, -1, 85, "CHR_Shop_035", 8, 8, 41, 98) },
            { 99,         new SkillTree(99, "CHR_Name_0143", new string[] { "CHR_Info_0143_1","CHR_Info_0143_2" }, true, -1, "Day_Name_w2d1", "Com_Blank", 41, 3, -1, 86, "CHR_Shop_036", 8, 8, 82, 99) },
            { 100,         new SkillTree(100, "CHR_Name_0144", new string[] { "CHR_Info_0144_1","CHR_Info_0144_2" }, true, -1, "Day_Name_w2d1", "Com_Blank", 42, 3, -1, 87, "CHR_Shop_037", 8, 8, 26, 100) },
            { 101,         new SkillTree(101, "CHR_Name_0145", new string[] { "CHR_Info_0145_1","CHR_Info_0145_2" }, true, -1, "Day_Name_w2d1", "Com_Blank", 43, 3, -1, 88, "CHR_Shop_038", 8, 8, 71, 101) },
            { 102,         new SkillTree(102, "CHR_Name_0146", new string[] { "CHR_Info_0146_1","CHR_Info_0146_2" }, true, -1, "Day_Name_w2d1", "Com_Blank", 44, 3, -1, 89, "CHR_Shop_039", 8, 8, 38, 102) },
            { 103,         new SkillTree(103, "CHR_Name_0130", new string[] { "CHR_Info_0130_1","CHR_Info_0130_2" }, true, -1, "Day_Name_w2d2", "Com_Blank", 28, 3, -1, 90, "CHR_Shop_040", 9, 9, 95, 103) },
            { 104,         new SkillTree(104, "CHR_Name_0131", new string[] { "CHR_Info_0131_1","CHR_Info_0131_2" }, true, -1, "Day_Name_w2d2", "Com_Blank", 29, 3, -1, 91, "CHR_Shop_041", 9, 9, 85, 104) },
            { 105,         new SkillTree(105, "CHR_Name_0132", new string[] { "CHR_Info_0132_1","CHR_Info_0132_2" }, true, -1, "Day_Name_w2d2", "Com_Blank", 30, 3, -1, 92, "CHR_Shop_042", 9, 9, 5, 105) },
            { 106,         new SkillTree(106, "CHR_Name_0133", new string[] { "CHR_Info_0133_1","CHR_Info_0133_2" }, true, -1, "Day_Name_w2d2", "Com_Blank", 31, 3, -1, 93, "CHR_Shop_043", 9, 9, 68, 106) },
            { 107,         new SkillTree(107, "CHR_Name_0138", new string[] { "CHR_Info_0138_1","CHR_Info_0138_2" }, true, -1, "Day_Name_w2d7", "Com_Blank", 36, 3, -1, 95, "CHR_Shop_044", 14, 14, 65, 107) },
            { 108,         new SkillTree(108, "CHR_Name_0139", new string[] { "CHR_Info_0139_1","CHR_Info_0139_2" }, true, -1, "Day_Name_w2d7", "Com_Blank", 37, 3, -1, 96, "CHR_Shop_045", 14, 14, 71, 108) },
            { 109,         new SkillTree(109, "CHR_Name_0134", new string[] { "CHR_Info_0134_1","CHR_Info_0134_2" }, true, -1, "Day_Name_w3d2", "Com_Blank", 32, 3, -1, 97, "CHR_Shop_046", 16, 16, 32, 109) },
            { 110,         new SkillTree(110, "CHR_Name_0147", new string[] { "CHR_Info_0147_1","CHR_Info_0147_2" }, true, -1, "Day_Name_w2d2", "Com_Blank", 45, 3, -1, 94, "CHR_Shop_047", 9, 9, 106, 110) }
        };

        private readonly Dictionary<int, SkillTree> SkillTreeItems_SaveIndexed;

        public SocialNetworkManager()
        {
            SkillTreeItems_SaveIndexed = SkillTreeItems.ToDictionary(s => s.Value.SaveIndex, s => s.Value);
        }


        public Dictionary<ushort, SkillTree> GetSkillTreeItems(int ParentId)
        {
            // There are unused entries in the game. We don't want them.
            return SkillTreeItems.Where(s => s.Value.ParentId == ParentId && s.Value.SkillId >= 0).ToDictionary(s => s.Key, s => s.Value);
        }

        public Dictionary<ushort, SkillTree> GetSkillTreeItems()
        {
            // There are unused entries in the game. We don't want them.
            return SkillTreeItems.Where(s => s.Value.SkillId >= 0).ToDictionary(s => s.Key, s => s.Value);
        }

        public Dictionary<int, SkillTree> GetSaveIndexedTreeItems()
        {
            return SkillTreeItems_SaveIndexed;
        }

        public List<Skill> GetSkills()
        {
            return Skills.Values.ToList();
        }

        public SkillTree GetSkillTreeItemWithSaveIndex(int SaveIndex)
        {
            if (SkillTreeItems_SaveIndexed.ContainsKey(SaveIndex))
            {
                return SkillTreeItems_SaveIndexed[SaveIndex];
            }
            return null;
        }

        public SkillTree GetSkillTreeItem(ushort Id)
        {
            if (SkillTreeItems.ContainsKey(Id))
            {
                return SkillTreeItems[Id];
            }

            return null;
        }

        public Skill GetSkill(ushort Id)
        {
            if (Skills.ContainsKey(Id))
            {
                return Skills[Id];
            }

            return null;
        }
    }
}
