using System;
using System.Collections.Generic;

namespace NTwewyDb
{
    public class ItemManager
    {
        #region Generated Dictionaries
        private readonly Dictionary<ushort, IGameItem> GameItems = new Dictionary<ushort, IGameItem>
        {
            { 1000, new PinItem(1000, 100, ItemType.Pin, "ITM_BDG_Name_0001", "ITM_BDG_Info_0001", "ID001_NoBrand", 0, 400, 1, 100, 1, 48, 0f, 6, 4.5f, 6.8f, 3, 1, 1f, null, 290, 0,  0, -1, null, 0) },
            { 1003, new PinItem(1003, 101, ItemType.Pin, "ITM_BDG_Name_0002", "ITM_BDG_Info_0002", "ID002_JupiterOfTheMonkey", 9, 403, 1, 103, 1, 95, 0f, 6, 4.5f, 6.8f, 4, 1, 1.3f, null, 400, 0,  0, -1, null, 0) },
            { 1004, new PinItem(1004, 102, ItemType.Pin, "ITM_BDG_Name_0003", "ITM_BDG_Info_0003", "ID003_JupiterOfTheMonkey", 9, 404, 1, 104, 1, 467, 0f, 6, 8.8f, 13.2f, 10, 1, 5f, new ushort[] { 2011 }, 0, 5,  0, -1, null, 5) },
            { 1001, new PinItem(1001, 104, ItemType.Pin, "ITM_BDG_Name_0004", "ITM_BDG_Info_0004", "ID004_JupiterOfTheMonkey", 9, 401, 1, 101, 1, 110, 0f, 6, 6f, 9f, 5, 2, 1.3f, null, 380, 0,  0, -1, null, 1) },
            { 1002, new PinItem(1002, 105, ItemType.Pin, "ITM_BDG_Name_0005", "ITM_BDG_Info_0005", "ID005_JupiterOfTheMonkey", 9, 402, 1, 102, 1, 1326, 0f, 6, 12f, 18f, 7, 2, 44.32f, null, 2220, 5,  7, -1, new short[] { 103,-1,-1,-1,-1,-1,-1 }, 1) },
            { 1005, new PinItem(1005, 103, ItemType.Pin, "ITM_BDG_Name_0006", "ITM_BDG_Info_0006", "ID006_JupiterOfTheMonkey", 9, 405, 6, 105, 1, 1221, 0f, 6, 13.2f, 19.8f, 7, 4, 58.99f, null, 3010, 5,  0, -1, null, 4) },
            { 1006, new PinItem(1006, 106, ItemType.Pin, "ITM_BDG_Name_0007", "ITM_BDG_Info_0007", "ID007_JupiterOfTheMonkey", 9, 406, 1, 106, 6, 787, 0f, 12, 9.6f, 14.4f, 5, 4, 10.98f, new ushort[] { 1003 }, 1380, 5,  0, -1, null, 9) },
            { 1007, new PinItem(1007, 107, ItemType.Pin, "ITM_BDG_Name_0008", "ITM_BDG_Info_0008", "ID008_JupiterOfTheMonkey", 9, 407, 1, 107, 6, 1414, 0f, 12, 14.4f, 21.6f, 3, 5, 58.99f, new ushort[] { 1003 }, 2610, 5,  0, -1, null, 9) },
            { 1008, new PinItem(1008, 108, ItemType.Pin, "ITM_BDG_Name_0009", "ITM_BDG_Info_0009", "ID009_NoBrand", 0, 408, 6, 108, 1, 1012, 0f, 1, 8.3f, 12.5f, 3, 2, 36.63f, null, 2660, 5,  0, -1, null, 0) },
            { 1009, new PinItem(1009, 109, ItemType.Pin, "ITM_BDG_Name_0010", "ITM_BDG_Info_0010", "ID010_JupiterOfTheMonkey", 9, 409, 2, 109, 1, 214, 0f, 8, 6f, 9f, 3, 1, 2.19f, null, 840, 0,  3, 112, null, 0) },
            { 1012, new PinItem(1012, 112, ItemType.Pin, "ITM_BDG_Name_0011", "ITM_BDG_Info_0011", "ID011_JupiterOfTheMonkey", 9, 412, 2, 112, 1, 347, 0f, 8, 6f, 9f, 3, 2, 3.71f, null, 1170, 0,  0, -1, null, 0) },
            { 1013, new PinItem(1013, 113, ItemType.Pin, "ITM_BDG_Name_0012", "ITM_BDG_Info_0012", "ID012_JupiterOfTheMonkey", 9, 413, 2, 113, 6, 812, 0f, 14, 6f, 9f, 7, 2, 18.56f, new ushort[] { 1003 }, 0, 5,  0, -1, null, 0) },
            { 1010, new PinItem(1010, 110, ItemType.Pin, "ITM_BDG_Name_0013", "ITM_BDG_Info_0013", "ID013_JupiterOfTheMonkey", 9, 410, 2, 110, 1, 633, 0f, 8, 8f, 12f, 6, 2, 6.5f, null, 1570, 5,  6, 111, null, 1) },
            { 1011, new PinItem(1011, 111, ItemType.Pin, "ITM_BDG_Name_0014", "ITM_BDG_Info_0014", "ID014_JupiterOfTheMonkey", 9, 411, 2, 111, 1, 1095, 0f, 8, 10f, 15f, 8, 5, 33.3f, null, 2500, 5,  0, -1, null, 1) },
            { 1014, new PinItem(1014, 114, ItemType.Pin, "ITM_BDG_Name_0015", "ITM_BDG_Info_0015", "ID015_croakypanic", 14, 414, 2, 114, 1, 1115, 0f, 8, 12f, 18f, 10, 4, 44.32f, new ushort[] { 2011 }, 3470, 0,  0, -1, null, 5) },
            { 1015, new PinItem(1015, 115, ItemType.Pin, "ITM_BDG_Name_0016", "ITM_BDG_Info_0016", "ID016_JupiterOfTheMonkey", 9, 415, 6, 115, 1, 280, 0f, 6, 6f, 9f, 3, 2, 2.85f, null, 940, 0,  0, -1, null, 4) },
            { 1016, new PinItem(1016, 116, ItemType.Pin, "ITM_BDG_Name_0017", "ITM_BDG_Info_0017", "ID017_JupiterOfTheMonkey", 9, 416, 6, 116, 1, 1259, 0f, 6, 13.2f, 19.8f, 3, 2, 58.99f, null, 3910, 0,  0, -1, null, 4) },
            { 1017, new PinItem(1017, 117, ItemType.Pin, "ITM_BDG_Name_0018", "ITM_BDG_Info_0018", "ID018_JupiterOfTheMonkey", 9, 417, 1, 117, 1, 896, 0f, 6, 12f, 18f, 6, 4, 33.3f, new ushort[] { 133 }, 2000, 0,  6, -1, new short[] { -1,-1,-1,-1,-1,118,-1 }, 10) },
            { 1018, new PinItem(1018, 118, ItemType.Pin, "ITM_BDG_Name_0019", "ITM_BDG_Info_0019", "ID019_JupiterOfTheMonkey", 9, 418, 1, 118, 1, 1121, 0f, 6, 14.4f, 21.6f, 5, 5, 53.62f, new ushort[] { 133 }, 2940, 0,  0, -1, null, 10) },
            { 1019, new PinItem(1019, 200, ItemType.Pin, "ITM_BDG_Name_0020", "ITM_BDG_Info_0020", "ID020_TigrePUNKS", 3, 419, 1, 200, 1, 214, 0f, 6, 5.4f, 8.1f, 3, 2, 2.19f, null, 750, 0,  3, 201, null, 0) },
            { 1020, new PinItem(1020, 201, ItemType.Pin, "ITM_BDG_Name_0021", "ITM_BDG_Info_0021", "ID021_TigrePUNKS", 3, 420, 1, 201, 1, 347, 0f, 6, 6.6f, 9.9f, 3, 2, 3.71f, null, 1030, 0,  0, -1, null, 0) },
            { 1021, new PinItem(1021, 202, ItemType.Pin, "ITM_BDG_Name_0022", "ITM_BDG_Info_0022", "ID022_TigrePUNKS", 3, 421, 1, 202, 1, 402, 0f, 6, 9.7f, 14.6f, 5, 2, 3.71f, null, 960, 0,  0, -1, null, 1) },
            { 1022, new PinItem(1022, 203, ItemType.Pin, "ITM_BDG_Name_0023", "ITM_BDG_Info_0023", "ID023_TigrePUNKS", 3, 422, 1, 203, 1, 1370, 0f, 6, 14.5f, 21.8f, 6, 4, 53.62f, null, 2840, 5,  0, -1, null, 1) },
            { 1023, new PinItem(1023, 204, ItemType.Pin, "ITM_BDG_Name_0024", "ITM_BDG_Info_0024", "ID024_TigrePUNKS", 3, 423, 26, 204, 4, 1249, 3.5f, 0, 13.2f, 19.8f, 3, 2, 40.29f, null, 4190, 5,  0, -1, null, 1) },
            { 1024, new PinItem(1024, 205, ItemType.Pin, "ITM_BDG_Name_0025", "ITM_BDG_Info_0025", "ID025_TigrePUNKS", 3, 424, 11, 205, 4, 645, 4.5f, 0, 10.6f, 15.9f, 5, 2, 8.45f, null, 2100, 5,  5, 206, null, 2) },
            { 1025, new PinItem(1025, 206, ItemType.Pin, "ITM_BDG_Name_0026", "ITM_BDG_Info_0026", "ID026_TigrePUNKS", 3, 425, 11, 206, 4, 855, 4.5f, 0, 10.6f, 15.9f, 6, 4, 18.56f, null, 600, 5,  6, -1, new short[] { -1,-1,-1,-1,204,-1,-1 }, 2) },
            { 1026, new PinItem(1026, 207, ItemType.Pin, "ITM_BDG_Name_0027", "ITM_BDG_Info_0027", "ID027_TigrePUNKS", 3, 426, 1, 207, 6, 833, 0f, 6, 13.2f, 19.8f, 5, 1, 24.13f, new ushort[] { 1003 }, 2120, 0,  5, 208, null, 8) },
            { 1027, new PinItem(1027, 208, ItemType.Pin, "ITM_BDG_Name_0028", "ITM_BDG_Info_0028", "ID028_TigrePUNKS", 3, 427, 1, 208, 6, 1022, 0f, 6, 13.2f, 19.8f, 8, 4, 40.29f, new ushort[] { 1003 }, 2540, 0,  0, -1, null, 8) },
            { 1028, new PinItem(1028, 209, ItemType.Pin, "ITM_BDG_Name_0029", "ITM_BDG_Info_0029", "ID029_TigrePUNKS", 3, 428, 10, 209, 1, 280, 0f, 6, 6.6f, 9.9f, 3, 2, 2.85f, null, 940, 0,  0, -1, null, 0) },
            { 1029, new PinItem(1029, 210, ItemType.Pin, "ITM_BDG_Name_0030", "ITM_BDG_Info_0030", "ID030_TigrePUNKS", 3, 429, 10, 210, 1, 505, 0f, 6, 8.8f, 13.2f, 3, 2, 5f, new ushort[] { 1004 }, 1360, 0,  0, -1, null, 6) },
            { 1030, new PinItem(1030, 211, ItemType.Pin, "ITM_BDG_Name_0031", "ITM_BDG_Info_0031", "ID031_TigrePUNKS", 3, 430, 10, 211, 1, 925, 0f, 6, 11f, 16.5f, 5, 2, 24.13f, new ushort[] { 1004 }, 2260, 5,  0, -1, null, 6) },
            { 1031, new PinItem(1031, 212, ItemType.Pin, "ITM_BDG_Name_0032", "ITM_BDG_Info_0032", "ID032_NoBrand", 0, 431, 10, 212, 1, 1325, 0f, 3, 14.5f, 21.8f, 3, 2, 58.99f, null, 3570, 5,  0, -1, null, 6) },
            { 1032, new PinItem(1032, 300, ItemType.Pin, "ITM_BDG_Name_0033", "ITM_BDG_Info_0033", "ID033_MONOCROW", 10, 432, 6, 300, 1, 147, 0f, 3, 5f, 7.5f, 3, 4, 1.69f, null, 730, 0,  3, 301, null, 0) },
            { 1033, new PinItem(1033, 301, ItemType.Pin, "ITM_BDG_Name_0034", "ITM_BDG_Info_0034", "ID034_MONOCROW", 10, 433, 6, 301, 1, 280, 0f, 3, 6.6f, 9.9f, 7, 4, 2.85f, null, 1080, 0,  0, -1, null, 0) },
            { 1034, new PinItem(1034, 302, ItemType.Pin, "ITM_BDG_Name_0035", "ITM_BDG_Info_0035", "ID035_MONOCROW", 10, 434, 6, 302, 1, 945, 0f, 3, 9f, 13.5f, 3, 2, 33.3f, null, 2890, 0,  0, -1, null, 0) },
            { 1035, new PinItem(1035, 303, ItemType.Pin, "ITM_BDG_Name_0036", "ITM_BDG_Info_0036", "ID036_MONOCROW", 10, 435, 6, 303, 6, 925, 0f, 7, 7.5f, 11.3f, 10, 5, 24.13f, new ushort[] { 1003 }, 2940, 5,  10, 304, null, 7) },
            { 1036, new PinItem(1036, 304, ItemType.Pin, "ITM_BDG_Name_0037", "ITM_BDG_Info_0037", "ID037_MONOCROW", 10, 436, 6, 304, 6, 1065, 0f, 10, 9f, 13.5f, 15, 5, 36.63f, new ushort[] { 1003 }, 3330, 5,  0, -1, null, 7) },
            { 1037, new PinItem(1037, 305, ItemType.Pin, "ITM_BDG_Name_0038", "ITM_BDG_Info_0038", "ID038_MONOCROW", 10, 437, 15, 305, 1, 402, 0f, 999, 14.4f, 21.6f, 3, 1, 3.71f, new ushort[] { 1001 }, 1330, 0,  0, -1, null, 9) },
            { 1038, new PinItem(1038, 306, ItemType.Pin, "ITM_BDG_Name_0039", "ITM_BDG_Info_0039", "ID039_MONOCROW", 10, 438, 15, 306, 1, 787, 0f, 999, 14.4f, 21.6f, 3, 2, 10.98f, new ushort[] { 1001 }, 2310, 0,  0, -1, null, 9) },
            { 1039, new PinItem(1039, 307, ItemType.Pin, "ITM_BDG_Name_0040", "ITM_BDG_Info_0040", "ID040_MONOCROW", 10, 439, 9, 307, 1, 1121, 0f, 999, 16.8f, 25.2f, 3, 2, 53.62f, new ushort[] { 1001 }, 4010, 5,  3, -1, new short[] { -1,-1,-1,-1,-1,-1,308 }, 23) },
            { 1040, new PinItem(1040, 308, ItemType.Pin, "ITM_BDG_Name_0041", "ITM_BDG_Info_0041", "ID041_MONOCROW", 10, 440, 9, 308, 1, 1193, 0f, 999, 16.8f, 25.2f, 3, 2, 58.99f, new ushort[] { 1001 }, 4770, 5,  0, -1, null, 23) },
            { 1041, new PinItem(1041, 309, ItemType.Pin, "ITM_BDG_Name_0042", "ITM_BDG_Info_0042", "ID042_NoBrand", 0, 441, 9, 309, 1, 1193, 0f, 999, 16.8f, 25.2f, 3, 2, 58.99f, new ushort[] { 1001 }, 4770, 5,  0, -1, null, 23) },
            { 1042, new PinItem(1042, 310, ItemType.Pin, "ITM_BDG_Name_0043", "ITM_BDG_Info_0043", "ID043_MONOCROW", 10, 442, 10, 310, 1, 435, 0f, 6, 14.4f, 21.6f, 5, 1, 4.82f, new ushort[] { 1002 }, 1500, 0,  5, 311, null, 3) },
            { 1043, new PinItem(1043, 311, ItemType.Pin, "ITM_BDG_Name_0044", "ITM_BDG_Info_0044", "ID044_MONOCROW", 10, 443, 10, 311, 1, 575, 0f, 10, 13f, 19.5f, 3, 2, 6.5f, new ushort[] { 1002 }, 1870, 0,  0, -1, null, 3) },
            { 1044, new PinItem(1044, 312, ItemType.Pin, "ITM_BDG_Name_0045", "ITM_BDG_Info_0045", "ID045_MONOCROW", 10, 444, 10, 312, 1, 1325, 0f, 10, 17.3f, 26f, 3, 2, 58.99f, new ushort[] { 1002 }, 4660, 5,  3, -1, null, 3) },
            { 1045, new PinItem(1045, 313, ItemType.Pin, "ITM_BDG_Name_0046", "ITM_BDG_Info_0046", "ID046_MONOCROW", 10, 445, 10, 313, 1, 1085, 0f, 6, 16.2f, 24.3f, 3, 4, 44.32f, new ushort[] { 1002 }, 3050, 5,  3, 314, null, 23) },
            { 1046, new PinItem(1046, 314, ItemType.Pin, "ITM_BDG_Name_0047", "ITM_BDG_Info_0047", "ID047_MONOCROW", 10, 446, 10, 314, 1, 1139, 0f, 6, 17.3f, 26f, 5, 2, 58.99f, new ushort[] { 1002 }, 3540, 5,  0, -1, null, 23) },
            { 1047, new PinItem(1047, 400, ItemType.Pin, "ITM_BDG_Name_0048", "ITM_BDG_Info_0048", "ID048_NoBrand", 0, 447, 1, 400, 2, 48, 0f, 8, 4.5f, 6.8f, 3, 1, 1f, null, 240, 0,  0, -1, null, 0) },
            { 1048, new PinItem(1048, 401, ItemType.Pin, "ITM_BDG_Name_0049", "ITM_BDG_Info_0049", "ID049_NATURALPUPPY", 11, 448, 1, 401, 2, 95, 0f, 8, 4.5f, 6.8f, 3, 1, 1.3f, null, 360, 0,  3, 402, null, 0) },
            { 1049, new PinItem(1049, 402, ItemType.Pin, "ITM_BDG_Name_0050", "ITM_BDG_Info_0050", "ID050_NATURALPUPPY", 11, 449, 1, 402, 2, 147, 0f, 8, 4.5f, 6.8f, 3, 2, 1.69f, null, 450, 0,  0, -1, null, 0) },
            { 1050, new PinItem(1050, 403, ItemType.Pin, "ITM_BDG_Name_0051", "ITM_BDG_Info_0051", "ID051_NATURALPUPPY", 11, 450, 1, 403, 2, 505, 0f, 8, 9.6f, 14.4f, 5, 2, 5f, null, 1120, 0,  0, -1, null, 3) },
            { 1051, new PinItem(1051, 404, ItemType.Pin, "ITM_BDG_Name_0052", "ITM_BDG_Info_0052", "ID052_NATURALPUPPY", 11, 451, 1, 404, 2, 1065, 0f, 8, 12f, 18f, 3, 1, 36.63f, null, 2080, 5,  0, -1, null, 3) },
            { 1052, new PinItem(1052, 405, ItemType.Pin, "ITM_BDG_Name_0053", "ITM_BDG_Info_0053", "ID053_NATURALPUPPY", 11, 452, 1, 405, 2, 225, 0f, 8, 8f, 12f, 3, 2, 2.19f, null, 640, 0,  0, -1, null, 2) },
            { 1053, new PinItem(1053, 406, ItemType.Pin, "ITM_BDG_Name_0054", "ITM_BDG_Info_0054", "ID054_NATURALPUPPY", 11, 453, 1, 406, 2, 785, 0f, 8, 8f, 12f, 5, 1, 14.28f, null, 500, 0,  5, -1, new short[] { -1,-1,411,-1,-1,-1,-1 }, 2) },
            { 1054, new PinItem(1054, 407, ItemType.Pin, "ITM_BDG_Name_0055", "ITM_BDG_Info_0055", "ID055_NATURALPUPPY", 11, 454, 28, 407, 2, 365, 0f, 999, 6f, 9f, 3, 2, 3.71f, null, 800, 0,  0, -1, null, 11) },
            { 1055, new PinItem(1055, 408, ItemType.Pin, "ITM_BDG_Name_0056", "ITM_BDG_Info_0056", "ID056_NATURALPUPPY", 11, 455, 28, 408, 2, 995, 0f, 999, 7.5f, 11.3f, 3, 2, 36.63f, null, 0, 0,  0, -1, null, 11) },
            { 1056, new PinItem(1056, 409, ItemType.Pin, "ITM_BDG_Name_0057", "ITM_BDG_Info_0057", "ID057_NATURALPUPPY", 11, 456, 1, 409, 2, 266, 0f, 8, 8f, 12f, 10, 4, 2.85f, null, 680, 0,  0, -1, null, 23) },
            { 1057, new PinItem(1057, 410, ItemType.Pin, "ITM_BDG_Name_0058", "ITM_BDG_Info_0058", "ID058_NoBrand", 0, 457, 1, 410, 2, 726, 0f, 8, 8f, 12f, 3, 2, 14.28f, new ushort[] { 2011 }, 900, 5,  0, -1, null, 5) },
            { 1058, new PinItem(1058, 411, ItemType.Pin, "ITM_BDG_Name_0059", "ITM_BDG_Info_0059", "ID059_NATURALPUPPY", 11, 458, 1, 411, 2, 995, 0f, 8, 10f, 15f, 7, 4, 33.3f, null, 1960, 0,  0, -1, null, 2) },
            { 1059, new PinItem(1059, 412, ItemType.Pin, "ITM_BDG_Name_0060", "ITM_BDG_Info_0060", "ID060_NATURALPUPPY", 11, 459, 1, 412, 2, 329, 0f, 8, 8f, 12f, 3, 2, 3.71f, new ushort[] { 1014 }, 800, 0,  0, -1, null, 8) },
            { 1060, new PinItem(1060, 413, ItemType.Pin, "ITM_BDG_Name_0061", "ITM_BDG_Info_0061", "ID061_NATURALPUPPY", 11, 460, 1, 413, 2, 770, 0f, 8, 10f, 15f, 3, 2, 18.56f, new ushort[] { 1014 }, 0, 5,  0, -1, null, 8) },
            { 1061, new PinItem(1061, 414, ItemType.Pin, "ITM_BDG_Name_0062", "ITM_BDG_Info_0062", "ID062_NATURALPUPPY", 11, 461, 1, 414, 2, 896, 0f, 8, 12f, 18f, 3, 2, 33.3f, new ushort[] { 133 }, 1640, 0,  3, 415, null, 10) },
            { 1062, new PinItem(1062, 415, ItemType.Pin, "ITM_BDG_Name_0063", "ITM_BDG_Info_0063", "ID063_NATURALPUPPY", 11, 462, 1, 415, 2, 1103, 0f, 8, 14.4f, 21.6f, 3, 2, 48.75f, new ushort[] { 134 }, 2030, 0,  0, -1, null, 10) },
            { 1063, new PinItem(1063, 416, ItemType.Pin, "ITM_BDG_Name_0064", "ITM_BDG_Info_0064", "ID064_croakypanic", 14, 463, 1, 416, 2, 785, 0f, 6, 6f, 9f, 3, 2, 14.28f, null, 1470, 5,  3, 417, null, 11) },
            { 1064, new PinItem(1064, 417, ItemType.Pin, "ITM_BDG_Name_0065", "ITM_BDG_Info_0065", "ID065_croakypanic", 14, 464, 1, 417, 2, 1135, 0f, 6, 8.3f, 12.5f, 3, 2, 40.29f, null, 2010, 5,  0, -1, null, 11) },
            { 1065, new PinItem(1065, 418, ItemType.Pin, "ITM_BDG_Name_0066", "ITM_BDG_Info_0066", "ID066_MONOCROW", 10, 465, 1, 418, 2, 613, 0f, 8, 6f, 9f, 3, 1, 8.45f, null, 670, 0,  3, 419, null, 0) },
            { 1066, new PinItem(1066, 419, ItemType.Pin, "ITM_BDG_Name_0067", "ITM_BDG_Info_0067", "ID067_MONOCROW", 10, 466, 1, 419, 2, 679, 0f, 8, 6f, 9f, 3, 1, 10.98f, null, 1290, 0,  0, -1, null, 0) },
            { 1067, new PinItem(1067, 420, ItemType.Pin, "ITM_BDG_Name_0068", "ITM_BDG_Info_0068", "ID068_MONOCROW", 10, 467, 1, 420, 2, 864, 0f, 8, 8f, 12f, 5, 2, 14.28f, null, 700, 0,  0, -1, null, 1) },
            { 1068, new PinItem(1068, 421, ItemType.Pin, "ITM_BDG_Name_0069", "ITM_BDG_Info_0069", "ID069_MONOCROW", 10, 468, 1, 421, 2, 1370, 0f, 8, 12f, 18f, 3, 2, 53.62f, null, 2360, 5,  0, -1, null, 1) },
            { 1069, new PinItem(1069, 422, ItemType.Pin, "ITM_BDG_Name_0070", "ITM_BDG_Info_0070", "ID070_MONOCROW", 10, 469, 1, 422, 2, 1326, 0f, 8, 14.4f, 21.6f, 3, 2, 44.32f, new ushort[] { 1013 }, 0, 0,  0, -1, null, 9) },
            { 1070, new PinItem(1070, 423, ItemType.Pin, "ITM_BDG_Name_0071", "ITM_BDG_Info_0071", "ID071_MONOCROW", 10, 470, 1, 423, 2, 1458, 0f, 8, 14.4f, 21.6f, 3, 2, 58.99f, new ushort[] { 1013 }, 2750, 5,  0, -1, null, 9) },
            { 1071, new PinItem(1071, 424, ItemType.Pin, "ITM_BDG_Name_0072", "ITM_BDG_Info_0072", "ID072_NoBrand", 0, 471, 15, 424, 2, 1458, 0f, 8, 14.4f, 21.6f, 3, 2, 58.99f, new ushort[] { 1013 }, 2750, 5,  0, -1, null, 9) },
            { 1072, new PinItem(1072, 500, ItemType.Pin, "ITM_BDG_Name_0073", "ITM_BDG_Info_0073", "ID073_ConyCony", 4, 472, 35, 500, 2, 95, 0f, 0, 6f, 9f, 4, 1, 1.3f, null, 450, 0,  4, 501, null, 12) },
            { 1073, new PinItem(1073, 501, ItemType.Pin, "ITM_BDG_Name_0074", "ITM_BDG_Info_0074", "ID074_ConyCony", 4, 473, 36, 501, 2, 147, 0f, 0, 6f, 9f, 5, 1, 1.69f, null, 590, 0,  5, -1, new short[] { -1,-1,-1,-1,-1,507,-1 }, 12) },
            { 1074, new PinItem(1074, 502, ItemType.Pin, "ITM_BDG_Name_0075", "ITM_BDG_Info_0075", "ID075_ConyCony", 4, 474, 37, 502, 6, 945, 0f, 0, 12f, 18f, 3, 2, 33.3f, new ushort[] { 1005 }, 2310, 0,  0, -1, null, 12) },
            { 1075, new PinItem(1075, 503, ItemType.Pin, "ITM_BDG_Name_0076", "ITM_BDG_Info_0076", "ID076_ConyCony", 4, 475, 35, 503, 2, 365, 0f, 0, 8f, 12f, 3, 2, 3.71f, null, 1150, 0,  0, -1, null, 2) },
            { 1076, new PinItem(1076, 504, ItemType.Pin, "ITM_BDG_Name_0077", "ITM_BDG_Info_0077", "ID077_ConyCony", 4, 476, 36, 504, 2, 1225, 0f, 0, 12f, 18f, 8, 5, 48.75f, null, 0, 0,  0, -1, null, 2) },
            { 1077, new PinItem(1077, 505, ItemType.Pin, "ITM_BDG_Name_0078", "ITM_BDG_Info_0078", "ID078_ConyCony", 4, 477, 35, 505, 2, 505, 0f, 0, 8f, 12f, 3, 2, 5f, null, 1470, 0,  3, 506, null, 6) },
            { 1078, new PinItem(1078, 506, ItemType.Pin, "ITM_BDG_Name_0079", "ITM_BDG_Info_0079", "ID079_ConyCony", 4, 478, 36, 506, 2, 645, 0f, 0, 8f, 12f, 3, 2, 8.45f, null, 1800, 0,  0, -1, null, 6) },
            { 1079, new PinItem(1079, 507, ItemType.Pin, "ITM_BDG_Name_0080", "ITM_BDG_Info_0080", "ID080_ConyCony", 4, 479, 38, 507, 2, 1205, 0f, 0, 14.4f, 21.6f, 3, 2, 44.32f, null, 2910, 0,  0, -1, null, 13) },
            { 1292, new PinItem(1292, 425, ItemType.Pin, "ITM_BDG_Name_0081", "ITM_BDG_Info_0081", "ID081_NoBrand", 0, 692, 1, 425, 6, 1193, 0f, 8, 12f, 18f, 3, 2, 58.99f, new ushort[] { 1003 }, 10000, 5,  0, -1, null, 23) },
            { 1080, new PinItem(1080, 600, ItemType.Pin, "ITM_BDG_Name_0082", "ITM_BDG_Info_0082", "ID082_ShepherdHouse", 8, 480, 5, 600, 2, 171, 0f, 0, 6f, -1f, 3, 2, 1.69f, null, 180, 0,  0, -1, null, 12) },
            { 1083, new PinItem(1083, 603, ItemType.Pin, "ITM_BDG_Name_0083", "ITM_BDG_Info_0083", "ID083_ShepherdHouse", 8, 483, 28, 603, 2, 575, 0f, 0, 8f, -1f, 3, 2, 6.5f, null, 940, 0,  3, 604, null, 11) },
            { 1084, new PinItem(1084, 604, ItemType.Pin, "ITM_BDG_Name_0084", "ITM_BDG_Info_0084", "ID084_ShepherdHouse", 8, 484, 28, 604, 2, 715, 0f, 0, 9.6f, -1f, 3, 2, 10.98f, null, 1360, 0,  0, -1, null, 11) },
            { 1085, new PinItem(1085, 605, ItemType.Pin, "ITM_BDG_Name_0085", "ITM_BDG_Info_0085", "ID085_ShepherdHouse", 8, 485, 28, 605, 2, 925, 0f, 0, 12f, -1f, 3, 2, 24.13f, null, 1680, 0,  0, -1, null, 11) },
            { 1081, new PinItem(1081, 601, ItemType.Pin, "ITM_BDG_Name_0086", "ITM_BDG_Info_0086", "ID086_ShepherdHouse", 8, 481, 6, 601, 2, 613, 0f, 0, 8f, -1f, 3, 2, 8.45f, null, 1310, 0,  3, -1, new short[] { -1,-1,-1,602,-1,-1,-1 }, 4) },
            { 1082, new PinItem(1082, 602, ItemType.Pin, "ITM_BDG_Name_0087", "ITM_BDG_Info_0087", "ID087_ShepherdHouse", 8, 482, 6, 602, 2, 812, 0f, 0, 8f, -1f, 3, 2, 18.56f, null, 1660, 0,  0, -1, null, 4) },
            { 1086, new PinItem(1086, 606, ItemType.Pin, "ITM_BDG_Name_0088", "ITM_BDG_Info_0088", "ID088_ShepherdHouse", 8, 486, 8, 606, 2, 995, 0f, 0, 12f, -1f, 3, 2, 33.3f, null, 1500, 0,  0, -1, null, 3) },
            { 1087, new PinItem(1087, 607, ItemType.Pin, "ITM_BDG_Name_0089", "ITM_BDG_Info_0089", "ID089_NoBrand", 0, 487, 9, 607, 2, 1193, 0f, 0, 12f, -1f, 3, 2, 58.99f, null, 2710, 5,  0, -1, null, 23) },
            { 1088, new PinItem(1088, 608, ItemType.Pin, "ITM_BDG_Name_0090", "ITM_BDG_Info_0090", "ID090_garagara", 6, 488, 5, 608, 2, 479, 0f, 0, 8f, -1f, 3, 2, 4.82f, null, 750, 0,  0, -1, null, 12) },
            { 1089, new PinItem(1089, 609, ItemType.Pin, "ITM_BDG_Name_0091", "ITM_BDG_Info_0091", "ID091_garagara", 6, 489, 5, 609, 2, 1348, 0f, 0, 12f, -1f, 3, 2, 48.75f, null, 1820, 5,  3, -1, new short[] { -1,614,-1,-1,-1,-1,-1 }, 12) },
            { 1090, new PinItem(1090, 610, ItemType.Pin, "ITM_BDG_Name_0092", "ITM_BDG_Info_0092", "ID092_garagara", 6, 490, 6, 610, 2, 1018, 0f, 0, 12f, -1f, 3, 2, 24.13f, null, 800, 5,  0, -1, null, 12) },
            { 1091, new PinItem(1091, 611, ItemType.Pin, "ITM_BDG_Name_0093", "ITM_BDG_Info_0093", "ID093_garagara", 6, 491, 12, 611, 2, 214, 0f, 0, 8f, -1f, 3, 2, 2.19f, null, 250, 0,  0, -1, null, 0) },
            { 1092, new PinItem(1092, 612, ItemType.Pin, "ITM_BDG_Name_0094", "ITM_BDG_Info_0094", "ID094_garagara", 6, 492, 12, 612, 2, 613, 0f, 0, 10f, -1f, 3, 2, 8.45f, null, 0, 5,  0, -1, null, 0) },
            { 1093, new PinItem(1093, 613, ItemType.Pin, "ITM_BDG_Name_0095", "ITM_BDG_Info_0095", "ID095_garagara", 6, 493, 9, 613, 2, 896, 0f, 0, 10f, -1f, 7, 4, 33.3f, null, 1750, 0,  0, -1, null, 23) },
            { 1094, new PinItem(1094, 614, ItemType.Pin, "ITM_BDG_Name_0096", "ITM_BDG_Info_0096", "ID096_garagara", 6, 494, 9, 614, 2, 1139, 0f, 0, 12f, -1f, 5, 5, 53.62f, null, 2290, 5,  0, -1, null, 23) },
            { 1095, new PinItem(1095, 615, ItemType.Pin, "ITM_BDG_Name_0097", "ITM_BDG_Info_0097", "ID097_garagara", 6, 495, 15, 615, 2, 1458, 0f, 0, 14.4f, -1f, 3, 2, 58.99f, new ushort[] { 1013 }, 2640, 5,  0, -1, null, 9) },
            { 1096, new PinItem(1096, 616, ItemType.Pin, "ITM_BDG_Name_0098", "ITM_BDG_Info_0098", "ID098_croakypanic", 14, 496, 2, 616, 2, 467, 0f, 0, 9.6f, -1f, 3, 2, 5f, null, 650, 0,  0, -1, null, 5) },
            { 1097, new PinItem(1097, 617, ItemType.Pin, "ITM_BDG_Name_0099", "ITM_BDG_Info_0099", "ID099_croakypanic", 14, 497, 2, 617, 2, 920, 0f, 0, 12f, -1f, 3, 1, 33.3f, null, 2170, 0,  0, -1, null, 5) },
            { 1098, new PinItem(1098, 700, ItemType.Pin, "ITM_BDG_Name_0100", "ITM_BDG_Info_0100", "ID100_JupiterOfTheMonkey", 9, 498, 1, 700, 1, 546, 0f, 2, 12f, 18f, 5, 1, 6.5f, new ushort[] { 1015 }, 1120, 0,  5, 701, null, 0) },
            { 1099, new PinItem(1099, 701, ItemType.Pin, "ITM_BDG_Name_0101", "ITM_BDG_Info_0101", "ID101_JupiterOfTheMonkey", 9, 499, 1, 701, 1, 679, 0f, 1, 12f, 18f, 5, 1, 10.98f, new ushort[] { 1015 }, 1330, 0,  0, -1, null, 0) },
            { 1100, new PinItem(1100, 702, ItemType.Pin, "ITM_BDG_Name_0102", "ITM_BDG_Info_0102", "ID102_JupiterOfTheMonkey", 9, 500, 1, 702, 1, 896, 0f, 3, 10f, 15f, 7, 1, 33.3f, new ushort[] { 1014 }, 1730, 0,  0, -1, null, 8) },
            { 1101, new PinItem(1101, 703, ItemType.Pin, "ITM_BDG_Name_0103", "ITM_BDG_Info_0103", "ID103_JupiterOfTheMonkey", 9, 501, 1, 703, 1, 1193, 0f, 3, 13.2f, 19.8f, 6, 1, 58.99f, new ushort[] { 1014 }, 2680, 5,  0, -1, null, 8) },
            { 1102, new PinItem(1102, 704, ItemType.Pin, "ITM_BDG_Name_0104", "ITM_BDG_Info_0104", "ID104_JupiterOfTheMonkey", 9, 502, 13, 704, 1, 995, 0f, 2, 11f, 16.5f, 6, 1, 33.3f, new ushort[] { 1015 }, 1500, 0,  6, 705, null, 6) },
            { 1103, new PinItem(1103, 705, ItemType.Pin, "ITM_BDG_Name_0105", "ITM_BDG_Info_0105", "ID105_JupiterOfTheMonkey", 9, 503, 13, 705, 1, 1225, 0f, 2, 12f, 18f, 5, 1, 48.75f, new ushort[] { 2010 }, 2450, 0,  0, -1, null, 6) },
            { 1104, new PinItem(1104, 706, ItemType.Pin, "ITM_BDG_Name_0106", "ITM_BDG_Info_0106", "ID106_NoBrand", 0, 504, 1, 706, 1, 1193, 0f, 7, 12f, 18f, 3, 2, 58.99f, new ushort[] { 1010 }, 1890, 5,  0, -1, null, 10) },
            { 1105, new PinItem(1105, 800, ItemType.Pin, "ITM_BDG_Name_0107", "ITM_BDG_Info_0107", "ID107_ILCAVALLODELRE", 7, 505, 8, 800, 2, 225, 0f, 8, 9.6f, 14.4f, 3, 1, 2.19f, null, 820, 0,  0, -1, null, 3) },
            { 1106, new PinItem(1106, 801, ItemType.Pin, "ITM_BDG_Name_0195", "ITM_BDG_Info_0108", "ID195_NoBrand", 0, 506, 9, 801, 2, 1193, 0f, 8, 12f, 18f, 3, 2, 58.99f, null, 3750, 5,  0, -1, null, 23) },
            { 1107, new PinItem(1107, 802, ItemType.Pin, "ITM_BDG_Name_0109", "ITM_BDG_Info_0109", "ID109_ILCAVALLODELRE", 7, 507, 10, 802, 2, 338, 0f, 8, 9.6f, 14.4f, 4, 1, 3.71f, new ushort[] { 2011 }, 1290, 0,  0, -1, null, 5) },
            { 1108, new PinItem(1108, 803, ItemType.Pin, "ITM_BDG_Name_0110", "ITM_BDG_Info_0110", "ID110_ILCAVALLODELRE", 7, 508, 10, 803, 2, 1050, 0f, 8, 12f, 18f, 5, 2, 40.29f, new ushort[] { 2011 }, 3290, 0,  5, -1, new short[] { -1,-1,-1,-1,-1,-1,804 }, 5) },
            { 1109, new PinItem(1109, 804, ItemType.Pin, "ITM_BDG_Name_0111", "ITM_BDG_Info_0111", "ID111_ILCAVALLODELRE", 7, 509, 9, 804, 2, 1193, 0f, 8, 12f, 18f, 3, 2, 58.99f, null, 3750, 0,  0, -1, null, 23) },
            { 1110, new PinItem(1110, 805, ItemType.Pin, "ITM_BDG_Name_0112", "ITM_BDG_Info_0112", "ID112_ILCAVALLODELRE", 7, 510, 28, 805, 2, 435, 0f, 8, 6f, 9f, 5, 2, 4.82f, null, 1450, 0,  0, -1, null, 11) },
            { 1111, new PinItem(1111, 806, ItemType.Pin, "ITM_BDG_Name_0113", "ITM_BDG_Info_0113", "ID113_ILCAVALLODELRE", 7, 511, 28, 806, 2, 855, 0f, 8, 6.6f, 9.9f, 8, 4, 18.56f, null, 2540, 0,  0, -1, null, 11) },
            { 1112, new PinItem(1112, 2500, ItemType.Pin, "ITM_BDG_Name_0114", "ITM_BDG_Info_0114", "ID114_ILCAVALLODELRE", 7, 512, 8, 2500, 2, 785, 0f, 6, 9.6f, 14.4f, 3, 2, 14.28f, null, 4000, 0,  0, -1, null, 3) },
            { 1113, new PinItem(1113, 2501, ItemType.Pin, "ITM_BDG_Name_0115", "ITM_BDG_Info_0115", "ID115_ILCAVALLODELRE", 7, 513, 12, 2501, 2, 613, 0f, 6, 6f, 9f, 5, 1, 8.45f, null, 2030, 0,  0, -1, null, 0) },
            { 1114, new PinItem(1114, 2502, ItemType.Pin, "ITM_BDG_Name_0116", "ITM_BDG_Info_0116", "ID116_ILCAVALLODELRE", 7, 514, 8, 2502, 2, 1205, 0f, 6, 14.4f, 21.6f, 3, 2, 44.32f, null, 3050, 5,  0, -1, null, 3) },
            { 1115, new PinItem(1115, 2503, ItemType.Pin, "ITM_BDG_Name_0117", "ITM_BDG_Info_0117", "ID117_ILCAVALLODELRE", 7, 515, 8, 2503, 2, 1305, 0f, 6, 14.4f, 21.6f, 3, 2, 58.99f, null, 0, 5,  0, -1, null, 3) },
            { 1116, new PinItem(1116, 2504, ItemType.Pin, "ITM_BDG_Name_0118", "ITM_BDG_Info_0118", "ID118_ILCAVALLODELRE", 7, 516, 19, 2504, 2, 896, 0f, 6, 12f, 18f, 3, 2, 33.3f, new ushort[] { 133 }, 12000, 0,  0, -1, null, 10) },
            { 1117, new PinItem(1117, 2505, ItemType.Pin, "ITM_BDG_Name_0119", "ITM_BDG_Info_0119", "ID119_ILCAVALLODELRE", 7, 517, 19, 2505, 2, 1193, 0f, 6, 14.4f, 21.6f, 5, 2, 58.99f, new ushort[] { 134 }, 33300, 5,  0, -1, null, 10) },
            { 1118, new PinItem(1118, 2506, ItemType.Pin, "ITM_BDG_Name_0120", "ITM_BDG_Info_0120", "ID120_ILCAVALLODELRE", 7, 518, 15, 2506, 2, 1370, 0f, 6, 14.4f, 21.6f, 5, 4, 53.62f, new ushort[] { 1013 }, 3150, 5,  0, -1, null, 9) },
            { 1119, new PinItem(1119, 2507, ItemType.Pin, "ITM_BDG_Name_0121", "ITM_BDG_Info_0121", "ID121_NoBrand", 0, 519, 33, 2507, 2, 1259, 0f, 6, 14.4f, 21.6f, 3, 2, 58.99f, null, 4380, 5,  0, -1, null, 0) },
            { 1120, new PinItem(1120, 900, ItemType.Pin, "ITM_BDG_Name_0122", "ITM_BDG_Info_0122", "ID122_Jolibecot", 2, 520, 6, 900, 4, 95, 1f, 0, 4.5f, 6.8f, 4, 1, 1.3f, null, 360, 0,  4, 901, null, 0) },
            { 1121, new PinItem(1121, 901, ItemType.Pin, "ITM_BDG_Name_0123", "ITM_BDG_Info_0123", "ID123_Jolibecot", 2, 521, 6, 901, 4, 147, 1f, 0, 4.5f, 6.8f, 4, 1, 1.69f, null, 470, 0,  0, -1, null, 0) },
            { 1122, new PinItem(1122, 902, ItemType.Pin, "ITM_BDG_Name_0124", "ITM_BDG_Info_0124", "ID124_Jolibecot", 2, 522, 6, 902, 4, 214, 1f, 0, 6f, 9f, 3, 1, 2.19f, null, 660, 0,  0, -1, null, 4) },
            { 1123, new PinItem(1123, 903, ItemType.Pin, "ITM_BDG_Name_0125", "ITM_BDG_Info_0125", "ID125_Jolibecot", 2, 523, 6, 903, 4, 879, 1f, 0, 10f, 15f, 5, 4, 24.13f, null, 1940, 5,  0, -1, null, 4) },
            { 1124, new PinItem(1124, 904, ItemType.Pin, "ITM_BDG_Name_0126", "ITM_BDG_Info_0126", "ID126_Jolibecot", 2, 524, 6, 904, 4, 833, 0.5f, 0, 10f, 15f, 8, 5, 24.13f, new ushort[] { 1014 }, 1730, 5,  8, 905, null, 8) },
            { 1125, new PinItem(1125, 905, ItemType.Pin, "ITM_BDG_Name_0127", "ITM_BDG_Info_0127", "ID127_Jolibecot", 2, 525, 6, 905, 4, 1103, 0.5f, 0, 13.2f, 19.8f, 3, 2, 48.75f, new ushort[] { 1014 }, 2310, 5,  3, -1, new short[] { -1,-1,-1,-1,907,-1,-1 }, 8) },
            { 1126, new PinItem(1126, 906, ItemType.Pin, "ITM_BDG_Name_0128", "ITM_BDG_Info_0128", "ID128_Jolibecot", 2, 526, 2, 906, 4, 556, 1f, 0, 8f, 12f, 5, 1, 5f, null, 940, 0,  0, -1, null, 1) },
            { 1127, new PinItem(1127, 907, ItemType.Pin, "ITM_BDG_Name_0129", "ITM_BDG_Info_0129", "ID129_Jolibecot", 2, 527, 2, 907, 4, 1392, 1f, 0, 10.8f, 16.2f, 8, 4, 58.99f, null, 2220, 5,  0, -1, null, 1) },
            { 1128, new PinItem(1128, 908, ItemType.Pin, "ITM_BDG_Name_0130", "ITM_BDG_Info_0130", "ID130_NoBrand", 0, 528, 10, 908, 4, 1458, 1f, 0, 12f, 18f, 3, 2, 58.99f, new ushort[] { 1011 }, 2470, 5,  0, -1, null, 1) },
            { 1129, new PinItem(1129, 1000, ItemType.Pin, "ITM_BDG_Name_0131", "ITM_BDG_Info_0131", "ID131_Jolibecot", 2, 529, 10, 1000, 3, 100, 1f, 0, 6f, 9f, 5, 1, 1.3f, new ushort[] { 1012 }, 330, 0,  5, 1001, null, 6) },
            { 1130, new PinItem(1130, 1001, ItemType.Pin, "ITM_BDG_Name_0132", "ITM_BDG_Info_0132", "ID132_Jolibecot", 2, 530, 10, 1001, 3, 225, 1f, 0, 8f, 12f, 6, 2, 2.19f, new ushort[] { 1012 }, 540, 0,  0, -1, null, 6) },
            { 1131, new PinItem(1131, 1002, ItemType.Pin, "ITM_BDG_Name_0133", "ITM_BDG_Info_0133", "ID133_Jolibecot", 2, 531, 10, 1002, 3, 1225, 1f, 0, 21f, 31.5f, 3, 2, 48.75f, new ushort[] { 1012 }, 2430, 0,  0, -1, null, 6) },
            { 1132, new PinItem(1132, 1003, ItemType.Pin, "ITM_BDG_Name_0134", "ITM_BDG_Info_0134", "ID134_Jolibecot", 2, 532, 10, 1003, 3, 365, 1f, 0, 9.6f, 14.4f, 5, 1, 3.71f, new ushort[] { 1012 }, 800, 0,  0, -1, null, 3) },
            { 1133, new PinItem(1133, 1004, ItemType.Pin, "ITM_BDG_Name_0135", "ITM_BDG_Info_0135", "ID135_Jolibecot", 2, 533, 10, 1004, 3, 1065, 1f, 0, 12f, 18f, 3, 1, 36.63f, new ushort[] { 1012 }, 1890, 0,  3, 1005, null, 3) },
            { 1134, new PinItem(1134, 1005, ItemType.Pin, "ITM_BDG_Name_0136", "ITM_BDG_Info_0136", "ID136_Jolibecot", 2, 534, 10, 1005, 3, 1205, 1f, 0, 21f, 31.5f, 5, 1, 44.32f, new ushort[] { 1012 }, 2680, 0,  0, -1, null, 3) },
            { 1135, new PinItem(1135, 1006, ItemType.Pin, "ITM_BDG_Name_0137", "ITM_BDG_Info_0137", "ID137_NoBrand", 0, 535, 10, 1006, 3, 1325, 3f, 0, 12f, 18f, 3, 2, 58.99f, new ushort[] { 1012 }, 2520, 5,  0, -1, null, 6) },
            { 1136, new PinItem(1136, 1007, ItemType.Pin, "ITM_BDG_Name_0138", "ITM_BDG_Info_0138", "ID138_Jolibecot", 2, 536, 10, 1007, 3, 155, 2f, 0, 7.2f, 10.8f, 5, 1, 1.69f, new ushort[] { 1012 }, 200, 0,  0, -1, null, 11) },
            { 1137, new PinItem(1137, 1008, ItemType.Pin, "ITM_BDG_Name_0139", "ITM_BDG_Info_0139", "ID139_Jolibecot", 2, 537, 10, 1008, 3, 715, 2f, 0, 11.5f, 17.3f, 5, 2, 10.98f, new ushort[] { 1012 }, 1120, 0,  0, -1, null, 11) },
            { 1138, new PinItem(1138, 1009, ItemType.Pin, "ITM_BDG_Name_0140", "ITM_BDG_Info_0140", "ID140_Jolibecot", 2, 538, 10, 1009, 3, 1225, 2f, 0, 17.3f, 26f, 3, 2, 48.75f, new ushort[] { 1012 }, 5500, 5,  0, -1, null, 11) },
            { 1139, new PinItem(1139, 1100, ItemType.Pin, "ITM_BDG_Name_0141", "ITM_BDG_Info_0141", "ID141_ConyCony", 4, 539, 2, 1100, 4, 100, 1f, 0, 6f, 9f, 3, 1, 1.3f, null, 360, 0,  3, 1101, null, 2) },
            { 1140, new PinItem(1140, 1101, ItemType.Pin, "ITM_BDG_Name_0142", "ITM_BDG_Info_0142", "ID142_ConyCony", 4, 540, 2, 1101, 4, 155, 1f, 0, 6f, 9f, 3, 2, 1.69f, null, 470, 0,  0, -1, null, 2) },
            { 1141, new PinItem(1141, 1102, ItemType.Pin, "ITM_BDG_Name_0143", "ITM_BDG_Info_0143", "ID143_ConyCony", 4, 541, 2, 1102, 4, 1135, 1f, 0, 14.4f, 21.6f, 5, 2, 40.29f, null, 1980, 5,  5, -1, new short[] { -1,-1,1105,-1,-1,-1,-1 }, 2) },
            { 1142, new PinItem(1142, 1103, ItemType.Pin, "ITM_BDG_Name_0144", "ITM_BDG_Info_0144", "ID144_ConyCony", 4, 542, 2, 1103, 4, 225, 1f, 0, 8f, 12f, 3, 4, 2.19f, null, 590, 0,  0, -1, null, 6) },
            { 1143, new PinItem(1143, 1104, ItemType.Pin, "ITM_BDG_Name_0145", "ITM_BDG_Info_0145", "ID145_ConyCony", 4, 543, 2, 1104, 4, 715, 1f, 0, 8f, 12f, 5, 4, 10.98f, null, 1330, 0,  0, -1, null, 6) },
            { 1144, new PinItem(1144, 1105, ItemType.Pin, "ITM_BDG_Name_0146", "ITM_BDG_Info_0146", "ID146_ConyCony", 4, 544, 2, 1105, 4, 1392, 1f, 0, 14.4f, 21.6f, 5, 4, 58.99f, null, 2380, 5,  0, -1, null, 1) },
            { 1145, new PinItem(1145, 1106, ItemType.Pin, "ITM_BDG_Name_0147", "ITM_BDG_Info_0147", "ID147_ConyCony", 4, 545, 2, 1106, 4, 455, 1f, 0, 9.6f, 14.4f, 3, 4, 5f, new ushort[] { 134 }, 1100, 0,  0, -1, null, 10) },
            { 1146, new PinItem(1146, 1107, ItemType.Pin, "ITM_BDG_Name_0148", "ITM_BDG_Info_0148", "ID148_ConyCony", 4, 546, 2, 1107, 4, 959, 1f, 0, 12f, 18f, 5, 4, 36.63f, new ushort[] { 134 }, 2050, 5,  0, -1, null, 10) },
            { 1147, new PinItem(1147, 1108, ItemType.Pin, "ITM_BDG_Name_0149", "ITM_BDG_Info_0149", "ID149_NoBrand", 0, 547, 2, 1108, 4, 1325, 1f, 0, 12f, 18f, 5, 4, 58.99f, null, 2520, 5,  0, -1, null, 2) },
            { 1148, new PinItem(1148, 1200, ItemType.Pin, "ITM_BDG_Name_0150", "ITM_BDG_Info_0150", "ID150_TopoTopo", 1, 548, 6, 1110, 4, 480, 1f, 0, 9.6f, 14.4f, 3, 2, 5f, null, 1120, 0,  0, -1, null, 12) },
            { 1149, new PinItem(1149, 1201, ItemType.Pin, "ITM_BDG_Name_0151", "ITM_BDG_Info_0151", "ID151_TopoTopo", 1, 549, 6, 1201, 4, 1012, 1f, 0, 12f, 18f, 5, 4, 36.63f, null, 2080, 0,  5, -1, new short[] { -1,-1,1202,-1,-1,-1,-1 }, 12) },
            { 1150, new PinItem(1150, 1202, ItemType.Pin, "ITM_BDG_Name_0152", "ITM_BDG_Info_0152", "ID152_TopoTopo", 1, 550, 15, 1202, 4, 1103, 1f, 0, 12f, 18f, 3, 1, 48.75f, new ushort[] { 1014 }, 2960, 0,  0, -1, null, 8) },
            { 1151, new PinItem(1151, 1203, ItemType.Pin, "ITM_BDG_Name_0153", "ITM_BDG_Info_0153", "ID153_TopoTopo", 1, 551, 9, 1203, 4, 392, 1f, 0, 8f, 12f, 5, 5, 4.82f, null, 1030, 0,  5, 1204, null, 23) },
            { 1152, new PinItem(1152, 1204, ItemType.Pin, "ITM_BDG_Name_0154", "ITM_BDG_Info_0154", "ID154_TopoTopo", 1, 552, 9, 1204, 4, 644, 1f, 0, 8f, 12f, 5, 2, 10.98f, null, 1540, 0,  0, -1, null, 23) },
            { 1153, new PinItem(1153, 1205, ItemType.Pin, "ITM_BDG_Name_0155", "ITM_BDG_Info_0155", "ID155_TopoTopo", 1, 553, 6, 1205, 4, 581, 1f, 0, 9.6f, 14.4f, 5, 2, 8.45f, new ushort[] { 133 }, 1640, 0,  5, 1206, null, 10) },
            { 1154, new PinItem(1154, 1206, ItemType.Pin, "ITM_BDG_Name_0156", "ITM_BDG_Info_0156", "ID156_TopoTopo", 1, 554, 6, 1206, 4, 770, 1f, 0, 12f, 18f, 5, 4, 18.56f, new ushort[] { 134 }, 600, 0,  0, -1, null, 10) },
            { 1155, new PinItem(1155, 1207, ItemType.Pin, "ITM_BDG_Name_0157", "ITM_BDG_Info_0157", "ID157_TopoTopo", 1, 555, 6, 1207, 4, 995, 1f, 0, 9f, 13.5f, 15, 4, 33.3f, null, 2500, 0,  15, -1, new short[] { 1208,-1,-1,-1,-1,-1,-1 }, 7) },
            { 1156, new PinItem(1156, 1208, ItemType.Pin, "ITM_BDG_Name_0158", "ITM_BDG_Info_0158", "ID158_TopoTopo", 1, 556, 6, 1208, 4, 1205, 1f, 0, 9.9f, 14.9f, 15, 5, 44.32f, null, 2960, 0,  0, -1, null, 7) },
            { 1202, new PinItem(1202, 1704, ItemType.Pin, "ITM_BDG_Name_0159", "ITM_BDG_Info_0159", "ID159_NoBrand", 0, 602, 31, 1704, 6, 1259, 0f, 0, 14.4f, 21.6f, 3, 2, 58.99f, null, 2890, 5,  0, -1, null, 0) },
            { 1157, new PinItem(1157, 1300, ItemType.Pin, "ITM_BDG_Name_0160", "ITM_BDG_Info_0160", "ID160_RyuGu", 5, 557, 12, 1300, 3, 214, 0.3f, 0, 21.6f, 32.4f, 3, 2, 2.19f, null, 540, 0,  3, 1301, null, 0) },
            { 1158, new PinItem(1158, 1301, ItemType.Pin, "ITM_BDG_Name_0161", "ITM_BDG_Info_0161", "ID161_RyuGu", 5, 558, 12, 1301, 3, 347, 0.3f, 0, 21.6f, 32.4f, 3, 2, 3.71f, null, 730, 0,  0, -1, null, 0) },
            { 1159, new PinItem(1159, 1302, ItemType.Pin, "ITM_BDG_Name_0162", "ITM_BDG_Info_0162", "ID162_RyuGu", 5, 559, 12, 1302, 3, 479, 0.3f, 0, 19.8f, 29.7f, 3, 2, 4.82f, null, 980, 0,  0, -1, null, 1) },
            { 1160, new PinItem(1160, 1303, ItemType.Pin, "ITM_BDG_Name_0163", "ITM_BDG_Info_0163", "ID163_RyuGu", 5, 560, 12, 1303, 3, 1392, 0.3f, 0, 29.7f, 44.6f, 3, 2, 58.99f, null, 0, 0,  0, -1, null, 1) },
            { 1161, new PinItem(1161, 1304, ItemType.Pin, "ITM_BDG_Name_0164", "ITM_BDG_Info_0164", "ID164_RyuGu", 5, 561, 12, 1304, 3, 1065, 0.3f, 0, 27f, 40.5f, 5, 4, 36.63f, null, 1770, 0,  5, 1305, null, 2) },
            { 1162, new PinItem(1162, 1305, ItemType.Pin, "ITM_BDG_Name_0165", "ITM_BDG_Info_0165", "ID165_RyuGu", 5, 562, 12, 1305, 3, 1135, 0.3f, 0, 27f, 40.5f, 3, 4, 40.29f, null, 1890, 0,  0, -1, null, 2) },
            { 1163, new PinItem(1163, 1306, ItemType.Pin, "ITM_BDG_Name_0166", "ITM_BDG_Info_0166", "ID166_RyuGu", 5, 563, 12, 1306, 3, 505, 0.3f, 0, 27f, 40.5f, 3, 2, 5f, null, 1310, 0,  0, -1, null, 3) },
            { 1164, new PinItem(1164, 1307, ItemType.Pin, "ITM_BDG_Name_0167", "ITM_BDG_Info_0167", "ID167_RyuGu", 5, 564, 12, 1307, 3, 1245, 0.3f, 0, 40.5f, 60.8f, 5, 4, 53.62f, null, 3010, 5,  0, -1, null, 3) },
            { 1165, new PinItem(1165, 1308, ItemType.Pin, "ITM_BDG_Name_0168", "ITM_BDG_Info_0168", "ID168_croakypanic", 14, 565, 12, 1308, 3, 707, 0.3f, 0, 27.5f, 41.3f, 5, 2, 14.28f, null, 700, 5,  5, -1, new short[] { -1,1312,-1,-1,-1,-1,-1 }, 23) },
            { 1166, new PinItem(1166, 1309, ItemType.Pin, "ITM_BDG_Name_0169", "ITM_BDG_Info_0169", "ID169_RyuGu", 5, 566, 12, 1309, 3, 1305, 0.3f, 0, 32.4f, 48.6f, 3, 2, 58.99f, null, 2500, 5,  0, -1, null, 7) },
            { 1167, new PinItem(1167, 1310, ItemType.Pin, "ITM_BDG_Name_0170", "ITM_BDG_Info_0170", "ID170_RyuGu", 5, 567, 12, 1310, 3, 879, 0.3f, 8, 38.3f, 57.5f, 7, 1, 24.13f, null, 1520, 5,  7, 1311, null, 0) },
            { 1168, new PinItem(1168, 1311, ItemType.Pin, "ITM_BDG_Name_0171", "ITM_BDG_Info_0171", "ID171_RyuGu", 5, 568, 12, 1311, 3, 1078, 0.3f, 8, 45f, 67.5f, 5, 2, 40.29f, null, 1820, 5,  0, -1, null, 0) },
            { 1169, new PinItem(1169, 1312, ItemType.Pin, "ITM_BDG_Name_0172", "ITM_BDG_Info_0172", "ID172_croakypanic", 14, 569, 12, 1312, 3, 896, 0.3f, 8, 34.3f, 51.5f, 5, 4, 33.3f, null, 2030, 5,  0, -1, null, 23) },
            { 1170, new PinItem(1170, 1313, ItemType.Pin, "ITM_BDG_Name_0173", "ITM_BDG_Info_0173", "ID173_RyuGu", 5, 570, 12, 1313, 3, 1103, 0.3f, 8, 32.4f, 48.6f, 3, 2, 48.75f, new ushort[] { 133 }, 0, 5,  0, -1, null, 10) },
            { 1171, new PinItem(1171, 1314, ItemType.Pin, "ITM_BDG_Name_0174", "ITM_BDG_Info_0174", "ID174_NoBrand", 0, 571, 12, 1314, 3, 1065, 0.3f, 8, 33.7f, 50.6f, 3, 2, 36.63f, null, 2450, 5,  0, -1, null, 3) },
            { 1172, new PinItem(1172, 1400, ItemType.Pin, "ITM_BDG_Name_0175", "ITM_BDG_Info_0175", "ID175_ConyCony", 4, 572, 18, 1400, 3, 280, 0.8f, 0, 6f, 9f, 3, 2, 2.85f, new ushort[] { 1012 }, 770, 0,  3, 1401, null, 0) },
            { 1173, new PinItem(1173, 1401, ItemType.Pin, "ITM_BDG_Name_0176", "ITM_BDG_Info_0176", "ID176_ConyCony", 4, 573, 19, 1401, 3, 347, 0.8f, 0, 6f, 9f, 3, 2, 3.71f, new ushort[] { 1012 }, 910, 0,  0, -1, null, 0) },
            { 1174, new PinItem(1174, 1402, ItemType.Pin, "ITM_BDG_Name_0177", "ITM_BDG_Info_0177", "ID177_croakypanic", 14, 574, 28, 1402, 3, 645, 1.5f, 0, 6f, 9f, 5, 2, 8.45f, new ushort[] { 1012 }, 1770, 0,  0, -1, null, 11) },
            { 1175, new PinItem(1175, 1403, ItemType.Pin, "ITM_BDG_Name_0178", "ITM_BDG_Info_0178", "ID178_croakypanic", 14, 575, 28, 1403, 3, 715, 1.5f, 0, 6f, 9f, 6, 4, 10.98f, new ushort[] { 1012 }, 500, 0,  0, -1, null, 11) },
            { 1176, new PinItem(1176, 1404, ItemType.Pin, "ITM_BDG_Name_0179", "ITM_BDG_Info_0179", "ID179_ConyCony", 4, 576, 17, 1404, 3, 785, 0.8f, 0, 9.6f, 14.4f, 3, 2, 14.28f, new ushort[] { 1012 }, 1840, 0,  3, 1405, null, 13) },
            { 1177, new PinItem(1177, 1405, ItemType.Pin, "ITM_BDG_Name_0180", "ITM_BDG_Info_0180", "ID180_ConyCony", 4, 577, 17, 1405, 3, 1205, 0.8f, 0, 12f, 18f, 3, 2, 44.32f, new ushort[] { 1012 }, 2680, 0,  0, -1, null, 13) },
            { 1178, new PinItem(1178, 1406, ItemType.Pin, "ITM_BDG_Name_0181", "ITM_BDG_Info_0181", "ID181_ConyCony", 4, 578, 11, 1406, 3, 1265, 0.8f, 0, 13.2f, 19.8f, 3, 2, 58.99f, new ushort[] { 1012 }, 3100, 5,  0, -1, null, 2) },
            { 1179, new PinItem(1179, 1407, ItemType.Pin, "ITM_BDG_Name_0182", "ITM_BDG_Info_0182", "ID182_NoBrand", 0, 579, 6, 1407, 3, 746, 0.8f, 0, 8.8f, 13.2f, 3, 2, 14.28f, new ushort[] { 1012 }, 850, 5,  0, -1, null, 4) },
            { 1180, new PinItem(1180, 1500, ItemType.Pin, "ITM_BDG_Name_0183", "ITM_BDG_Info_0183", "ID183_TopoTopo", 1, 580, 21, 1500, 4, 679, 2f, 0, 14f, 21f, 3, 2, 10.98f, null, 2030, 0,  0, -1, null, 12) },
            { 1181, new PinItem(1181, 1501, ItemType.Pin, "ITM_BDG_Name_0184", "ITM_BDG_Info_0184", "ID184_TopoTopo", 1, 581, 22, 1501, 4, 1164, 2f, 0, 21f, 31.5f, 3, 2, 48.75f, null, 3380, 5,  3, -1, new short[] { -1,-1,-1,-1,-1,1502,-1 }, 12) },
            { 1182, new PinItem(1182, 1502, ItemType.Pin, "ITM_BDG_Name_0185", "ITM_BDG_Info_0185", "ID185_TopoTopo", 1, 582, 21, 1502, 4, 1193, 1.5f, 0, 12f, 18f, 3, 2, 58.99f, new ushort[] { 1014 }, 3710, 5,  0, -1, null, 8) },
            { 1183, new PinItem(1183, 1503, ItemType.Pin, "ITM_BDG_Name_0186", "ITM_BDG_Info_0186", "ID186_croakypanic", 14, 583, 24, 1503, 4, 1050, 3f, 0, 10f, 15f, 5, 4, 40.29f, new ushort[] { 2011 }, 3150, 0,  0, -1, null, 5) },
            { 1184, new PinItem(1184, 1504, ItemType.Pin, "ITM_BDG_Name_0187", "ITM_BDG_Info_0187", "ID187_croakypanic", 14, 584, 24, 1504, 4, 1226, 3f, 0, 21f, 31.5f, 3, 2, 58.99f, new ushort[] { 2011 }, 4610, 5,  0, -1, null, 5) },
            { 1185, new PinItem(1185, 1505, ItemType.Pin, "ITM_BDG_Name_0188", "ITM_BDG_Info_0188", "ID188_TopoTopo", 1, 585, 15, 1505, 4, 1414, 2f, 0, 14.4f, 21.6f, 3, 4, 58.99f, new ushort[] { 1013 }, 3870, 5,  3, 1506, null, 9) },
            { 1186, new PinItem(1186, 1506, ItemType.Pin, "ITM_BDG_Name_0189", "ITM_BDG_Info_0189", "ID189_TopoTopo", 1, 586, 15, 1506, 4, 1458, 2f, 0, 14.4f, 21.6f, 3, 2, 58.99f, new ushort[] { 1013 }, 4190, 5,  0, -1, null, 9) },
            { 1192, new PinItem(1192, 2600, ItemType.Pin, "ITM_BDG_Name_0190", "ITM_BDG_Info_0190", "ID190_ILCAVALLODELRE", 7, 592, 27, 2600, 3, 546, 1f, 0, 7.2f, 10.8f, 4, 1, 6.5f, null, 1940, 0,  0, -1, null, 0) },
            { 1193, new PinItem(1193, 2601, ItemType.Pin, "ITM_BDG_Name_0191", "ITM_BDG_Info_0191", "ID191_ILCAVALLODELRE", 7, 593, 27, 2601, 3, 925, 1f, 0, 11f, 16.5f, 10, 4, 24.13f, null, 2730, 5,  0, -1, null, 13) },
            { 1194, new PinItem(1194, 2602, ItemType.Pin, "ITM_BDG_Name_0192", "ITM_BDG_Info_0192", "ID192_ILCAVALLODELRE", 7, 594, 18, 2602, 5, 1325, 0.3f, 0, 9.9f, 14.9f, 3, 2, 58.99f, new ushort[] { 1003 }, 4170, 5,  0, -1, null, 7) },
            { 1195, new PinItem(1195, 2603, ItemType.Pin, "ITM_BDG_Name_0193", "ITM_BDG_Info_0193", "ID193_ILCAVALLODELRE", 7, 595, 27, 2603, 3, 1139, 1f, 0, 15.8f, 23.7f, 5, 5, 58.99f, new ushort[] { 133 }, 4080, 5,  0, -1, null, 10) },
            { 1196, new PinItem(1196, 2604, ItemType.Pin, "ITM_BDG_Name_0194", "ITM_BDG_Info_0194", "ID194_ILCAVALLODELRE", 7, 596, 27, 2604, 4, 1458, 1f, 0, 14.4f, 21.6f, 3, 2, 58.99f, new ushort[] { 1013 }, 4640, 5,  0, -1, null, 9) },
            { 1197, new PinItem(1197, 2605, ItemType.Pin, "ITM_BDG_Name_0108", "ITM_BDG_Info_0195", "ID108_ILCAVALLODELRE", 7, 597, 8, 2605, 3, 1205, 1f, 0, 15.8f, 23.7f, 3, 2, 44.32f, null, 4010, 5,  0, -1, null, 3) },
            { 1261, new PinItem(1261, 2300, ItemType.Pin, "ITM_BDG_Name_0196", "ITM_BDG_Info_0196", "ID196_HogFang", 12, 661, 31, 2300, 5, 0, 3f, 0, 14f, -1f, 3, 2, 2.85f, null, 450, 0,  0, -1, null, 10) },
            { 1269, new PinItem(1269, 2308, ItemType.Pin, "ITM_BDG_Name_0197", "ITM_BDG_Info_0197", "ID197_HogFang", 12, 669, 31, 2308, 5, 0, 3f, 0, 14f, -1f, 3, 2, 10.98f, null, 0, 5,  0, -1, null, 10) },
            { 1271, new PinItem(1271, 2310, ItemType.Pin, "ITM_BDG_Name_0203", "ITM_BDG_Info_0198", "ID203_HogFang", 12, 671, 31, 2310, 5, 0, 3f, 0, 21f, -1f, 10, 5, 58.99f, null, 0, 5,  0, -1, null, 10) },
            { 1272, new PinItem(1272, 2311, ItemType.Pin, "ITM_BDG_Name_0199", "ITM_BDG_Info_0199", "ID199_HogFang", 12, 672, 30, 2311, 3, 0, 0f, 0, 22.4f, 33.6f, 3, 2, 6.5f, null, 600, 0,  0, -1, null, 0) },
            { 1273, new PinItem(1273, 2312, ItemType.Pin, "ITM_BDG_Name_0200", "ITM_BDG_Info_0200", "ID200_HogFang", 12, 673, 32, 2312, 3, 0, 0f, 0, 25f, 37.5f, 5, 2, 6.5f, null, 1310, 5,  5, 2313, null, 0) },
            { 1274, new PinItem(1274, 2313, ItemType.Pin, "ITM_BDG_Name_0201", "ITM_BDG_Info_0201", "ID201_HogFang", 12, 674, 32, 2313, 3, 0, 0f, 0, 30f, 45f, 10, 4, 14.28f, null, 1710, 5,  0, -1, null, 0) },
            { 1275, new PinItem(1275, 2314, ItemType.Pin, "ITM_BDG_Name_0202", "ITM_BDG_Info_0202", "ID202_HogFang", 12, 675, 32, 2314, 3, 1186, 0f, 0, 15f, 22.5f, 5, 2, 53.62f, null, 2730, 5,  5, 2315, null, 4) },
            { 1276, new PinItem(1276, 2315, ItemType.Pin, "ITM_BDG_Name_0198", "ITM_BDG_Info_0203", "ID198_HogFang", 12, 676, 32, 2315, 3, 1202, 0f, 0, 20f, 30f, 5, 2, 58.99f, null, 2870, 5,  0, -1, null, 4) },
            { 1277, new PinItem(1277, 2316, ItemType.Pin, "ITM_BDG_Name_0205", "ITM_BDG_Info_0204", "ID205_HogFang", 12, 677, 32, 2316, 3, 575, 0f, 0, 15f, 22.5f, 3, 2, 6.5f, null, 1190, 0,  0, -1, null, 6) },
            { 1279, new PinItem(1279, 2318, ItemType.Pin, "ITM_BDG_Name_0204", "ITM_BDG_Info_0205", "ID204_HogFang", 12, 679, 32, 2318, 3, 0, 0f, 0, 20f, 30f, 3, 2, 58.99f, null, 0, 5,  0, -1, null, 10) },
            { 1278, new PinItem(1278, 2317, ItemType.Pin, "ITM_BDG_Name_0206", "ITM_BDG_Info_0206", "ID206_NoBrand", 0, 678, 32, 2317, 3, 1225, 0f, 0, 20f, 30f, 3, 2, 48.75f, null, 3150, 5,  0, -1, null, 6) },
            { 1198, new PinItem(1198, 1700, ItemType.Pin, "ITM_BDG_Name_0207", "ITM_BDG_Info_0207", "ID207_RyuGu", 5, 598, 26, 1700, 6, 613, 0f, 0, 8f, 12f, 3, 1, 8.45f, null, 1400, 0,  0, -1, null, 0) },
            { 1199, new PinItem(1199, 1701, ItemType.Pin, "ITM_BDG_Name_0208", "ITM_BDG_Info_0208", "ID208_RyuGu", 5, 599, 26, 1701, 6, 1078, 0f, 0, 10f, 15f, 3, 2, 40.29f, null, 2260, 5,  3, -1, new short[] { -1,1702,-1,-1,-1,-1,-1 }, 0) },
            { 1200, new PinItem(1200, 1702, ItemType.Pin, "ITM_BDG_Name_0209", "ITM_BDG_Info_0209", "ID209_RyuGu", 5, 600, 15, 1702, 6, 1370, 0f, 0, 14.4f, 21.6f, 3, 2, 53.62f, new ushort[] { 1013 }, 3150, 5,  0, -1, null, 9) },
            { 1201, new PinItem(1201, 1703, ItemType.Pin, "ITM_BDG_Name_0210", "ITM_BDG_Info_0210", "ID210_RyuGu", 5, 601, 23, 1703, 6, 896, 0f, 0, 10f, 15f, 3, 1, 33.3f, new ushort[] { 1014 }, 4500, 5,  0, -1, null, 8) },
            { 1203, new PinItem(1203, 1705, ItemType.Pin, "ITM_BDG_Name_0211", "ITM_BDG_Info_0211", "ID311_NoBrand", 0, 603, 22, 1705, 6, 726, 0f, 0, 9.6f, 14.4f, 5, 1, 14.28f, new ushort[] { 2011 }, 0, 5,  0, -1, null, 5) },
            { 1208, new PinItem(1208, 1710, ItemType.Pin, "ITM_BDG_Name_0212", "ITM_BDG_Info_0212", "ID212_RyuGu", 5, 608, 24, 1710, 5, 1012, 0f, 0, 10f, 15f, 5, 2, 36.63f, null, 1960, 0,  0, -1, null, 4) },
            { 1209, new PinItem(1209, 1711, ItemType.Pin, "ITM_BDG_Name_0213", "ITM_BDG_Info_0213", "ID213_RyuGu", 5, 609, 24, 1711, 5, 1259, 0f, 0, 18f, 27f, 3, 2, 58.99f, null, 2870, 5,  0, -1, null, 4) },
            { 1210, new PinItem(1210, 1712, ItemType.Pin, "ITM_BDG_Name_0214", "ITM_BDG_Info_0214", "ID214_RyuGu", 5, 610, 28, 1712, 5, 1135, 0f, 0, 10f, 15f, 3, 2, 40.29f, null, 0, 5,  0, -1, null, 11) },
            { 1211, new PinItem(1211, 1713, ItemType.Pin, "ITM_BDG_Name_0215", "ITM_BDG_Info_0215", "ID215_RyuGu", 5, 611, 26, 1713, 5, 1193, 0f, 0, 14.4f, 21.6f, 8, 5, 58.99f, new ushort[] { 133 }, 3240, 5,  0, -1, null, 10) },
            { 1212, new PinItem(1212, 1800, ItemType.Pin, "ITM_BDG_Name_0216", "ITM_BDG_Info_0216", "ID216_TopoTopo", 1, 612, 18, 1800, 6, 770, 0.2f, 0, 9.6f, 14.4f, 5, 2, 18.56f, new ushort[] { 133 }, 1980, 5,  5, 1801, null, 10) },
            { 1213, new PinItem(1213, 1801, ItemType.Pin, "ITM_BDG_Name_0218", "ITM_BDG_Info_0217", "ID218_TopoTopo", 1, 613, 18, 1801, 6, 959, 0.2f, 0, 12f, 18f, 10, 4, 36.63f, new ushort[] { 134 }, 2400, 5,  10, -1, new short[] { -1,1809,-1,-1,-1,-1,-1 }, 10) },
            { 1214, new PinItem(1214, 1802, ItemType.Pin, "ITM_BDG_Name_0217", "ITM_BDG_Info_0218", "ID217_TopoTopo", 1, 614, 8, 1802, 6, 365, 0.9f, 0, 9.6f, 14.4f, 7, 2, 3.71f, null, 1120, 5,  0, -1, null, 3) },
            { 1215, new PinItem(1215, 1803, ItemType.Pin, "ITM_BDG_Name_0219", "ITM_BDG_Info_0219", "ID219_TopoTopo", 1, 615, 7, 1803, 6, 479, 0.9f, 0, 8f, 12f, 5, 4, 4.82f, null, 1220, 0,  0, -1, null, 1) },
            { 1216, new PinItem(1216, 1804, ItemType.Pin, "ITM_BDG_Name_0220", "ITM_BDG_Info_0220", "ID220_TopoTopo", 1, 616, 7, 1804, 6, 1249, 0.9f, 0, 10f, 15f, 5, 4, 40.29f, null, 2730, 5,  5, -1, new short[] { -1,-1,-1,-1,1808,-1,-1 }, 1) },
            { 1217, new PinItem(1217, 1805, ItemType.Pin, "ITM_BDG_Name_0221", "ITM_BDG_Info_0221", "ID221_TopoTopo", 1, 617, 11, 1805, 6, 505, 0.9f, 0, 8f, 12f, 3, 2, 5f, null, 1450, 0,  0, -1, null, 2) },
            { 1218, new PinItem(1218, 1806, ItemType.Pin, "ITM_BDG_Name_0222", "ITM_BDG_Info_0222", "ID222_TopoTopo", 1, 618, 11, 1806, 6, 925, 0.9f, 0, 12f, 18f, 10, 5, 24.13f, null, 800, 5,  10, 1807, null, 2) },
            { 1219, new PinItem(1219, 1807, ItemType.Pin, "ITM_BDG_Name_0223", "ITM_BDG_Info_0223", "ID223_TopoTopo", 1, 619, 11, 1807, 6, 1205, 0.9f, 0, 14.4f, 21.6f, 5, 2, 44.32f, null, 2870, 5,  0, -1, null, 2) },
            { 1220, new PinItem(1220, 1808, ItemType.Pin, "ITM_BDG_Name_0224", "ITM_BDG_Info_0224", "ID224_TopoTopo", 1, 620, 10, 1808, 6, 1245, 0.9f, 0, 12f, 18f, 3, 2, 48.75f, null, 3220, 5,  0, -1, null, 13) },
            { 1221, new PinItem(1221, 1809, ItemType.Pin, "ITM_BDG_Name_0225", "ITM_BDG_Info_0225", "ID225_TopoTopo", 1, 621, 15, 1809, 6, 1392, 0.9f, 0, 14.4f, 21.6f, 5, 4, 58.99f, new ushort[] { 1013 }, 3310, 5,  0, -1, null, 9) },
            { 1222, new PinItem(1222, 1810, ItemType.Pin, "ITM_BDG_Name_0226", "ITM_BDG_Info_0226", "ID226_NoBrand", 0, 622, 18, 1810, 6, 1382, 0.2f, 0, 12f, 18f, 3, 2, 58.99f, null, 3430, 5,  0, -1, null, 10) },
            { 1227, new PinItem(1227, 1904, ItemType.Pin, "ITM_BDG_Name_0227", "ITM_BDG_Info_0227", "ID227_NATURALPUPPY", 11, 627, 8, 1904, 5, 575, 1f, 0, 9.6f, 14.4f, 5, 1, 6.5f, null, 1260, 0,  0, -1, null, 3) },
            { 1228, new PinItem(1228, 1905, ItemType.Pin, "ITM_BDG_Name_0228", "ITM_BDG_Info_0228", "ID228_NATURALPUPPY", 11, 628, 8, 1905, 5, 1245, 1f, 0, 14.4f, 21.6f, 5, 1, 53.62f, null, 2640, 5,  0, -1, null, 3) },
            { 1229, new PinItem(1229, 1906, ItemType.Pin, "ITM_BDG_Name_0229", "ITM_BDG_Info_0229", "ID229_NATURALPUPPY", 11, 629, 13, 1906, 5, 995, 1f, 0, 8f, 12f, 3, 2, 33.3f, null, 2010, 0,  0, -1, null, 6) },
            { 1230, new PinItem(1230, 1907, ItemType.Pin, "ITM_BDG_Name_0230", "ITM_BDG_Info_0230", "ID230_NATURALPUPPY", 11, 630, 10, 1907, 5, 575, 1f, 0, 8f, 12f, 3, 2, 6.5f, null, 650, 0,  0, -1, null, 13) },
            { 1231, new PinItem(1231, 1908, ItemType.Pin, "ITM_BDG_Name_0231", "ITM_BDG_Info_0231", "ID231_NATURALPUPPY", 11, 631, 2, 1908, 5, 1065, 1f, 0, 10f, 15f, 3, 2, 36.63f, null, 2310, 0,  0, -1, null, 13) },
            { 1232, new PinItem(1232, 1909, ItemType.Pin, "ITM_BDG_Name_0232", "ITM_BDG_Info_0232", "ID232_MONOCROW", 10, 632, 10, 1909, 5, 1225, 1f, 0, 18f, 27f, 10, 5, 58.99f, null, 2890, 5,  0, -1, null, 13) },
            { 1244, new PinItem(1244, 1915, ItemType.Pin, "ITM_BDG_Name_0233", "ITM_BDG_Info_0233", "ID233_croakypanic", 14, 644, 18, 1915, 5, 1050, 4.5f, 0, 10f, 15f, 3, 2, 40.29f, new ushort[] { 2011 }, 3520, 5,  3, -1, new short[] { -1,-1,-1,1916,-1,-1,-1 }, 5) },
            { 1251, new PinItem(1251, 2805, ItemType.Pin, "ITM_BDG_Name_0238", "ITM_BDG_Info_0234", "ID238_NoBrand", 0, 651, 6, 2805, 5, 985, 0f, 0, 10f, 15f, 3, 2, 36.63f, new ushort[] { 2011 }, 2940, 5,  0, -1, null, 5) },
            { 1252, new PinItem(1252, 2806, ItemType.Pin, "ITM_BDG_Name_0235", "ITM_BDG_Info_0235", "ID235_croakypanic", 14, 652, 9, 2806, 5, 1103, 0f, 0, 10f, 15f, 3, 4, 48.75f, null, 2640, 0,  0, -1, null, 23) },
            { 1242, new PinItem(1242, 1913, ItemType.Pin, "ITM_BDG_Name_0236", "ITM_BDG_Info_0236", "ID236_croakypanic", 14, 642, 18, 1913, 5, 896, 4.5f, 0, 12f, 18f, 3, 2, 33.3f, new ushort[] { 133 }, 5000, 0,  0, -1, null, 10) },
            { 1243, new PinItem(1243, 1914, ItemType.Pin, "ITM_BDG_Name_0237", "ITM_BDG_Info_0237", "ID237_croakypanic", 14, 643, 18, 1914, 5, 1193, 4.5f, 0, 21.6f, 32.4f, 3, 2, 58.99f, new ushort[] { 134 }, 0, 5,  0, -1, null, 10) },
            { 1245, new PinItem(1245, 1916, ItemType.Pin, "ITM_BDG_Name_0234", "ITM_BDG_Info_0238", "ID234_croakypanic", 14, 645, 18, 1915, 5, 1170, 4.5f, 0, 12f, 18f, 3, 2, 53.62f, new ushort[] { 2011 }, 4120, 5,  0, -1, null, 5) },
            { 1225, new PinItem(1225, 1900, ItemType.Pin, "ITM_BDG_Name_0239", "ITM_BDG_Info_0239", "ID239_NoBrand", 0, 625, 7, 1902, 5, 55, 1f, 0, 6f, 9f, 3, 1, 1f, null, 240, 0,  0, -1, null, 1) },
            { 1223, new PinItem(1223, 1901, ItemType.Pin, "ITM_BDG_Name_0240", "ITM_BDG_Info_0240", "ID240_RyuGu", 5, 623, 7, 1900, 5, 633, 1f, 0, 8f, 12f, 3, 2, 6.5f, null, 1150, 0,  3, 1902, null, 1) },
            { 1224, new PinItem(1224, 1902, ItemType.Pin, "ITM_BDG_Name_0241", "ITM_BDG_Info_0241", "ID241_RyuGu", 5, 624, 7, 1901, 5, 864, 1f, 0, 8f, 12f, 3, 2, 14.28f, null, 1470, 0,  0, -1, null, 1) },
            { 1226, new PinItem(1226, 1903, ItemType.Pin, "ITM_BDG_Name_0242", "ITM_BDG_Info_0242", "ID242_RyuGu", 5, 626, 7, 1903, 5, 1326, 1f, 0, 12f, 18f, 3, 2, 44.32f, null, 2150, 5,  0, -1, null, 1) },
            { 1233, new PinItem(1233, 1910, ItemType.Pin, "ITM_BDG_Name_0243", "ITM_BDG_Info_0243", "ID243_NoBrand", 0, 633, 6, 1910, 5, 1325, 1f, 0, 12f, 18f, 3, 2, 58.99f, null, 3120, 5,  0, -1, null, 6) },
            { 1234, new PinItem(1234, 2000, ItemType.Pin, "ITM_BDG_Name_0244", "ITM_BDG_Info_0244", "ID244_ShepherdHouse", 8, 634, 2, 2000, 5, 546, 0f, 6, 8f, 12f, 5, 1, 6.5f, null, 1000, 0,  5, 2001, null, 4) },
            { 1235, new PinItem(1235, 2001, ItemType.Pin, "ITM_BDG_Name_0245", "ITM_BDG_Info_0245", "ID245_ShepherdHouse", 8, 635, 2, 2001, 5, 746, 0f, 6, 8f, 12f, 5, 1, 14.28f, null, 2940, 0,  5, -1, new short[] { -1,-1,-1,2002,-1,-1,-1 }, 4) },
            { 1236, new PinItem(1236, 2002, ItemType.Pin, "ITM_BDG_Name_0246", "ITM_BDG_Info_0246", "ID246_ShepherdHouse", 8, 636, 2, 2002, 5, 879, 0f, 6, 10f, 15f, 7, 5, 24.13f, null, 3100, 0,  0, -1, null, 4) },
            { 1237, new PinItem(1237, 2003, ItemType.Pin, "ITM_BDG_Name_0247", "ITM_BDG_Info_0247", "ID247_ShepherdHouse", 8, 637, 11, 2003, 5, 785, 0f, 6, 8f, 12f, 3, 2, 14.28f, null, 2910, 0,  0, -1, null, 2) },
            { 1238, new PinItem(1238, 2004, ItemType.Pin, "ITM_BDG_Name_0248", "ITM_BDG_Info_0248", "ID248_ShepherdHouse", 8, 638, 11, 2004, 5, 1225, 0f, 6, 12f, 18f, 3, 2, 48.75f, null, 4500, 5,  3, -1, new short[] { -1,-1,-1,2005,-1,-1,-1 }, 2) },
            { 1239, new PinItem(1239, 2005, ItemType.Pin, "ITM_BDG_Name_0249", "ITM_BDG_Info_0249", "ID249_ShepherdHouse", 8, 639, 11, 2005, 5, 1285, 0f, 6, 12f, 18f, 3, 2, 58.99f, null, 4730, 5,  0, -1, null, 2) },
            { 1240, new PinItem(1240, 1911, ItemType.Pin, "ITM_BDG_Name_0250", "ITM_BDG_Info_0250", "ID250_croakypanic", 14, 640, 18, 1911, 5, 864, 4.5f, 0, 9.6f, 14.4f, 3, 2, 14.28f, new ushort[] { 1013 }, 2190, 5,  3, 1912, null, 9) },
            { 1241, new PinItem(1241, 1912, ItemType.Pin, "ITM_BDG_Name_0251", "ITM_BDG_Info_0251", "ID251_croakypanic", 14, 641, 18, 1912, 5, 1172, 4.5f, 0, 12f, 18f, 3, 2, 36.63f, new ushort[] { 1013 }, 2890, 5,  0, -1, null, 9) },
            { 1246, new PinItem(1246, 2800, ItemType.Pin, "ITM_BDG_Name_0252", "ITM_BDG_Info_0252", "ID252_ShepherdHouse", 8, 646, 6, 2800, 5, 546, 0f, 0, 8f, 12f, 5, 1, 6.5f, null, 1360, 0,  0, -1, null, 4) },
            { 1247, new PinItem(1247, 2801, ItemType.Pin, "ITM_BDG_Name_0253", "ITM_BDG_Info_0253", "ID253_ShepherdHouse", 8, 647, 6, 2801, 5, 879, 0f, 0, 10f, 15f, 5, 4, 24.13f, null, 2030, 0,  0, -1, null, 4) },
            { 1248, new PinItem(1248, 2802, ItemType.Pin, "ITM_BDG_Name_0254", "ITM_BDG_Info_0254", "ID254_ShepherdHouse", 8, 648, 6, 2802, 5, 707, 0f, 0, 8f, 12f, 5, 1, 14.28f, new ushort[] { 1014 }, 1300, 0,  5, 2803, null, 8) },
            { 1249, new PinItem(1249, 2803, ItemType.Pin, "ITM_BDG_Name_0255", "ITM_BDG_Info_0255", "ID255_ShepherdHouse", 8, 649, 6, 2803, 5, 896, 0f, 0, 10f, 15f, 5, 2, 33.3f, new ushort[] { 1014 }, 2590, 0,  5, -1, new short[] { 2804,-1,-1,-1,-1,-1,-1 }, 8) },
            { 1250, new PinItem(1250, 2804, ItemType.Pin, "ITM_BDG_Name_0256", "ITM_BDG_Info_0256", "ID256_ShepherdHouse", 8, 650, 6, 2804, 5, 1205, 0f, 0, 9f, 13.5f, 15, 4, 44.32f, null, 3030, 0,  0, -1, null, 7) },
            { 1187, new PinItem(1187, 1507, ItemType.Pin, "ITM_BDG_Name_0257", "ITM_BDG_Info_0257", "ID257_garagara", 6, 587, 19, 1507, 4, 480, 2f, 0, 6f, 9f, 3, 2, 5f, null, 1430, 0,  3, 1508, null, 0) },
            { 1188, new PinItem(1188, 1508, ItemType.Pin, "ITM_BDG_Name_0258", "ITM_BDG_Info_0258", "ID258_garagara", 6, 588, 20, 1508, 4, 613, 2f, 0, 6f, 9f, 3, 2, 8.45f, null, 1750, 0,  0, -1, null, 0) },
            { 1189, new PinItem(1189, 1509, ItemType.Pin, "ITM_BDG_Name_0259", "ITM_BDG_Info_0259", "ID259_garagara", 6, 589, 12, 1509, 4, 1202, 2f, 0, 14.4f, 21.6f, 8, 4, 58.99f, null, 3710, 5,  8, 1510, null, 0) },
            { 1190, new PinItem(1190, 1510, ItemType.Pin, "ITM_BDG_Name_0260", "ITM_BDG_Info_0260", "ID260_garagara", 6, 590, 12, 1510, 4, 1259, 2f, 0, 14.4f, 21.6f, 5, 5, 58.99f, null, 4220, 5,  0, -1, null, 0) },
            { 1204, new PinItem(1204, 1706, ItemType.Pin, "ITM_BDG_Name_0261", "ITM_BDG_Info_0261", "ID261_garagara", 6, 604, 7, 1706, 6, 864, 0f, 0, 8f, 12f, 3, 2, 14.28f, null, 1980, 5,  0, -1, null, 1) },
            { 1205, new PinItem(1205, 1707, ItemType.Pin, "ITM_BDG_Name_0262", "ITM_BDG_Info_0262", "ID262_garagara", 6, 605, 7, 1707, 6, 1249, 0f, 0, 10f, 15f, 5, 4, 40.29f, null, 2730, 5,  0, -1, null, 1) },
            { 1287, new PinItem(1287, 2902, ItemType.Pin, "ITM_BDG_Name_0263", "ITM_BDG_Info_0263", "ID263_garagara", 6, 687, 31, 2902, 6, 645, 1f, 0, 9.6f, 14.4f, 3, 4, 8.45f, null, 1680, 0,  0, -1, null, 13) },
            { 1288, new PinItem(1288, 2903, ItemType.Pin, "ITM_BDG_Name_0264", "ITM_BDG_Info_0264", "ID264_garagara", 6, 688, 31, 2903, 6, 1135, 1f, 0, 12f, 18f, 3, 2, 40.29f, null, 2750, 0,  0, -1, null, 13) },
            { 1206, new PinItem(1206, 1708, ItemType.Pin, "ITM_BDG_Name_0265", "ITM_BDG_Info_0265", "ID265_garagara", 6, 606, 8, 1708, 6, 995, 0f, 0, 12f, 18f, 7, 2, 33.3f, null, 2590, 5,  7, 1709, null, 3) },
            { 1207, new PinItem(1207, 1709, ItemType.Pin, "ITM_BDG_Name_0266", "ITM_BDG_Info_0266", "ID266_garagara", 6, 607, 8, 1709, 6, 1205, 0f, 0, 14.4f, 21.6f, 5, 2, 44.32f, null, 3050, 5,  0, -1, null, 3) },
            { 1191, new PinItem(1191, 1511, ItemType.Pin, "ITM_BDG_Name_0267", "ITM_BDG_Info_0267", "ID267_garagara", 6, 591, 9, 1511, 4, 1121, 2f, 0, 12f, 18f, 5, 4, 53.62f, null, 3380, 5,  0, -1, null, 23) },
            { 1284, new PinItem(1284, 2404, ItemType.Pin, "ITM_BDG_Name_0268", "ITM_BDG_Info_0268", "ID268_NoBrand", 0, 684, 6, 2404, 6, 1325, 0f, 0, 14.4f, 21.6f, 3, 2, 58.99f, null, 0, 5,  0, -1, null, 11) },
            { 1253, new PinItem(1253, 2200, ItemType.Pin, "ITM_BDG_Name_0269", "ITM_BDG_Info_0269", "ID269_HogFang", 12, 653, 34, 2200, 6, 613, 0f, 0, 6f, 9f, 3, 1, 8.45f, new ushort[] { 1015 }, 650, 0,  3, 2201, null, 0) },
            { 1254, new PinItem(1254, 2201, ItemType.Pin, "ITM_BDG_Name_0270", "ITM_BDG_Info_0270", "ID270_HogFang", 12, 654, 34, 2201, 6, 679, 0f, 0, 6f, 9f, 5, 2, 10.98f, new ushort[] { 1015 }, 1840, 0,  0, -1, null, 0) },
            { 1255, new PinItem(1255, 2202, ItemType.Pin, "ITM_BDG_Name_0271", "ITM_BDG_Info_0271", "ID271_HogFang", 12, 655, 34, 2202, 6, 785, 0f, 0, 9.6f, 14.4f, 5, 4, 14.28f, new ushort[] { 1015 }, 800, 0,  0, -1, null, 3) },
            { 1256, new PinItem(1256, 2203, ItemType.Pin, "ITM_BDG_Name_0272", "ITM_BDG_Info_0272", "ID272_HogFang", 12, 656, 34, 2203, 6, 1245, 0f, 0, 14.4f, 21.6f, 3, 2, 53.62f, new ushort[] { 1015 }, 3150, 0,  0, -1, null, 3) },
            { 1257, new PinItem(1257, 2204, ItemType.Pin, "ITM_BDG_Name_0273", "ITM_BDG_Info_0273", "ID273_HogFang", 12, 657, 34, 2204, 6, 1018, 0f, 0, 10f, 15f, 5, 1, 24.13f, new ushort[] { 1015 }, 0, 0,  0, -1, null, 1) },
            { 1258, new PinItem(1258, 2205, ItemType.Pin, "ITM_BDG_Name_0274", "ITM_BDG_Info_0274", "ID274_HogFang", 12, 658, 34, 2205, 6, 1326, 0f, 0, 12f, 18f, 10, 4, 44.32f, new ushort[] { 1015 }, 2660, 5,  10, -1, new short[] { -1,-1,-1,-1,2206,-1,-1 }, 1) },
            { 1259, new PinItem(1259, 2206, ItemType.Pin, "ITM_BDG_Name_0275", "ITM_BDG_Info_0275", "ID275_HogFang", 12, 659, 6, 2206, 6, 1259, 0f, 0, 15.8f, 23.7f, 5, 4, 58.99f, new ushort[] { 1015 }, 3540, 5,  0, -1, null, 12) },
            { 1260, new PinItem(1260, 2207, ItemType.Pin, "ITM_BDG_Name_0276", "ITM_BDG_Info_0276", "ID276_NoBrand", 0, 660, 34, 2207, 6, 1325, 0f, 0, 14.4f, 21.6f, 3, 2, 58.99f, new ushort[] { 1015 }, 4470, 5,  0, -1, null, 3) },
            { 1262, new PinItem(1262, 2301, ItemType.Pin, "ITM_BDG_Name_0277", "ITM_BDG_Info_0277", "ID277_TigrePUNKS", 3, 662, 30, 2301, 3, 0, 0f, 0, -1f, -1f, 3, 2, 1.69f, null, 360, 0,  0, -1, null, 10) },
            { 1263, new PinItem(1263, 2302, ItemType.Pin, "ITM_BDG_Name_0278", "ITM_BDG_Info_0278", "ID278_TigrePUNKS", 3, 663, 30, 2302, 3, 0, 0f, 0, -1f, -1f, 10, 1, 8.45f, null, 550, 5,  0, -1, null, 10) },
            { 1270, new PinItem(1270, 2309, ItemType.Pin, "ITM_BDG_Name_0279", "ITM_BDG_Info_0279", "ID279_TigrePUNKS", 3, 670, 30, 2309, 3, 0, 0f, 0, -1f, -1f, 8, 4, 40.29f, null, 0, 5,  0, -1, null, 10) },
            { 1264, new PinItem(1264, 2303, ItemType.Pin, "ITM_BDG_Name_0280", "ITM_BDG_Info_0280", "ID280_TigrePUNKS", 3, 664, 31, 2303, 5, 0, 3f, 0, 21f, 31.5f, 7, 2, 10.98f, null, 940, 5,  7, 2307, null, 8) },
            { 1265, new PinItem(1265, 2304, ItemType.Pin, "ITM_BDG_Name_0281", "ITM_BDG_Info_0281", "ID281_TigrePUNKS", 3, 665, 31, 2304, 5, 0, 3f, 0, 21f, 31.5f, 7, 2, 18.56f, null, 1080, 5,  7, 2305, null, 8) },
            { 1266, new PinItem(1266, 2305, ItemType.Pin, "ITM_BDG_Name_0282", "ITM_BDG_Info_0282", "ID282_TigrePUNKS", 3, 666, 31, 2305, 5, 0, 3f, 0, 27.3f, 41f, 7, 2, 53.62f, null, 1570, 5,  0, -1, null, 8) },
            { 1268, new PinItem(1268, 2307, ItemType.Pin, "ITM_BDG_Name_0283", "ITM_BDG_Info_0283", "ID283_TigrePUNKS", 3, 668, 31, 2307, 5, 0, 3f, 0, 28f, 42f, 7, 2, 33.3f, null, 1220, 5,  0, -1, null, 8) },
            { 1267, new PinItem(1267, 2306, ItemType.Pin, "ITM_BDG_Name_0284", "ITM_BDG_Info_0284", "ID312_NoBrand", 0, 667, 31, 2306, 5, 0, 3f, 0, 10f, 15f, 15, 2, 24.13f, null, 5500, 5,  0, -1, null, 7) },
            { 1280, new PinItem(1280, 2400, ItemType.Pin, "ITM_BDG_Name_0285", "ITM_BDG_Info_0285", "ID285_MONOCROW", 10, 680, 18, 2400, 6, 365, 0f, 0, 9.6f, 14.4f, 5, 1, 3.71f, null, 0, 0,  0, -1, null, 11) },
            { 1281, new PinItem(1281, 2401, ItemType.Pin, "ITM_BDG_Name_0286", "ITM_BDG_Info_0286", "ID286_MONOCROW", 10, 681, 18, 2401, 6, 715, 0f, 0, 9.6f, 14.4f, 7, 2, 10.98f, null, 1030, 5,  7, 2402, null, 11) },
            { 1282, new PinItem(1282, 2402, ItemType.Pin, "ITM_BDG_Name_0287", "ITM_BDG_Info_0287", "ID287_MONOCROW", 10, 682, 18, 2402, 6, 925, 0f, 0, 15f, 22.5f, 8, 4, 24.13f, null, 1120, 5,  0, -1, null, 11) },
            { 1283, new PinItem(1283, 2403, ItemType.Pin, "ITM_BDG_Name_0288", "ITM_BDG_Info_0288", "ID288_MONOCROW", 10, 683, 18, 2403, 6, 1135, 0f, 0, 18f, 27f, 3, 2, 48.75f, null, 0, 5,  0, -1, null, 11) },
            { 1285, new PinItem(1285, 2900, ItemType.Pin, "ITM_BDG_Name_0289", "ITM_BDG_Info_0289", "ID289_Jolibecot", 2, 685, 29, 2900, 6, 995, 1f, 0, 10f, 15f, 3, 2, 33.3f, null, 0, 5,  0, -1, null, 13) },
            { 1286, new PinItem(1286, 2901, ItemType.Pin, "ITM_BDG_Name_0290", "ITM_BDG_Info_0290", "ID290_Jolibecot", 2, 686, 29, 2901, 6, 1225, 1f, 0, 12f, 18f, 3, 2, 48.75f, null, 1910, 5,  0, -1, null, 13) },
            { 1289, new PinItem(1289, 2904, ItemType.Pin, "ITM_BDG_Name_0291", "ITM_BDG_Info_0291", "ID291_NoBrand", 0, 689, 16, 2904, 6, 1225, 1f, 0, 12f, 18f, 3, 2, 48.75f, null, 3260, 5,  0, -1, null, 13) },
            { 1293, new PinItem(1293, 3002, ItemType.Pin, "ITM_BDG_Name_0292", "ITM_BDG_Info_0292", "ID292_GattoNero", 13, 693, 6, 315, 1, 782, 0f, 3, 17.3f, 26f, 3, 2, 58.99f, new ushort[] { 133 }, 9600, 5,  0, -1, null, 10) },
            { 1294, new PinItem(1294, 3003, ItemType.Pin, "ITM_BDG_Name_0293", "ITM_BDG_Info_0293", "ID293_GattoNero", 13, 694, 1, 426, 2, 982, 0f, 8, 14.4f, 21.6f, 3, 2, 58.99f, null, 3030, 5,  0, -1, null, 3) },
            { 1295, new PinItem(1295, 3004, ItemType.Pin, "ITM_BDG_Name_0294", "ITM_BDG_Info_0294", "ID294_GattoNero", 13, 695, 10, 1010, 3, 982, 1f, 0, 12f, 18f, 3, 2, 58.99f, null, 2260, 5,  0, -1, null, 1) },
            { 1296, new PinItem(1296, 3005, ItemType.Pin, "ITM_BDG_Name_0295", "ITM_BDG_Info_0295", "ID295_GattoNero", 13, 696, 2, 1109, 4, 882, 1f, 0, 12f, 18f, 3, 2, 58.99f, null, 0, 5,  0, -1, null, 11) },
            { 1297, new PinItem(1297, 3006, ItemType.Pin, "ITM_BDG_Name_0296", "ITM_BDG_Info_0296", "ID296_GattoNero", 13, 697, 11, 1714, 6, 942, 0f, 0, 12f, 18f, 5, 4, 58.99f, null, 3710, 5,  0, -1, null, 2) },
            { 1298, new PinItem(1298, 3007, ItemType.Pin, "ITM_BDG_Name_0297", "ITM_BDG_Info_0297", "ID297_GattoNero", 13, 698, 15, 1917, 5, 982, 1f, 0, 14.4f, 21.6f, 3, 2, 58.99f, new ushort[] { 1013 }, 2770, 5,  0, -1, null, 9) },
            { 1299, new PinItem(1299, 3008, ItemType.Pin, "ITM_BDG_Name_0298", "ITM_BDG_Info_0298", "ID298_GattoNero", 13, 699, 2, 121, 1, 869, 0f, 8, 12f, 18f, 10, 5, 24.13f, new ushort[] { 133 }, 2400, 5,  0, -1, null, 10) },
            { 1300, new PinItem(1300, 3009, ItemType.Pin, "ITM_BDG_Name_0299", "ITM_BDG_Info_0299", "ID299_GattoNero", 13, 700, 28, 427, 2, 669, 0f, 999, 9.6f, 14.4f, 10, 5, 10.98f, new ushort[] { 133 }, 1240, 5,  0, -1, null, 10) },
            { 1301, new PinItem(1301, 3010, ItemType.Pin, "ITM_BDG_Name_0300", "ITM_BDG_Info_0300", "ID300_GattoNero", 13, 701, 6, 909, 4, 1149, 1f, 0, 14.4f, 21.6f, 6, 5, 53.62f, new ushort[] { 133 }, 0, 5,  0, -1, null, 10) },
            { 1302, new PinItem(1302, 3011, ItemType.Pin, "ITM_BDG_Name_0301", "ITM_BDG_Info_0301", "ID301_GattoNero", 13, 702, 27, 2606, 3, 869, 1f, 0, 12f, 18f, 5, 2, 33.3f, new ushort[] { 133 }, 2960, 5,  0, -1, null, 10) },
            { 1303, new PinItem(1303, 3012, ItemType.Pin, "ITM_BDG_Name_0302", "ITM_BDG_Info_0302", "ID302_GattoNero", 13, 703, 26, 213, 4, 1282, 4.5f, 0, 11.3f, 17f, 3, 2, 58.99f, null, 4540, 5,  0, -1, null, 7) },
            { 1304, new PinItem(1304, 3013, ItemType.Pin, "ITM_BDG_Name_0303", "ITM_BDG_Info_0303", "ID303_GattoNero", 13, 704, 16, 2905, 6, 1222, 1f, 0, 15f, 22.5f, 6, 4, 53.62f, null, 0, 5,  0, -1, null, 13) },
            { 1305, new PinItem(1305, 3014, ItemType.Pin, "ITM_BDG_Name_0304", "ITM_BDG_Info_0304", "ID304_NoBrand", 0, 705, 1, 122, 1, 597, 0f, 6, 8f, 12f, 10, 0, 3.71f, new ushort[] { 2011 }, 0, 5,  0, -1, null, 5) },
            { 1306, new PinItem(1306, 3015, ItemType.Pin, "ITM_BDG_Name_0305", "ITM_BDG_Info_0305", "ID305_NoBrand", 0, 706, 8, 807, 2, 597, 0f, 8, 9.6f, 14.4f, 10, 0, 8.45f, null, 0, 5,  0, -1, null, 3) },
            { 1307, new PinItem(1307, 3016, ItemType.Pin, "ITM_BDG_Name_0306", "ITM_BDG_Info_0306", "ID306_NoBrand", 0, 707, 5, 1408, 3, 597, 1f, 0, 14f, 21f, 10, 0, 14.28f, null, 0, 5,  0, -1, null, 12) },
            { 1290, new PinItem(1290, 3000, ItemType.Pin, "ITM_BDG_Name_0307", "ITM_BDG_Info_0307", "ID307_JupiterOfTheMonkey", 9, 690, 1, 119, 1, 1193, 0f, 6, 13.2f, 19.8f, 3, 2, 58.99f, new ushort[] { 1014 }, 0, 0,  0, -1, null, 8) },
            { 1291, new PinItem(1291, 3001, ItemType.Pin, "ITM_BDG_Name_0308", "ITM_BDG_Info_0308", "ID308_JupiterOfTheMonkey", 9, 691, 1, 120, 1, 1193, 0f, 6, 13.2f, 19.8f, 3, 2, 58.99f, new ushort[] { 1014 }, 3240, 0,  0, -1, null, 8) },
            { 1308, new PinItem(1308, 3017, ItemType.Pin, "ITM_BDG_Name_0309", "ITM_BDG_Info_0309", "ID309_NoBrand", 0, 708, 16, 2906, 6, 575, 1f, 0, 9.6f, 14.4f, 3, 2, 6.5f, null, 0, 5,  0, -1, null, 13) },
            { 1309, new PinItem(1309, 3018, ItemType.Pin, "ITM_BDG_Name_0310", "ITM_BDG_Info_0310", "ID310_NoBrand", 0, 709, 7, 1715, 5, 1326, 0f, 0, 12f, 18f, 3, 2, 44.32f, null, 0, 5,  0, -1, null, 1) },
            { 1310, new PinItem(1310, 3019, ItemType.Pin, "ITM_BDG_Name_0311", "ITM_BDG_Info_0311", "ID284_NoBrand", 0, 710, 29, 2907, 6, 1265, 1f, 0, 14.4f, 21.6f, 3, 2, 58.99f, null, 7000, 5,  0, -1, null, 13) },
            { 1311, new PinItem(1311, 3020, ItemType.Pin, "ITM_BDG_Name_0312", "ITM_BDG_Info_0312", "ID211_NoBrand", 0, 711, 6, 2405, 6, 1325, 0f, 0, 21.6f, 32.4f, 3, 2, 58.99f, null, 0, 5,  0, -1, null, 11) },
            { 5000, new PinItem(5000, 5000, ItemType.Pin, "ITM_BDG_Name_0313", "ITM_BDG_Info_0313", "bad_99_00_00", 0, 712, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 1, 0,  0, -1, null, -1) },
            { 5001, new PinItem(5001, 5001, ItemType.Pin, "ITM_BDG_Name_0314", "ITM_BDG_Info_0314", "bad_99_00_01", 0, 713, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 5, 0,  0, -1, null, -1) },
            { 5002, new PinItem(5002, 5002, ItemType.Pin, "ITM_BDG_Name_0315", "ITM_BDG_Info_0315", "bad_99_00_02", 0, 714, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 10, 0,  0, -1, null, -1) },
            { 5003, new PinItem(5003, 5003, ItemType.Pin, "ITM_BDG_Name_0316", "ITM_BDG_Info_0316", "bad_99_00_03", 0, 715, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 50, 0,  0, -1, null, -1) },
            { 5004, new PinItem(5004, 5004, ItemType.Pin, "ITM_BDG_Name_0317", "ITM_BDG_Info_0317", "bad_99_00_04", 0, 716, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 100, 0,  0, -1, null, -1) },
            { 5005, new PinItem(5005, 5005, ItemType.Pin, "ITM_BDG_Name_0318", "ITM_BDG_Info_0318", "bad_99_00_05", 0, 717, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 500, 0,  0, -1, null, -1) },
            { 5006, new PinItem(5006, 5006, ItemType.Pin, "ITM_BDG_Name_0319", "ITM_BDG_Info_0319", "bad_99_00_06", 0, 718, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 1000, 0,  0, -1, null, -1) },
            { 5007, new PinItem(5007, 5007, ItemType.Pin, "ITM_BDG_Name_0320", "ITM_BDG_Info_0320", "bad_99_00_07", 0, 719, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 5000, 0,  0, -1, null, -1) },
            { 5008, new PinItem(5008, 5008, ItemType.Pin, "ITM_BDG_Name_0321", "ITM_BDG_Info_0321", "bad_99_00_08", 0, 720, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 10000, 0,  0, -1, null, -1) },
            { 5009, new PinItem(5009, 5009, ItemType.Pin, "ITM_BDG_Name_0322", "ITM_BDG_Info_0322", "bad_99_00_09", 0, 721, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 100000, 0,  0, -1, null, -1) },
            { 5100, new PinItem(5100, 5100, ItemType.Pin, "ITM_BDG_Name_0323", "ITM_BDG_Info_0323", "ID323_sozai", 0, 722, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 0, 0,  0, -1, null, -1) },
            { 5101, new PinItem(5101, 5101, ItemType.Pin, "ITM_BDG_Name_0324", "ITM_BDG_Info_0324", "ID324_sozai", 0, 723, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 0, 0,  0, -1, null, -1) },
            { 5102, new PinItem(5102, 5102, ItemType.Pin, "ITM_BDG_Name_0325", "ITM_BDG_Info_0325", "ID325_sozai", 0, 724, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 0, 0,  0, -1, null, -1) },
            { 5103, new PinItem(5103, 5103, ItemType.Pin, "ITM_BDG_Name_0326", "ITM_BDG_Info_0326", "ID326_sozai", 0, 725, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 0, 0,  0, -1, null, -1) },
            { 5104, new PinItem(5104, 5104, ItemType.Pin, "ITM_BDG_Name_0327", "ITM_BDG_Info_0327", "ID327_sozai", 0, 726, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 0, 0,  0, -1, null, -1) },
            { 5105, new PinItem(5105, 5105, ItemType.Pin, "ITM_BDG_Name_0328", "ITM_BDG_Info_0328", "ID328_sozai", 0, 727, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 0, 0,  0, -1, null, -1) },
            { 5106, new PinItem(5106, 5106, ItemType.Pin, "ITM_BDG_Name_0329", "ITM_BDG_Info_0329", "ID329_sozai", 0, 728, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 0, 0,  0, -1, null, -1) },
            { 5107, new PinItem(5107, 5107, ItemType.Pin, "ITM_BDG_Name_0330", "ITM_BDG_Info_0330", "ID330_sozai", 0, 729, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 0, 0,  0, -1, null, -1) },
            { 5108, new PinItem(5108, 5108, ItemType.Pin, "ITM_BDG_Name_0331", "ITM_BDG_Info_0331", "ID331_sozai", 0, 730, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 0, 0,  0, -1, null, -1) },
            { 5109, new PinItem(5109, 5109, ItemType.Pin, "ITM_BDG_Name_0332", "ITM_BDG_Info_0332", "ID332_sozai", 0, 731, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 0, 0,  0, -1, null, -1) },
            { 5110, new PinItem(5110, 5110, ItemType.Pin, "ITM_BDG_Name_0333", "ITM_BDG_Info_0333", "ID333_sozai", 0, 732, 0, -1, -1, 0, 0f, 0, 0f, 0f, 1, 6, 1f, null, 0, 0,  0, -1, null, -1) },
            { 10100, new ClothingItem(10100, 100, ItemType.Clothing, "ITM_EQU_Name_0100", "ITM_EQU_Info_0100", "itm_01_000000", 1, 100, 0, 71, 111, 0, 2, 12) },
            { 10101, new ClothingItem(10101, 101, ItemType.Clothing, "ITM_EQU_Name_0101", "ITM_EQU_Info_0101", "itm_01_000010", 1, 101, 0, 21, 49, 0, 12, 84) },
            { 10102, new ClothingItem(10102, 102, ItemType.Clothing, "ITM_EQU_Name_0102", "ITM_EQU_Info_0102", "itm_01_000020", 1, 102, 0, 96, 45, 0, 2, 14) },
            { 10103, new ClothingItem(10103, 103, ItemType.Clothing, "ITM_EQU_Name_0103", "ITM_EQU_Info_0103", "itm_01_000031", 1, 103, 1, 57, 123, 8, 0, 20) },
            { 10104, new ClothingItem(10104, 104, ItemType.Clothing, "ITM_EQU_Name_0104", "ITM_EQU_Info_0104", "itm_01_000041", 1, 104, 1, 86, 41, 24, 0, 66) },
            { 10105, new ClothingItem(10105, 105, ItemType.Clothing, "ITM_EQU_Name_0105", "ITM_EQU_Info_0105", "itm_01_000051", 1, 105, 1, 109, 94, 33, 0, 88) },
            { 10106, new ClothingItem(10106, 106, ItemType.Clothing, "ITM_EQU_Name_0106", "ITM_EQU_Info_0106", "itm_01_000062", 1, 106, 2, 187, 101, 13, 0, 21) },
            { 10107, new ClothingItem(10107, 107, ItemType.Clothing, "ITM_EQU_Name_0107", "ITM_EQU_Info_0107", "itm_01_000072", 1, 107, 2, 7, 15, 10, 0, 17) },
            { 10108, new ClothingItem(10108, 108, ItemType.Clothing, "ITM_EQU_Name_0108", "ITM_EQU_Info_0108", "itm_01_000084", 1, 108, 5, 2, 64, 128, 0, 128) },
            { 10109, new ClothingItem(10109, 109, ItemType.Clothing, "ITM_EQU_Name_0109", "ITM_EQU_Info_0109", "itm_01_000094", 1, 109, 5, 121, 150, 160, 0, 160) },
            { 10110, new ClothingItem(10110, 110, ItemType.Clothing, "ITM_EQU_Name_0110", "ITM_EQU_Info_0110", "itm_01_000125", 1, 110, 3, 54, 130, 0, 8, 13) },
            { 10111, new ClothingItem(10111, 111, ItemType.Clothing, "ITM_EQU_Name_0111", "ITM_EQU_Info_0111", "itm_01_000135", 1, 111, 3, 185, 116, 0, 29, 48) },
            { 10112, new ClothingItem(10112, 112, ItemType.Clothing, "ITM_EQU_Name_0112", "ITM_EQU_Info_0112", "itm_01_000145", 1, 112, 3, 186, 30, 0, 10, 12) },
            { 10113, new ClothingItem(10113, 113, ItemType.Clothing, "ITM_EQU_Name_0113", "ITM_EQU_Info_0113", "itm_01_000153", 1, 113, 4, 22, 41, 12, 0, 0) },
            { 10114, new ClothingItem(10114, 114, ItemType.Clothing, "ITM_EQU_Name_0114", "ITM_EQU_Info_0114", "itm_01_000163", 1, 114, 4, 23, 105, 39, 0, 0) },
            { 10115, new ClothingItem(10115, 115, ItemType.Clothing, "ITM_EQU_Name_0115", "ITM_EQU_Info_0115", "itm_01_000171", 1, 115, 1, 137, 137, 42, 0, 108) },
            { 10116, new ClothingItem(10116, 116, ItemType.Clothing, "ITM_EQU_Name_0116", "ITM_EQU_Info_0116", "itm_01_000181", 1, 116, 2, 175, 74, 53, 0, 70) },
            { 10117, new ClothingItem(10117, 117, ItemType.Clothing, "ITM_EQU_Name_0117", "ITM_EQU_Info_0117", "itm_01_000030", 1, 117, 0, 37, 92, 0, 3, 23) },
            { 10200, new ClothingItem(10200, 200, ItemType.Clothing, "ITM_EQU_Name_0200", "ITM_EQU_Info_0200", "itm_01_010000", 2, 118, 0, 72, 111, 0, 2, 6) },
            { 10201, new ClothingItem(10201, 201, ItemType.Clothing, "ITM_EQU_Name_0201", "ITM_EQU_Info_0201", "itm_01_010010", 2, 119, 0, 104, 20, 0, 9, 61) },
            { 10202, new ClothingItem(10202, 202, ItemType.Clothing, "ITM_EQU_Name_0202", "ITM_EQU_Info_0202", "itm_01_010020", 2, 120, 0, 38, 92, 0, 10, 60) },
            { 10203, new ClothingItem(10203, 203, ItemType.Clothing, "ITM_EQU_Name_0203", "ITM_EQU_Info_0203", "itm_01_010031", 2, 121, 1, 119, 15, 10, 0, 20) },
            { 10204, new ClothingItem(10204, 204, ItemType.Clothing, "ITM_EQU_Name_0204", "ITM_EQU_Info_0204", "itm_01_010041", 2, 122, 1, 87, 86, 56, 0, 130) },
            { 10205, new ClothingItem(10205, 205, ItemType.Clothing, "ITM_EQU_Name_0205", "ITM_EQU_Info_0205", "itm_01_010051", 2, 123, 1, 58, 123, 15, 0, 22) },
            { 10206, new ClothingItem(10206, 206, ItemType.Clothing, "ITM_EQU_Name_0206", "ITM_EQU_Info_0206", "itm_01_010061", 2, 124, 1, 43, 130, 32, 0, 78) },
            { 10207, new ClothingItem(10207, 207, ItemType.Clothing, "ITM_EQU_Name_0207", "ITM_EQU_Info_0207", "itm_01_010072", 2, 125, 2, 180, 82, 10, 0, 12) },
            { 10208, new ClothingItem(10208, 208, ItemType.Clothing, "ITM_EQU_Name_0208", "ITM_EQU_Info_0208", "itm_01_010082", 2, 126, 2, 182, 82, 42, 0, 56) },
            { 10209, new ClothingItem(10209, 209, ItemType.Clothing, "ITM_EQU_Name_0209", "ITM_EQU_Info_0209", "itm_01_010092", 2, 127, 2, 162, 24, 17, 0, 19) },
            { 10210, new ClothingItem(10210, 210, ItemType.Clothing, "ITM_EQU_Name_0210", "ITM_EQU_Info_0210", "itm_01_010102", 2, 128, 2, 178, 74, 55, 0, 69) },
            { 10211, new ClothingItem(10211, 211, ItemType.Clothing, "ITM_EQU_Name_0211", "ITM_EQU_Info_0211", "itm_01_010114", 2, 129, 5, 110, 145, 180, 0, 180) },
            { 10212, new ClothingItem(10212, 212, ItemType.Clothing, "ITM_EQU_Name_0212", "ITM_EQU_Info_0212", "itm_01_010125", 2, 130, 3, 53, 130, 0, 6, 10) },
            { 10213, new ClothingItem(10213, 213, ItemType.Clothing, "ITM_EQU_Name_0213", "ITM_EQU_Info_0213", "itm_01_010135", 2, 131, 3, 186, 30, 0, 20, 33) },
            { 10214, new ClothingItem(10214, 214, ItemType.Clothing, "ITM_EQU_Name_0214", "ITM_EQU_Info_0214", "itm_01_010145", 2, 132, 3, 188, 121, 0, 21, 35) },
            { 10215, new ClothingItem(10215, 215, ItemType.Clothing, "ITM_EQU_Name_0215", "ITM_EQU_Info_0215", "itm_01_010155", 2, 133, 3, 16, 150, 0, 34, 56) },
            { 10216, new ClothingItem(10216, 216, ItemType.Clothing, "ITM_EQU_Name_0216", "ITM_EQU_Info_0216", "itm_01_010163", 2, 134, 4, 28, 20, 13, 26, 0) },
            { 10217, new ClothingItem(10217, 217, ItemType.Clothing, "ITM_EQU_Name_0217", "ITM_EQU_Info_0217", "itm_01_010173", 2, 135, 4, 161, 74, 0, 75, 0) },
            { 10218, new ClothingItem(10218, 218, ItemType.Clothing, "ITM_EQU_Name_0218", "ITM_EQU_Info_0218", "itm_01_010183", 2, 136, 4, 152, 27, 3, 15, 0) },
            { 10219, new ClothingItem(10219, 219, ItemType.Clothing, "ITM_EQU_Name_0219", "ITM_EQU_Info_0219", "itm_01_010193", 2, 137, 4, 200, 7, 7, 0, 7) },
            { 10300, new ClothingItem(10300, 300, ItemType.Clothing, "ITM_EQU_Name_0300", "ITM_EQU_Info_0300", "itm_01_020010", 3, 138, 0, 73, 111, 0, 8, 58) },
            { 10301, new ClothingItem(10301, 301, ItemType.Clothing, "ITM_EQU_Name_0301", "ITM_EQU_Info_0301", "itm_01_020020", 3, 139, 0, 18, 49, 0, 4, 15) },
            { 10302, new ClothingItem(10302, 302, ItemType.Clothing, "ITM_EQU_Name_0302", "ITM_EQU_Info_0302", "itm_01_020030", 3, 140, 0, 40, 92, 0, 10, 64) },
            { 10303, new ClothingItem(10303, 303, ItemType.Clothing, "ITM_EQU_Name_0303", "ITM_EQU_Info_0303", "itm_01_020040", 3, 141, 0, 19, 140, 0, 13, 88) },
            { 10304, new ClothingItem(10304, 304, ItemType.Clothing, "ITM_EQU_Name_0304", "ITM_EQU_Info_0304", "itm_01_020051", 3, 142, 1, 1, 24, 11, 0, 24) },
            { 10305, new ClothingItem(10305, 305, ItemType.Clothing, "ITM_EQU_Name_0305", "ITM_EQU_Info_0305", "itm_01_020061", 3, 143, 1, 138, 157, 46, 0, 115) },
            { 10306, new ClothingItem(10306, 306, ItemType.Clothing, "ITM_EQU_Name_0306", "ITM_EQU_Info_0306", "itm_01_020071", 3, 144, 1, 59, 123, 22, 0, 55) },
            { 10307, new ClothingItem(10307, 307, ItemType.Clothing, "ITM_EQU_Name_0307", "ITM_EQU_Info_0307", "itm_01_020081", 3, 145, 1, 2, 64, 37, 0, 93) },
            { 10308, new ClothingItem(10308, 308, ItemType.Clothing, "ITM_EQU_Name_0308", "ITM_EQU_Info_0308", "itm_01_020091", 3, 146, 1, 109, 94, 28, 0, 70) },
            { 10309, new ClothingItem(10309, 309, ItemType.Clothing, "ITM_EQU_Name_0309", "ITM_EQU_Info_0309", "itm_01_020101", 3, 147, 1, 85, 19, 14, 0, 35) },
            { 10310, new ClothingItem(10310, 310, ItemType.Clothing, "ITM_EQU_Name_0310", "ITM_EQU_Info_0310", "itm_01_020112", 3, 148, 2, 182, 82, 15, 0, 20) },
            { 10311, new ClothingItem(10311, 311, ItemType.Clothing, "ITM_EQU_Name_0311", "ITM_EQU_Info_0311", "itm_01_020122", 3, 149, 2, 191, 55, 55, 0, 72) },
            { 10312, new ClothingItem(10312, 312, ItemType.Clothing, "ITM_EQU_Name_0312", "ITM_EQU_Info_0312", "itm_01_020132", 3, 150, 2, 15, 150, 78, 0, 105) },
            { 10313, new ClothingItem(10313, 313, ItemType.Clothing, "ITM_EQU_Name_0313", "ITM_EQU_Info_0313", "itm_01_020142", 3, 151, 2, 179, 134, 65, 0, 86) },
            { 10314, new ClothingItem(10314, 314, ItemType.Clothing, "ITM_EQU_Name_0314", "ITM_EQU_Info_0314", "itm_01_020155", 3, 152, 3, 184, 110, 0, 8, 13) },
            { 10315, new ClothingItem(10315, 315, ItemType.Clothing, "ITM_EQU_Name_0315", "ITM_EQU_Info_0315", "itm_01_020165", 3, 153, 3, 50, 130, 0, 17, 28) },
            { 10316, new ClothingItem(10316, 316, ItemType.Clothing, "ITM_EQU_Name_0316", "ITM_EQU_Info_0316", "itm_01_020175", 3, 154, 3, 43, 130, 0, 30, 50) },
            { 10317, new ClothingItem(10317, 317, ItemType.Clothing, "ITM_EQU_Name_0317", "ITM_EQU_Info_0317", "itm_01_020185", 3, 155, 3, 125, 67, 0, 43, 61) },
            { 10318, new ClothingItem(10318, 318, ItemType.Clothing, "ITM_EQU_Name_0318", "ITM_EQU_Info_0318", "itm_01_020193", 3, 156, 4, 152, 27, 0, 5, 5) },
            { 10319, new ClothingItem(10319, 319, ItemType.Clothing, "ITM_EQU_Name_0319", "ITM_EQU_Info_0319", "itm_01_020203", 3, 157, 4, 155, 99, 0, 14, 28) },
            { 10320, new ClothingItem(10320, 320, ItemType.Clothing, "ITM_EQU_Name_0320", "ITM_EQU_Info_0320", "itm_01_020213", 3, 158, 4, 131, 123, 33, 0, 0) },
            { 10321, new ClothingItem(10321, 321, ItemType.Clothing, "ITM_EQU_Name_0321", "ITM_EQU_Info_0321", "itm_01_020223", 3, 159, 4, 99, 150, 71, 0, 0) },
            { 10400, new ClothingItem(10400, 400, ItemType.Clothing, "ITM_EQU_Name_0400", "ITM_EQU_Info_0400", "itm_01_030000", 4, 160, 0, 102, 31, 0, 2, 22) },
            { 10401, new ClothingItem(10401, 401, ItemType.Clothing, "ITM_EQU_Name_0401", "ITM_EQU_Info_0401", "itm_01_030010", 4, 161, 0, 105, 41, 0, 8, 68) },
            { 10402, new ClothingItem(10402, 402, ItemType.Clothing, "ITM_EQU_Name_0402", "ITM_EQU_Info_0402", "itm_01_030020", 4, 162, 0, 74, 133, 0, 4, 39) },
            { 10403, new ClothingItem(10403, 403, ItemType.Clothing, "ITM_EQU_Name_0403", "ITM_EQU_Info_0403", "itm_01_030030", 4, 163, 0, 140, 42, 0, 11, 86) },
            { 10404, new ClothingItem(10404, 404, ItemType.Clothing, "ITM_EQU_Name_0404", "ITM_EQU_Info_0404", "itm_01_030041", 4, 164, 1, 101, 163, 59, 0, 139) },
            { 10405, new ClothingItem(10405, 405, ItemType.Clothing, "ITM_EQU_Name_0405", "ITM_EQU_Info_0405", "itm_01_030051", 4, 165, 1, 193, 60, 8, 0, 30) },
            { 10406, new ClothingItem(10406, 406, ItemType.Clothing, "ITM_EQU_Name_0406", "ITM_EQU_Info_0406", "itm_01_030061", 4, 166, 1, 60, 148, 20, 0, 60) },
            { 10407, new ClothingItem(10407, 407, ItemType.Clothing, "ITM_EQU_Name_0407", "ITM_EQU_Info_0407", "itm_01_030071", 4, 167, 1, 85, 23, 10, 0, 30) },
            { 10408, new ClothingItem(10408, 408, ItemType.Clothing, "ITM_EQU_Name_0408", "ITM_EQU_Info_0408", "itm_01_030082", 4, 168, 2, 190, 40, 30, 0, 45) },
            { 10409, new ClothingItem(10409, 409, ItemType.Clothing, "ITM_EQU_Name_0409", "ITM_EQU_Info_0409", "itm_01_030092", 4, 169, 2, 178, 89, 50, 0, 60) },
            { 10410, new ClothingItem(10410, 410, ItemType.Clothing, "ITM_EQU_Name_0410", "ITM_EQU_Info_0410", "itm_01_030102", 4, 170, 2, 162, 29, 18, 0, 23) },
            { 10411, new ClothingItem(10411, 411, ItemType.Clothing, "ITM_EQU_Name_0411", "ITM_EQU_Info_0411", "itm_01_030112", 4, 171, 2, 191, 66, 48, 0, 68) },
            { 10412, new ClothingItem(10412, 412, ItemType.Clothing, "ITM_EQU_Name_0412", "ITM_EQU_Info_0412", "itm_01_030124", 4, 172, 5, 196, 222, 222, 0, 222) },
            { 10413, new ClothingItem(10413, 413, ItemType.Clothing, "ITM_EQU_Name_0413", "ITM_EQU_Info_0413", "itm_01_030134", 4, 173, 5, 2, 77, 78, 0, 78) },
            { 10414, new ClothingItem(10414, 414, ItemType.Clothing, "ITM_EQU_Name_0414", "ITM_EQU_Info_0414", "itm_01_030144", 4, 174, 5, 110, 174, 150, 0, 150) },
            { 10415, new ClothingItem(10415, 415, ItemType.Clothing, "ITM_EQU_Name_0415", "ITM_EQU_Info_0415", "itm_01_030155", 4, 175, 3, 48, 156, 0, 8, 15) },
            { 10416, new ClothingItem(10416, 416, ItemType.Clothing, "ITM_EQU_Name_0416", "ITM_EQU_Info_0416", "itm_01_030165", 4, 176, 3, 187, 121, 0, 13, 20) },
            { 10417, new ClothingItem(10417, 417, ItemType.Clothing, "ITM_EQU_Name_0417", "ITM_EQU_Info_0417", "itm_01_030175", 4, 177, 3, 55, 156, 0, 27, 48) },
            { 10418, new ClothingItem(10418, 418, ItemType.Clothing, "ITM_EQU_Name_0418", "ITM_EQU_Info_0418", "itm_01_030183", 4, 178, 4, 195, 77, 0, 80, 0) },
            { 10419, new ClothingItem(10419, 419, ItemType.Clothing, "ITM_EQU_Name_0419", "ITM_EQU_Info_0419", "itm_01_030193", 4, 179, 4, 135, 192, 0, 0, 44) },
            { 10420, new ClothingItem(10420, 420, ItemType.Clothing, "ITM_EQU_Name_0420", "ITM_EQU_Info_0420", "itm_01_030203", 4, 180, 4, 151, 99, 33, 0, 33) },
            { 10421, new ClothingItem(10421, 421, ItemType.Clothing, "ITM_EQU_Name_0421", "ITM_EQU_Info_0421", "itm_01_030213", 4, 181, 4, 150, 199, 0, 30, 30) },
            { 10500, new ClothingItem(10500, 500, ItemType.Clothing, "ITM_EQU_Name_0500", "ITM_EQU_Info_0500", "itm_01_040000", 5, 182, 0, 24, 50, 0, 4, 18) },
            { 10501, new ClothingItem(10501, 501, ItemType.Clothing, "ITM_EQU_Name_0501", "ITM_EQU_Info_0501", "itm_01_040010", 5, 183, 0, 199, 97, 0, 12, 73) },
            { 10502, new ClothingItem(10502, 502, ItemType.Clothing, "ITM_EQU_Name_0502", "ITM_EQU_Info_0502", "itm_01_040020", 5, 184, 0, 39, 101, 0, 5, 41) },
            { 10503, new ClothingItem(10503, 503, ItemType.Clothing, "ITM_EQU_Name_0503", "ITM_EQU_Info_0503", "itm_01_040030", 5, 185, 0, 75, 122, 0, 7, 39) },
            { 10504, new ClothingItem(10504, 504, ItemType.Clothing, "ITM_EQU_Name_0504", "ITM_EQU_Info_0504", "itm_01_040041", 5, 186, 1, 89, 50, 40, 0, 78) },
            { 10505, new ClothingItem(10505, 505, ItemType.Clothing, "ITM_EQU_Name_0505", "ITM_EQU_Info_0505", "itm_01_040051", 5, 187, 1, 107, 17, 12, 0, 25) },
            { 10506, new ClothingItem(10506, 506, ItemType.Clothing, "ITM_EQU_Name_0506", "ITM_EQU_Info_0506", "itm_01_040061", 5, 188, 1, 61, 135, 32, 0, 85) },
            { 10507, new ClothingItem(10507, 507, ItemType.Clothing, "ITM_EQU_Name_0507", "ITM_EQU_Info_0507", "itm_01_040072", 5, 189, 2, 171, 59, 16, 0, 20) },
            { 10508, new ClothingItem(10508, 508, ItemType.Clothing, "ITM_EQU_Name_0508", "ITM_EQU_Info_0508", "itm_01_040082", 5, 190, 2, 191, 61, 65, 0, 80) },
            { 10509, new ClothingItem(10509, 509, ItemType.Clothing, "ITM_EQU_Name_0509", "ITM_EQU_Info_0509", "itm_01_040094", 5, 191, 5, 5, 50, 135, 0, 135) },
            { 10510, new ClothingItem(10510, 510, ItemType.Clothing, "ITM_EQU_Name_0510", "ITM_EQU_Info_0510", "itm_01_040104", 5, 192, 5, 113, 145, 175, 0, 175) },
            { 10511, new ClothingItem(10511, 511, ItemType.Clothing, "ITM_EQU_Name_0511", "ITM_EQU_Info_0511", "itm_01_040114", 5, 193, 5, 26, 66, 115, 0, 115) },
            { 10512, new ClothingItem(10512, 512, ItemType.Clothing, "ITM_EQU_Name_0512", "ITM_EQU_Info_0512", "itm_01_040125", 5, 194, 3, 43, 143, 0, 8, 15) },
            { 10513, new ClothingItem(10513, 513, ItemType.Clothing, "ITM_EQU_Name_0513", "ITM_EQU_Info_0513", "itm_01_040135", 5, 195, 3, 185, 128, 0, 27, 39) },
            { 10514, new ClothingItem(10514, 514, ItemType.Clothing, "ITM_EQU_Name_0514", "ITM_EQU_Info_0514", "itm_01_040145", 5, 196, 3, 188, 133, 0, 20, 30) },
            { 10515, new ClothingItem(10515, 515, ItemType.Clothing, "ITM_EQU_Name_0515", "ITM_EQU_Info_0515", "itm_01_040153", 5, 197, 4, 148, 180, 0, 111, 0) },
            { 10516, new ClothingItem(10516, 516, ItemType.Clothing, "ITM_EQU_Name_0516", "ITM_EQU_Info_0516", "itm_01_040163", 5, 198, 4, 153, 98, 0, 22, 0) },
            { 10600, new ClothingItem(10600, 600, ItemType.Clothing, "ITM_EQU_Name_0600", "ITM_EQU_Info_0600", "itm_01_050000", 6, 199, 0, 140, 35, 0, 3, 17) },
            { 10601, new ClothingItem(10601, 601, ItemType.Clothing, "ITM_EQU_Name_0601", "ITM_EQU_Info_0601", "itm_01_050010", 6, 200, 0, 76, 111, 0, 7, 46) },
            { 10602, new ClothingItem(10602, 602, ItemType.Clothing, "ITM_EQU_Name_0602", "ITM_EQU_Info_0602", "itm_01_050020", 6, 201, 0, 197, 31, 0, 8, 54) },
            { 10603, new ClothingItem(10603, 603, ItemType.Clothing, "ITM_EQU_Name_0603", "ITM_EQU_Info_0603", "itm_01_050030", 6, 202, 1, 62, 123, 10, 0, 24) },
            { 10604, new ClothingItem(10604, 604, ItemType.Clothing, "ITM_EQU_Name_0604", "ITM_EQU_Info_0604", "itm_01_050041", 6, 203, 1, 86, 41, 35, 0, 88) },
            { 10605, new ClothingItem(10605, 605, ItemType.Clothing, "ITM_EQU_Name_0605", "ITM_EQU_Info_0605", "itm_01_050051", 6, 204, 1, 1, 24, 11, 0, 25) },
            { 10606, new ClothingItem(10606, 606, ItemType.Clothing, "ITM_EQU_Name_0606", "ITM_EQU_Info_0606", "itm_01_050061", 6, 205, 1, 9, 135, 43, 0, 108) },
            { 10607, new ClothingItem(10607, 607, ItemType.Clothing, "ITM_EQU_Name_0607", "ITM_EQU_Info_0607", "itm_01_050072", 6, 206, 2, 190, 33, 15, 0, 20) },
            { 10608, new ClothingItem(10608, 608, ItemType.Clothing, "ITM_EQU_Name_0608", "ITM_EQU_Info_0608", "itm_01_050082", 6, 207, 2, 170, 134, 66, 0, 85) },
            { 10609, new ClothingItem(10609, 609, ItemType.Clothing, "ITM_EQU_Name_0609", "ITM_EQU_Info_0609", "itm_01_050092", 6, 208, 2, 163, 54, 39, 0, 52) },
            { 10610, new ClothingItem(10610, 610, ItemType.Clothing, "ITM_EQU_Name_0610", "ITM_EQU_Info_0610", "itm_01_050102", 6, 209, 2, 176, 134, 69, 0, 92) },
            { 10611, new ClothingItem(10611, 611, ItemType.Clothing, "ITM_EQU_Name_0611", "ITM_EQU_Info_0611", "itm_01_050114", 6, 210, 5, 194, 70, 161, 0, 161) },
            { 10612, new ClothingItem(10612, 612, ItemType.Clothing, "ITM_EQU_Name_0612", "ITM_EQU_Info_0612", "itm_01_050124", 6, 211, 5, 26, 66, 143, 0, 143) },
            { 10613, new ClothingItem(10613, 613, ItemType.Clothing, "ITM_EQU_Name_0613", "ITM_EQU_Info_0613", "itm_01_050135", 6, 212, 3, 91, 35, 0, 8, 13) },
            { 10614, new ClothingItem(10614, 614, ItemType.Clothing, "ITM_EQU_Name_0614", "ITM_EQU_Info_0614", "itm_01_050145", 6, 213, 3, 188, 121, 0, 26, 44) },
            { 10615, new ClothingItem(10615, 615, ItemType.Clothing, "ITM_EQU_Name_0615", "ITM_EQU_Info_0615", "itm_01_050155", 6, 214, 3, 54, 130, 0, 20, 33) },
            { 10616, new ClothingItem(10616, 616, ItemType.Clothing, "ITM_EQU_Name_0616", "ITM_EQU_Info_0616", "itm_01_050165", 6, 215, 3, 185, 116, 0, 40, 66) },
            { 10617, new ClothingItem(10617, 617, ItemType.Clothing, "ITM_EQU_Name_0617", "ITM_EQU_Info_0617", "itm_01_050173", 6, 216, 4, 135, 160, 0, 20, 20) },
            { 10618, new ClothingItem(10618, 618, ItemType.Clothing, "ITM_EQU_Name_0618", "ITM_EQU_Info_0618", "itm_01_050183", 6, 217, 4, 155, 99, 0, 30, 30) },
            { 10619, new ClothingItem(10619, 619, ItemType.Clothing, "ITM_EQU_Name_0619", "ITM_EQU_Info_0619", "itm_01_050193", 6, 218, 4, 146, 170, 15, 0, 0) },
            { 10700, new ClothingItem(10700, 700, ItemType.Clothing, "ITM_EQU_Name_0700", "ITM_EQU_Info_0700", "itm_01_060000", 7, 219, 0, 77, 133, 0, 17, 58) },
            { 10701, new ClothingItem(10701, 701, ItemType.Clothing, "ITM_EQU_Name_0701", "ITM_EQU_Info_0701", "itm_01_060010", 7, 220, 0, 141, 150, 0, 15, 50) },
            { 10702, new ClothingItem(10702, 702, ItemType.Clothing, "ITM_EQU_Name_0702", "ITM_EQU_Info_0702", "itm_01_060020", 7, 221, 0, 102, 31, 0, 15, 120) },
            { 10703, new ClothingItem(10703, 703, ItemType.Clothing, "ITM_EQU_Name_0703", "ITM_EQU_Info_0703", "itm_01_060031", 7, 222, 1, 63, 148, 45, 0, 82) },
            { 10704, new ClothingItem(10704, 704, ItemType.Clothing, "ITM_EQU_Name_0704", "ITM_EQU_Info_0704", "itm_01_060041", 7, 223, 1, 90, 114, 65, 0, 135) },
            { 10705, new ClothingItem(10705, 705, ItemType.Clothing, "ITM_EQU_Name_0705", "ITM_EQU_Info_0705", "itm_01_060052", 7, 224, 2, 169, 89, 48, 0, 70) },
            { 10706, new ClothingItem(10706, 706, ItemType.Clothing, "ITM_EQU_Name_0706", "ITM_EQU_Info_0706", "itm_01_060062", 7, 225, 2, 164, 100, 100, 0, 120) },
            { 10707, new ClothingItem(10707, 707, ItemType.Clothing, "ITM_EQU_Name_0707", "ITM_EQU_Info_0707", "itm_01_060074", 7, 226, 5, 26, 66, 110, 0, 110) },
            { 10708, new ClothingItem(10708, 708, ItemType.Clothing, "ITM_EQU_Name_0708", "ITM_EQU_Info_0708", "itm_01_060084", 7, 227, 5, 139, 210, 210, 0, 210) },
            { 10709, new ClothingItem(10709, 709, ItemType.Clothing, "ITM_EQU_Name_0709", "ITM_EQU_Info_0709", "itm_01_060095", 7, 228, 3, 51, 156, 0, 37, 50) },
            { 10710, new ClothingItem(10710, 710, ItemType.Clothing, "ITM_EQU_Name_0710", "ITM_EQU_Info_0710", "itm_01_060105", 7, 229, 3, 45, 156, 0, 35, 55) },
            { 10711, new ClothingItem(10711, 711, ItemType.Clothing, "ITM_EQU_Name_0711", "ITM_EQU_Info_0711", "itm_01_060113", 7, 230, 4, 149, 199, 66, 66, 66) },
            { 10712, new ClothingItem(10712, 712, ItemType.Clothing, "ITM_EQU_Name_0712", "ITM_EQU_Info_0712", "itm_01_060123", 7, 231, 4, 35, 72, 33, 33, 33) },
            { 10713, new ClothingItem(10713, 713, ItemType.Clothing, "ITM_EQU_Name_0713", "ITM_EQU_Info_0713", "itm_01_060133", 7, 232, 4, 31, 37, 0, 46, 28) },
            { 10714, new ClothingItem(10714, 714, ItemType.Clothing, "ITM_EQU_Name_0714", "ITM_EQU_Info_0714", "itm_01_060143", 7, 233, 4, 32, 73, 0, 60, 35) },
            { 10715, new ClothingItem(10715, 715, ItemType.Clothing, "ITM_EQU_Name_0715", "ITM_EQU_Info_0715", "itm_01_060153", 7, 234, 4, 160, 65, 0, 0, 80) },
            { 10716, new ClothingItem(10716, 716, ItemType.Clothing, "ITM_EQU_Name_0716", "ITM_EQU_Info_0716", "itm_01_060163", 7, 235, 4, 144, 200, 85, 0, 0) },
            { 10800, new ClothingItem(10800, 800, ItemType.Clothing, "ITM_EQU_Name_0800", "ITM_EQU_Info_0800", "itm_01_070000", 8, 236, 0, 78, 111, 0, 3, 12) },
            { 10801, new ClothingItem(10801, 801, ItemType.Clothing, "ITM_EQU_Name_0801", "ITM_EQU_Info_0801", "itm_01_070010", 8, 237, 0, 198, 36, 0, 2, 10) },
            { 10802, new ClothingItem(10802, 802, ItemType.Clothing, "ITM_EQU_Name_0802", "ITM_EQU_Info_0802", "itm_01_070021", 8, 238, 1, 11, 20, 8, 0, 15) },
            { 10803, new ClothingItem(10803, 803, ItemType.Clothing, "ITM_EQU_Name_0803", "ITM_EQU_Info_0803", "itm_01_070031", 8, 239, 1, 108, 34, 20, 0, 48) },
            { 10804, new ClothingItem(10804, 804, ItemType.Clothing, "ITM_EQU_Name_0804", "ITM_EQU_Info_0804", "itm_01_070041", 8, 240, 1, 2, 64, 32, 0, 88) },
            { 10805, new ClothingItem(10805, 805, ItemType.Clothing, "ITM_EQU_Name_0805", "ITM_EQU_Info_0805", "itm_01_070051", 8, 241, 1, 64, 123, 12, 0, 18) },
            { 10806, new ClothingItem(10806, 806, ItemType.Clothing, "ITM_EQU_Name_0806", "ITM_EQU_Info_0806", "itm_01_070061", 8, 242, 1, 137, 137, 30, 0, 81) },
            { 10807, new ClothingItem(10807, 807, ItemType.Clothing, "ITM_EQU_Name_0807", "ITM_EQU_Info_0807", "itm_01_070072", 8, 243, 2, 181, 82, 12, 0, 18) },
            { 10808, new ClothingItem(10808, 808, ItemType.Clothing, "ITM_EQU_Name_0808", "ITM_EQU_Info_0808", "itm_01_070082", 8, 244, 2, 177, 54, 31, 0, 48) },
            { 10809, new ClothingItem(10809, 809, ItemType.Clothing, "ITM_EQU_Name_0809", "ITM_EQU_Info_0809", "itm_01_070092", 8, 245, 2, 174, 54, 20, 0, 31) },
            { 10810, new ClothingItem(10810, 810, ItemType.Clothing, "ITM_EQU_Name_0810", "ITM_EQU_Info_0810", "itm_01_070102", 8, 246, 2, 190, 33, 27, 0, 42) },
            { 10811, new ClothingItem(10811, 811, ItemType.Clothing, "ITM_EQU_Name_0811", "ITM_EQU_Info_0811", "itm_01_070114", 8, 247, 5, 95, 15, 35, 0, 35) },
            { 10812, new ClothingItem(10812, 812, ItemType.Clothing, "ITM_EQU_Name_0812", "ITM_EQU_Info_0812", "itm_01_070125", 8, 248, 3, 46, 130, 0, 7, 9) },
            { 10813, new ClothingItem(10813, 813, ItemType.Clothing, "ITM_EQU_Name_0813", "ITM_EQU_Info_0813", "itm_01_070135", 8, 249, 3, 187, 101, 0, 6, 10) },
            { 10814, new ClothingItem(10814, 814, ItemType.Clothing, "ITM_EQU_Name_0814", "ITM_EQU_Info_0814", "itm_01_070143", 8, 250, 4, 35, 60, 52, 0, 0) },
            { 10815, new ClothingItem(10815, 815, ItemType.Clothing, "ITM_EQU_Name_0815", "ITM_EQU_Info_0815", "itm_01_070153", 8, 251, 4, 145, 170, 0, 0, 50) },
            { 10900, new ClothingItem(10900, 900, ItemType.Clothing, "ITM_EQU_Name_0900", "ITM_EQU_Info_0900", "itm_01_080000", 9, 252, 0, 41, 92, 0, 8, 54) },
            { 10901, new ClothingItem(10901, 901, ItemType.Clothing, "ITM_EQU_Name_0901", "ITM_EQU_Info_0901", "itm_01_080010", 9, 253, 0, 79, 111, 0, 7, 42) },
            { 10902, new ClothingItem(10902, 902, ItemType.Clothing, "ITM_EQU_Name_0902", "ITM_EQU_Info_0902", "itm_01_080021", 9, 254, 1, 109, 94, 40, 0, 90) },
            { 10903, new ClothingItem(10903, 903, ItemType.Clothing, "ITM_EQU_Name_0903", "ITM_EQU_Info_0903", "itm_01_080031", 9, 255, 1, 65, 123, 25, 0, 60) },
            { 10904, new ClothingItem(10904, 904, ItemType.Clothing, "ITM_EQU_Name_0904", "ITM_EQU_Info_0904", "itm_01_080041", 9, 256, 1, 137, 137, 31, 0, 78) },
            { 10905, new ClothingItem(10905, 905, ItemType.Clothing, "ITM_EQU_Name_0905", "ITM_EQU_Info_0905", "itm_01_080051", 9, 257, 1, 109, 94, 15, 0, 30) },
            { 10906, new ClothingItem(10906, 906, ItemType.Clothing, "ITM_EQU_Name_0906", "ITM_EQU_Info_0906", "itm_01_080061", 9, 258, 1, 87, 86, 44, 0, 110) },
            { 10907, new ClothingItem(10907, 907, ItemType.Clothing, "ITM_EQU_Name_0907", "ITM_EQU_Info_0907", "itm_01_080071", 9, 259, 1, 3, 124, 45, 0, 113) },
            { 10908, new ClothingItem(10908, 908, ItemType.Clothing, "ITM_EQU_Name_0908", "ITM_EQU_Info_0908", "itm_01_080082", 9, 260, 2, 194, 70, 35, 0, 45) },
            { 10909, new ClothingItem(10909, 909, ItemType.Clothing, "ITM_EQU_Name_0909", "ITM_EQU_Info_0909", "itm_01_080092", 9, 261, 2, 103, 79, 38, 0, 53) },
            { 10910, new ClothingItem(10910, 910, ItemType.Clothing, "ITM_EQU_Name_0910", "ITM_EQU_Info_0910", "itm_01_080102", 9, 262, 2, 191, 55, 55, 0, 73) },
            { 10911, new ClothingItem(10911, 911, ItemType.Clothing, "ITM_EQU_Name_0911", "ITM_EQU_Info_0911", "itm_01_080112", 9, 263, 2, 167, 64, 62, 0, 82) },
            { 10912, new ClothingItem(10912, 912, ItemType.Clothing, "ITM_EQU_Name_0912", "ITM_EQU_Info_0912", "itm_01_080125", 9, 264, 3, 186, 30, 0, 15, 22) },
            { 10913, new ClothingItem(10913, 913, ItemType.Clothing, "ITM_EQU_Name_0913", "ITM_EQU_Info_0913", "itm_01_080135", 9, 265, 3, 50, 130, 0, 27, 45) },
            { 10914, new ClothingItem(10914, 914, ItemType.Clothing, "ITM_EQU_Name_0914", "ITM_EQU_Info_0914", "itm_01_080145", 9, 266, 3, 183, 31, 0, 34, 56) },
            { 10915, new ClothingItem(10915, 915, ItemType.Clothing, "ITM_EQU_Name_0915", "ITM_EQU_Info_0915", "itm_01_080155", 9, 267, 3, 100, 150, 0, 42, 64) },
            { 10916, new ClothingItem(10916, 916, ItemType.Clothing, "ITM_EQU_Name_0916", "ITM_EQU_Info_0916", "itm_01_080163", 9, 268, 4, 132, 222, 13, 0, 0) },
            { 10917, new ClothingItem(10917, 917, ItemType.Clothing, "ITM_EQU_Name_0917", "ITM_EQU_Info_0917", "itm_01_080173", 9, 269, 4, 25, 80, 69, 0, 0) },
            { 11000, new ClothingItem(11000, 1000, ItemType.Clothing, "ITM_EQU_Name_1000", "ITM_EQU_Info_1000", "itm_01_090000", 10, 270, 0, 122, 70, 0, 8, 56) },
            { 11001, new ClothingItem(11001, 1001, ItemType.Clothing, "ITM_EQU_Name_1001", "ITM_EQU_Info_1001", "itm_01_090010", 10, 271, 0, 80, 111, 0, 5, 33) },
            { 11002, new ClothingItem(11002, 1002, ItemType.Clothing, "ITM_EQU_Name_1002", "ITM_EQU_Info_1002", "itm_01_090021", 10, 272, 1, 136, 97, 19, 0, 48) },
            { 11003, new ClothingItem(11003, 1003, ItemType.Clothing, "ITM_EQU_Name_1003", "ITM_EQU_Info_1003", "itm_01_090031", 10, 273, 1, 66, 123, 46, 0, 115) },
            { 11004, new ClothingItem(11004, 1004, ItemType.Clothing, "ITM_EQU_Name_1004", "ITM_EQU_Info_1004", "itm_01_090041", 10, 274, 1, 14, 125, 35, 0, 88) },
            { 11005, new ClothingItem(11005, 1005, ItemType.Clothing, "ITM_EQU_Name_1005", "ITM_EQU_Info_1005", "itm_01_090051", 10, 275, 1, 109, 94, 39, 0, 98) },
            { 11006, new ClothingItem(11006, 1006, ItemType.Clothing, "ITM_EQU_Name_1006", "ITM_EQU_Info_1006", "itm_01_090062", 10, 276, 2, 168, 54, 59, 0, 77) },
            { 11007, new ClothingItem(11007, 1007, ItemType.Clothing, "ITM_EQU_Name_1007", "ITM_EQU_Info_1007", "itm_01_090072", 10, 277, 2, 191, 55, 80, 0, 106) },
            { 11008, new ClothingItem(11008, 1008, ItemType.Clothing, "ITM_EQU_Name_1008", "ITM_EQU_Info_1008", "itm_01_090082", 10, 278, 2, 190, 33, 29, 0, 38) },
            { 11009, new ClothingItem(11009, 1009, ItemType.Clothing, "ITM_EQU_Name_1009", "ITM_EQU_Info_1009", "itm_01_090094", 10, 279, 5, 115, 85, 146, 0, 146) },
            { 11010, new ClothingItem(11010, 1010, ItemType.Clothing, "ITM_EQU_Name_1010", "ITM_EQU_Info_1010", "itm_01_090105", 10, 280, 3, 56, 130, 0, 24, 40) },
            { 11011, new ClothingItem(11011, 1011, ItemType.Clothing, "ITM_EQU_Name_1011", "ITM_EQU_Info_1011", "itm_01_090115", 10, 281, 3, 49, 130, 0, 29, 49) },
            { 11012, new ClothingItem(11012, 1012, ItemType.Clothing, "ITM_EQU_Name_1012", "ITM_EQU_Info_1012", "itm_01_090125", 10, 282, 3, 186, 30, 0, 32, 54) },
            { 11013, new ClothingItem(11013, 1013, ItemType.Clothing, "ITM_EQU_Name_1013", "ITM_EQU_Info_1013", "itm_01_090133", 10, 283, 4, 98, 115, 0, 32, 16) },
            { 11014, new ClothingItem(11014, 1014, ItemType.Clothing, "ITM_EQU_Name_1014", "ITM_EQU_Info_1014", "itm_01_090143", 10, 284, 4, 23, 105, 22, 36, 0) },
            { 11015, new ClothingItem(11015, 1015, ItemType.Clothing, "ITM_EQU_Name_1015", "ITM_EQU_Info_1015", "itm_01_090153", 10, 285, 4, 143, 170, 66, 0, 0) },
            { 11016, new ClothingItem(11016, 1016, ItemType.Clothing, "ITM_EQU_Name_1016", "ITM_EQU_Info_1016", "itm_01_090163", 10, 286, 4, 130, 33, 0, 0, 30) },
            { 11100, new ClothingItem(11100, 1100, ItemType.Clothing, "ITM_EQU_Name_1100", "ITM_EQU_Info_1100", "itm_01_100000", 11, 287, 0, 141, 125, 0, 9, 55) },
            { 11101, new ClothingItem(11101, 1101, ItemType.Clothing, "ITM_EQU_Name_1101", "ITM_EQU_Info_1101", "itm_01_100010", 11, 288, 0, 81, 111, 0, 4, 21) },
            { 11102, new ClothingItem(11102, 1102, ItemType.Clothing, "ITM_EQU_Name_1102", "ITM_EQU_Info_1102", "itm_01_100021", 11, 289, 1, 108, 34, 20, 0, 30) },
            { 11103, new ClothingItem(11103, 1103, ItemType.Clothing, "ITM_EQU_Name_1103", "ITM_EQU_Info_1103", "itm_01_100031", 11, 290, 1, 1, 24, 27, 0, 60) },
            { 11104, new ClothingItem(11104, 1104, ItemType.Clothing, "ITM_EQU_Name_1104", "ITM_EQU_Info_1104", "itm_01_100041", 11, 291, 1, 12, 70, 30, 0, 83) },
            { 11105, new ClothingItem(11105, 1105, ItemType.Clothing, "ITM_EQU_Name_1105", "ITM_EQU_Info_1105", "itm_01_100051", 11, 292, 1, 6, 135, 35, 0, 80) },
            { 11106, new ClothingItem(11106, 1106, ItemType.Clothing, "ITM_EQU_Name_1106", "ITM_EQU_Info_1106", "itm_01_100061", 11, 293, 1, 112, 95, 22, 0, 63) },
            { 11107, new ClothingItem(11107, 1107, ItemType.Clothing, "ITM_EQU_Name_1107", "ITM_EQU_Info_1107", "itm_01_100071", 11, 294, 1, 67, 123, 15, 0, 33) },
            { 11108, new ClothingItem(11108, 1108, ItemType.Clothing, "ITM_EQU_Name_1108", "ITM_EQU_Info_1108", "itm_01_100082", 11, 295, 2, 190, 33, 47, 0, 60) },
            { 11109, new ClothingItem(11109, 1109, ItemType.Clothing, "ITM_EQU_Name_1109", "ITM_EQU_Info_1109", "itm_01_100092", 11, 296, 2, 172, 74, 52, 0, 63) },
            { 11110, new ClothingItem(11110, 1110, ItemType.Clothing, "ITM_EQU_Name_1110", "ITM_EQU_Info_1110", "itm_01_100102", 11, 297, 2, 182, 82, 54, 0, 72) },
            { 11111, new ClothingItem(11111, 1111, ItemType.Clothing, "ITM_EQU_Name_1111", "ITM_EQU_Info_1111", "itm_01_100112", 11, 298, 5, 13, 95, 145, 0, 145) },
            { 11112, new ClothingItem(11112, 1112, ItemType.Clothing, "ITM_EQU_Name_1112", "ITM_EQU_Info_1112", "itm_01_100124", 11, 299, 5, 2, 64, 70, 0, 70) },
            { 11113, new ClothingItem(11113, 1113, ItemType.Clothing, "ITM_EQU_Name_1113", "ITM_EQU_Info_1113", "itm_01_100134", 11, 300, 5, 110, 145, 120, 0, 120) },
            { 11114, new ClothingItem(11114, 1114, ItemType.Clothing, "ITM_EQU_Name_1114", "ITM_EQU_Info_1114", "itm_01_100144", 11, 301, 5, 110, 145, 180, 0, 180) },
            { 11115, new ClothingItem(11115, 1115, ItemType.Clothing, "ITM_EQU_Name_1115", "ITM_EQU_Info_1115", "itm_01_100155", 11, 302, 3, 44, 130, 0, 10, 18) },
            { 11116, new ClothingItem(11116, 1116, ItemType.Clothing, "ITM_EQU_Name_1116", "ITM_EQU_Info_1116", "itm_01_100165", 11, 303, 3, 184, 110, 0, 20, 32) },
            { 11117, new ClothingItem(11117, 1117, ItemType.Clothing, "ITM_EQU_Name_1117", "ITM_EQU_Info_1117", "itm_01_100175", 11, 304, 3, 183, 31, 0, 30, 43) },
            { 11118, new ClothingItem(11118, 1118, ItemType.Clothing, "ITM_EQU_Name_1118", "ITM_EQU_Info_1118", "itm_01_100183", 11, 305, 4, 130, 33, 0, 0, 21) },
            { 11119, new ClothingItem(11119, 1119, ItemType.Clothing, "ITM_EQU_Name_1119", "ITM_EQU_Info_1119", "itm_01_100193", 11, 306, 4, 159, 24, 0, 0, 64) },
            { 11200, new ClothingItem(11200, 1200, ItemType.Clothing, "ITM_EQU_Name_1200", "ITM_EQU_Info_1200", "itm_01_110000", 12, 307, 0, 197, 31, 0, 3, 12) },
            { 11201, new ClothingItem(11201, 1201, ItemType.Clothing, "ITM_EQU_Name_1201", "ITM_EQU_Info_1201", "itm_01_110010", 12, 308, 0, 82, 111, 0, 4, 11) },
            { 11202, new ClothingItem(11202, 1202, ItemType.Clothing, "ITM_EQU_Name_1202", "ITM_EQU_Info_1202", "itm_01_110020", 12, 309, 0, 142, 150, 0, 12, 81) },
            { 11203, new ClothingItem(11203, 1203, ItemType.Clothing, "ITM_EQU_Name_1203", "ITM_EQU_Info_1203", "itm_01_110030", 12, 310, 0, 104, 20, 0, 4, 17) },
            { 11204, new ClothingItem(11204, 1204, ItemType.Clothing, "ITM_EQU_Name_1204", "ITM_EQU_Info_1204", "itm_01_110041", 12, 311, 1, 117, 95, 32, 0, 68) },
            { 11205, new ClothingItem(11205, 1205, ItemType.Clothing, "ITM_EQU_Name_1205", "ITM_EQU_Info_1205", "itm_01_110051", 12, 312, 1, 107, 15, 10, 0, 19) },
            { 11206, new ClothingItem(11206, 1206, ItemType.Clothing, "ITM_EQU_Name_1206", "ITM_EQU_Info_1206", "itm_01_110061", 12, 313, 1, 68, 123, 31, 0, 78) },
            { 11207, new ClothingItem(11207, 1207, ItemType.Clothing, "ITM_EQU_Name_1207", "ITM_EQU_Info_1207", "itm_01_110071", 12, 314, 1, 92, 45, 28, 0, 63) },
            { 11208, new ClothingItem(11208, 1208, ItemType.Clothing, "ITM_EQU_Name_1208", "ITM_EQU_Info_1208", "itm_01_110081", 12, 315, 1, 86, 41, 28, 0, 70) },
            { 11209, new ClothingItem(11209, 1209, ItemType.Clothing, "ITM_EQU_Name_1209", "ITM_EQU_Info_1209", "itm_01_110091", 12, 316, 1, 93, 95, 48, 0, 108) },
            { 11210, new ClothingItem(11210, 1210, ItemType.Clothing, "ITM_EQU_Name_1210", "ITM_EQU_Info_1210", "itm_01_110102", 12, 317, 2, 168, 54, 40, 0, 52) },
            { 11211, new ClothingItem(11211, 1211, ItemType.Clothing, "ITM_EQU_Name_1211", "ITM_EQU_Info_1211", "itm_01_110112", 12, 318, 2, 166, 54, 54, 0, 70) },
            { 11212, new ClothingItem(11212, 1212, ItemType.Clothing, "ITM_EQU_Name_1212", "ITM_EQU_Info_1212", "itm_01_110122", 12, 319, 2, 123, 150, 84, 0, 104) },
            { 11213, new ClothingItem(11213, 1213, ItemType.Clothing, "ITM_EQU_Name_1213", "ITM_EQU_Info_1213", "itm_01_110132", 12, 320, 2, 193, 50, 16, 0, 19) },
            { 11214, new ClothingItem(11214, 1214, ItemType.Clothing, "ITM_EQU_Name_1214", "ITM_EQU_Info_1214", "itm_01_110144", 12, 321, 5, 97, 80, 145, 0, 145) },
            { 11215, new ClothingItem(11215, 1215, ItemType.Clothing, "ITM_EQU_Name_1215", "ITM_EQU_Info_1215", "itm_01_110155", 12, 322, 3, 187, 101, 0, 20, 33) },
            { 11216, new ClothingItem(11216, 1216, ItemType.Clothing, "ITM_EQU_Name_1216", "ITM_EQU_Info_1216", "itm_01_110165", 12, 323, 3, 111, 65, 0, 6, 10) },
            { 11217, new ClothingItem(11217, 1217, ItemType.Clothing, "ITM_EQU_Name_1217", "ITM_EQU_Info_1217", "itm_01_110175", 12, 324, 3, 184, 110, 0, 22, 34) },
            { 11218, new ClothingItem(11218, 1218, ItemType.Clothing, "ITM_EQU_Name_1218", "ITM_EQU_Info_1218", "itm_01_110185", 12, 325, 3, 52, 130, 0, 33, 55) },
            { 11219, new ClothingItem(11219, 1219, ItemType.Clothing, "ITM_EQU_Name_1219", "ITM_EQU_Info_1219", "itm_01_110193", 12, 326, 4, 153, 89, 0, 9, 8) },
            { 11220, new ClothingItem(11220, 1220, ItemType.Clothing, "ITM_EQU_Name_1220", "ITM_EQU_Info_1220", "itm_01_110203", 12, 327, 4, 116, 65, 0, 6, 6) },
            { 11221, new ClothingItem(11221, 1221, ItemType.Clothing, "ITM_EQU_Name_1221", "ITM_EQU_Info_1221", "itm_01_110213", 12, 328, 4, 31, 31, 27, 0, 27) },
            { 11222, new ClothingItem(11222, 1222, ItemType.Clothing, "ITM_EQU_Name_1222", "ITM_EQU_Info_1222", "itm_01_110223", 12, 329, 4, 132, 222, 20, 38, 0) },
            { 11300, new ClothingItem(11300, 1300, ItemType.Clothing, "ITM_EQU_Name_1300", "ITM_EQU_Info_1300", "itm_01_120000", 13, 330, 0, 83, 111, 0, 7, 51) },
            { 11301, new ClothingItem(11301, 1301, ItemType.Clothing, "ITM_EQU_Name_1301", "ITM_EQU_Info_1301", "itm_01_120010", 13, 331, 0, 20, 24, 0, 3, 13) },
            { 11302, new ClothingItem(11302, 1302, ItemType.Clothing, "ITM_EQU_Name_1302", "ITM_EQU_Info_1302", "itm_01_120021", 13, 332, 1, 4, 20, 9, 0, 19) },
            { 11303, new ClothingItem(11303, 1303, ItemType.Clothing, "ITM_EQU_Name_1303", "ITM_EQU_Info_1303", "itm_01_120031", 13, 333, 1, 17, 137, 53, 0, 131) },
            { 11304, new ClothingItem(11304, 1304, ItemType.Clothing, "ITM_EQU_Name_1304", "ITM_EQU_Info_1304", "itm_01_120041", 13, 334, 1, 69, 123, 12, 0, 24) },
            { 11305, new ClothingItem(11305, 1305, ItemType.Clothing, "ITM_EQU_Name_1305", "ITM_EQU_Info_1305", "itm_01_120051", 13, 335, 1, 114, 60, 36, 0, 86) },
            { 11306, new ClothingItem(11306, 1306, ItemType.Clothing, "ITM_EQU_Name_1306", "ITM_EQU_Info_1306", "itm_01_120062", 13, 336, 2, 165, 24, 15, 0, 20) },
            { 11307, new ClothingItem(11307, 1307, ItemType.Clothing, "ITM_EQU_Name_1307", "ITM_EQU_Info_1307", "itm_01_120072", 13, 337, 2, 173, 134, 56, 0, 68) },
            { 11308, new ClothingItem(11308, 1308, ItemType.Clothing, "ITM_EQU_Name_1308", "ITM_EQU_Info_1308", "itm_01_120082", 13, 338, 2, 88, 35, 13, 0, 15) },
            { 11309, new ClothingItem(11309, 1309, ItemType.Clothing, "ITM_EQU_Name_1309", "ITM_EQU_Info_1309", "itm_01_120092", 13, 339, 2, 126, 157, 83, 0, 107) },
            { 11310, new ClothingItem(11310, 1310, ItemType.Clothing, "ITM_EQU_Name_1310", "ITM_EQU_Info_1310", "itm_01_120104", 13, 340, 5, 94, 85, 162, 0, 162) },
            { 11311, new ClothingItem(11311, 1311, ItemType.Clothing, "ITM_EQU_Name_1311", "ITM_EQU_Info_1311", "itm_01_120114", 13, 341, 5, 124, 150, 173, 0, 173) },
            { 11312, new ClothingItem(11312, 1312, ItemType.Clothing, "ITM_EQU_Name_1312", "ITM_EQU_Info_1312", "itm_01_120125", 13, 342, 3, 52, 130, 0, 20, 33) },
            { 11313, new ClothingItem(11313, 1313, ItemType.Clothing, "ITM_EQU_Name_1313", "ITM_EQU_Info_1313", "itm_01_120135", 13, 343, 3, 189, 141, 0, 41, 65) },
            { 11314, new ClothingItem(11314, 1314, ItemType.Clothing, "ITM_EQU_Name_1314", "ITM_EQU_Info_1314", "itm_01_120143", 13, 344, 4, 22, 41, 0, 0, 54) },
            { 11315, new ClothingItem(11315, 1315, ItemType.Clothing, "ITM_EQU_Name_1315", "ITM_EQU_Info_1315", "itm_01_120153", 13, 345, 4, 158, 22, 39, 0, 0) },
            { 11316, new ClothingItem(11316, 1316, ItemType.Clothing, "ITM_EQU_Name_1316", "ITM_EQU_Info_1316", "itm_01_120161", 13, 346, 1, 10, 145, 45, 0, 106) },
            { 11317, new ClothingItem(11317, 1317, ItemType.Clothing, "ITM_EQU_Name_1317", "ITM_EQU_Info_1317", "itm_01_120173", 13, 347, 4, 154, 100, 5, 10, 0) },
            { 11318, new ClothingItem(11318, 1318, ItemType.Clothing, "ITM_EQU_Name_1318", "ITM_EQU_Info_1318", "itm_01_120183", 13, 348, 4, 23, 105, 48, 0, 0) },
            { 11400, new ClothingItem(11400, 1400, ItemType.Clothing, "ITM_EQU_Name_1400", "ITM_EQU_Info_1400", "itm_01_130000", 14, 349, 0, 36, 92, 0, 3, 47) },
            { 11401, new ClothingItem(11401, 1401, ItemType.Clothing, "ITM_EQU_Name_1401", "ITM_EQU_Info_1401", "itm_01_130010", 14, 350, 0, 24, 45, 0, 11, 75) },
            { 11402, new ClothingItem(11402, 1402, ItemType.Clothing, "ITM_EQU_Name_1402", "ITM_EQU_Info_1402", "itm_01_130020", 14, 351, 0, 84, 111, 0, 4, 46) },
            { 11403, new ClothingItem(11403, 1403, ItemType.Clothing, "ITM_EQU_Name_1403", "ITM_EQU_Info_1403", "itm_01_130031", 14, 352, 1, 70, 123, 30, 0, 60) },
            { 11404, new ClothingItem(11404, 1404, ItemType.Clothing, "ITM_EQU_Name_1404", "ITM_EQU_Info_1404", "itm_01_130041", 14, 353, 1, 8, 70, 34, 0, 85) },
            { 11405, new ClothingItem(11405, 1405, ItemType.Clothing, "ITM_EQU_Name_1405", "ITM_EQU_Info_1405", "itm_01_130052", 14, 354, 2, 164, 84, 65, 0, 86) },
            { 11406, new ClothingItem(11406, 1406, ItemType.Clothing, "ITM_EQU_Name_1406", "ITM_EQU_Info_1406", "itm_01_130062", 14, 355, 2, 192, 66, 57, 0, 76) },
            { 11407, new ClothingItem(11407, 1407, ItemType.Clothing, "ITM_EQU_Name_1407", "ITM_EQU_Info_1407", "itm_01_130074", 14, 356, 5, 120, 45, 94, 0, 94) },
            { 11408, new ClothingItem(11408, 1408, ItemType.Clothing, "ITM_EQU_Name_1408", "ITM_EQU_Info_1408", "itm_01_130084", 14, 357, 5, 118, 130, 131, 0, 131) },
            { 11409, new ClothingItem(11409, 1409, ItemType.Clothing, "ITM_EQU_Name_1409", "ITM_EQU_Info_1409", "itm_01_130095", 14, 358, 3, 47, 130, 0, 25, 38) },
            { 11410, new ClothingItem(11410, 1410, ItemType.Clothing, "ITM_EQU_Name_1410", "ITM_EQU_Info_1410", "itm_01_130105", 14, 359, 3, 106, 99, 0, 35, 58) },
            { 11411, new ClothingItem(11411, 1411, ItemType.Clothing, "ITM_EQU_Name_1411", "ITM_EQU_Info_1411", "itm_01_130113", 14, 360, 4, 147, 170, 27, 27, 0) },
            { 11412, new ClothingItem(11412, 1412, ItemType.Clothing, "ITM_EQU_Name_1412", "ITM_EQU_Info_1412", "itm_01_130123", 14, 361, 4, 31, 31, 36, 0, 18) },
            { 11413, new ClothingItem(11413, 1413, ItemType.Clothing, "ITM_EQU_Name_1413", "ITM_EQU_Info_1413", "itm_01_130133", 14, 362, 4, 22, 41, 0, 222, 0) },
            { 11500, new ClothingItem(11500, 1500, ItemType.Clothing, "ITM_EQU_Name_1500", "ITM_EQU_Info_1500", "itm_01_140000", 15, 363, 0, 204, 122, 0, 20, 60) },
            { 11501, new ClothingItem(11501, 1501, ItemType.Clothing, "ITM_EQU_Name_1501", "ITM_EQU_Info_1501", "itm_01_140010", 15, 364, 0, 199, 97, 0, 25, 99) },
            { 11502, new ClothingItem(11502, 1502, ItemType.Clothing, "ITM_EQU_Name_1502", "ITM_EQU_Info_1502", "itm_01_140021", 15, 365, 1, 86, 45, 45, 0, 70) },
            { 11503, new ClothingItem(11503, 1503, ItemType.Clothing, "ITM_EQU_Name_1503", "ITM_EQU_Info_1503", "itm_01_140031", 15, 366, 1, 87, 95, 80, 0, 150) },
            { 11504, new ClothingItem(11504, 1504, ItemType.Clothing, "ITM_EQU_Name_1504", "ITM_EQU_Info_1504", "itm_01_140042", 15, 367, 2, 181, 90, 60, 0, 120) },
            { 11505, new ClothingItem(11505, 1505, ItemType.Clothing, "ITM_EQU_Name_1505", "ITM_EQU_Info_1505", "itm_01_140052", 15, 368, 2, 169, 81, 40, 0, 90) },
            { 11506, new ClothingItem(11506, 1506, ItemType.Clothing, "ITM_EQU_Name_1506", "ITM_EQU_Info_1506", "itm_01_140065", 15, 369, 3, 189, 155, 0, 40, 95) },
            { 11507, new ClothingItem(11507, 1507, ItemType.Clothing, "ITM_EQU_Name_1507", "ITM_EQU_Info_1507", "itm_01_140075", 15, 370, 3, 186, 33, 0, 50, 80) },
            { 11508, new ClothingItem(11508, 1508, ItemType.Clothing, "ITM_EQU_Name_1508", "ITM_EQU_Info_1508", "itm_01_140083", 15, 371, 4, 160, 59, 150, 0, 0) },
            { 10000, new ClothingItem(10000, 0, ItemType.Clothing, "ITM_EQU_Name_0000", "ITM_EQU_Info_0000", "itm_01_080180", 9, 372, 0, 142, 99, 0, 3, 22) },
            { 10001, new ClothingItem(10001, 1, ItemType.Clothing, "ITM_EQU_Name_0001", "ITM_EQU_Info_0001", "itm_01_080191", 9, 373, 1, 3, 77, 44, 0, 22) },
            { 10002, new ClothingItem(10002, 2, ItemType.Clothing, "ITM_EQU_Name_0002", "ITM_EQU_Info_0002", "itm_01_080202", 9, 374, 2, 191, 55, 55, 0, 22) },
            { 10003, new ClothingItem(10003, 3, ItemType.Clothing, "ITM_EQU_Name_0003", "ITM_EQU_Info_0003", "itm_01_080215", 9, 375, 3, 183, 22, 0, 11, 22) },
            { 10004, new ClothingItem(10004, 4, ItemType.Clothing, "ITM_EQU_Name_0004", "ITM_EQU_Info_0004", "itm_01_080223", 9, 376, 4, 110, 99, 33, 11, 0) },
            { 20000, new FoodItem(20000, 0, ItemType.Food, "ITM_FOD_Name_0000", "ITM_FOD_Info_0000", "itm_02_00000", 0, 0, 80, 0, 0, 1, 0, new byte[] { 0,2,2,2,1,3,0,0,0,0 }) },
            { 20001, new FoodItem(20001, 1, ItemType.Food, "ITM_FOD_Name_0001", "ITM_FOD_Info_0001", "itm_02_00001", 0, 1, 120, 0, 0, 2, 0, new byte[] { 2,0,0,3,2,0,2,0,0,0 }) },
            { 20002, new FoodItem(20002, 2, ItemType.Food, "ITM_FOD_Name_0002", "ITM_FOD_Info_0002", "itm_02_00002", 0, 2, 230, 2, 0, 2, 0, new byte[] { 0,1,1,0,2,2,3,0,0,0 }) },
            { 20003, new FoodItem(20003, 3, ItemType.Food, "ITM_FOD_Name_0003", "ITM_FOD_Info_0003", "itm_02_00003", 0, 3, 80, 0, 1, 0, 0, new byte[] { 0,2,2,1,1,3,0,0,0,0 }) },
            { 20004, new FoodItem(20004, 4, ItemType.Food, "ITM_FOD_Name_0004", "ITM_FOD_Info_0004", "itm_02_00004", 0, 4, 140, 0, 0, 0, 1, new byte[] { 0,3,3,1,0,0,0,0,0,0 }) },
            { 20005, new FoodItem(20005, 5, ItemType.Food, "ITM_FOD_Name_0005", "ITM_FOD_Info_0005", "itm_02_00005", 0, 5, 320, 4, 0, 0, 1, new byte[] { 0,3,2,2,0,1,2,0,0,0 }) },
            { 20006, new FoodItem(20006, 6, ItemType.Food, "ITM_FOD_Name_0006", "ITM_FOD_Info_0006", "itm_02_00006", 0, 6, 410, 8, 1, 0, 0, new byte[] { 2,2,2,0,2,0,0,0,0,0 }) },
            { 20007, new FoodItem(20007, 7, ItemType.Food, "ITM_FOD_Name_0007", "ITM_FOD_Info_0007", "itm_02_00007", 0, 7, 450, 8, 0, 2, 0, new byte[] { 0,2,1,0,1,0,3,0,0,0 }) },
            { 20008, new FoodItem(20008, 8, ItemType.Food, "ITM_FOD_Name_0008", "ITM_FOD_Info_0008", "itm_02_00008", 0, 8, 960, 10, 4, 0, 2, new byte[] { 2,2,3,1,3,0,0,0,0,0 }) },
            { 20100, new FoodItem(20100, 100, ItemType.Food, "ITM_FOD_Name_0100", "ITM_FOD_Info_0100", "itm_02_01000", 0, 9, 340, 4, 0, 1, 0, new byte[] { 0,0,0,2,2,0,0,0,0,0 }) },
            { 20101, new FoodItem(20101, 101, ItemType.Food, "ITM_FOD_Name_0101", "ITM_FOD_Info_0101", "itm_02_01001", 0, 10, 450, 6, 0, 2, 0, new byte[] { 1,0,0,3,3,2,1,0,0,0 }) },
            { 20102, new FoodItem(20102, 102, ItemType.Food, "ITM_FOD_Name_0102", "ITM_FOD_Info_0102", "itm_02_01002", 0, 11, 380, 4, 0, 2, 0, new byte[] { 0,2,3,0,0,3,0,0,0,0 }) },
            { 20103, new FoodItem(20103, 103, ItemType.Food, "ITM_FOD_Name_0103", "ITM_FOD_Info_0103", "itm_02_01003", 0, 12, 777, 8, 2, 2, 0, new byte[] { 1,1,2,3,3,2,0,0,0,0 }) },
            { 20104, new FoodItem(20104, 104, ItemType.Food, "ITM_FOD_Name_0104", "ITM_FOD_Info_0104", "itm_02_01004", 0, 13, 300, 6, 0, 0, 0, new byte[] { 3,0,0,3,2,0,2,0,0,0 }) },
            { 20105, new FoodItem(20105, 105, ItemType.Food, "ITM_FOD_Name_0105", "ITM_FOD_Info_0105", "itm_02_01005", 0, 14, 250, 0, 0, 2, 1, new byte[] { 3,0,1,2,2,0,3,0,0,0 }) },
            { 20106, new FoodItem(20106, 106, ItemType.Food, "ITM_FOD_Name_0106", "ITM_FOD_Info_0106", "itm_02_01006", 0, 15, 210, 0, 0, 2, 0, new byte[] { 0,0,0,2,1,0,2,0,0,0 }) },
            { 20200, new FoodItem(20200, 200, ItemType.Food, "ITM_FOD_Name_0200", "ITM_FOD_Info_0200", "itm_02_02000", 0, 16, 680, 9, 3, 0, 0, new byte[] { 0,1,0,1,3,2,0,0,0,0 }) },
            { 20201, new FoodItem(20201, 201, ItemType.Food, "ITM_FOD_Name_0201", "ITM_FOD_Info_0201", "itm_02_02001", 0, 17, 1000, 9, 3, 2, 1, new byte[] { 1,1,2,0,3,2,1,0,0,0 }) },
            { 20202, new FoodItem(20202, 202, ItemType.Food, "ITM_FOD_Name_0202", "ITM_FOD_Info_0202", "itm_02_02002", 0, 18, 720, 7, 4, 0, 0, new byte[] { 1,1,2,2,0,3,1,0,0,0 }) },
            { 20203, new FoodItem(20203, 203, ItemType.Food, "ITM_FOD_Name_0203", "ITM_FOD_Info_0203", "itm_02_02003", 0, 19, 760, 5, 4, 2, 0, new byte[] { 2,0,3,1,2,0,0,0,0,0 }) },
            { 20300, new FoodItem(20300, 300, ItemType.Food, "ITM_FOD_Name_0300", "ITM_FOD_Info_0300", "itm_02_03000", 0, 20, 900, 16, 3, 4, 0, new byte[] { 1,1,0,3,3,0,0,0,0,0 }) },
            { 20301, new FoodItem(20301, 301, ItemType.Food, "ITM_FOD_Name_0301", "ITM_FOD_Info_0301", "itm_02_03001", 0, 21, 800, 11, 3, 0, 0, new byte[] { 3,0,0,2,2,3,0,0,0,0 }) },
            { 20302, new FoodItem(20302, 302, ItemType.Food, "ITM_FOD_Name_0302", "ITM_FOD_Info_0302", "itm_02_03002", 0, 22, 500, 2, 2, 0, 3, new byte[] { 2,2,3,0,0,2,0,0,0,0 }) },
            { 20303, new FoodItem(20303, 303, ItemType.Food, "ITM_FOD_Name_0303", "ITM_FOD_Info_0303", "itm_02_03003", 0, 23, 700, 5, 2, 0, 5, new byte[] { 2,3,3,0,0,0,2,0,0,0 }) },
            { 20304, new FoodItem(20304, 304, ItemType.Food, "ITM_FOD_Name_0304", "ITM_FOD_Info_0304", "itm_02_03004", 0, 24, 960, 10, 0, 8, 0, new byte[] { 1,1,2,3,1,0,2,0,0,0 }) },
            { 20305, new FoodItem(20305, 305, ItemType.Food, "ITM_FOD_Name_0305", "ITM_FOD_Info_0305", "itm_02_03005", 0, 25, 1200, 28, 7, 4, 1, new byte[] { 1,1,1,3,1,1,1,0,0,0 }) },
            { 20400, new FoodItem(20400, 400, ItemType.Food, "ITM_FOD_Name_0400", "ITM_FOD_Info_0400", "itm_02_04000", 0, 26, 650, 6, 0, 3, 2, new byte[] { 0,2,0,2,1,0,2,0,0,0 }) },
            { 20401, new FoodItem(20401, 401, ItemType.Food, "ITM_FOD_Name_0401", "ITM_FOD_Info_0401", "itm_02_04001", 0, 27, 750, 4, 4, 0, 4, new byte[] { 2,3,2,0,0,0,3,0,0,0 }) },
            { 20402, new FoodItem(20402, 402, ItemType.Food, "ITM_FOD_Name_0402", "ITM_FOD_Info_0402", "itm_02_04002", 0, 28, 850, 7, 2, 0, 7, new byte[] { 0,3,0,0,1,2,3,0,0,0 }) },
            { 20403, new FoodItem(20403, 403, ItemType.Food, "ITM_FOD_Name_0403", "ITM_FOD_Info_0403", "itm_02_04003", 0, 29, 999, 9, 3, 0, 9, new byte[] { 1,3,3,1,1,2,2,0,0,0 }) },
            { 20500, new FoodItem(20500, 500, ItemType.Food, "ITM_FOD_Name_0500", "ITM_FOD_Info_0500", "itm_02_05000", 0, 30, 400, 4, 0, 1, 1, new byte[] { 0,3,0,1,0,2,3,0,0,0 }) },
            { 20501, new FoodItem(20501, 501, ItemType.Food, "ITM_FOD_Name_0501", "ITM_FOD_Info_0501", "itm_02_05001", 0, 31, 410, 2, 0, 1, 2, new byte[] { 0,2,2,0,0,0,2,0,0,0 }) },
            { 20502, new FoodItem(20502, 502, ItemType.Food, "ITM_FOD_Name_0502", "ITM_FOD_Info_0502", "itm_02_05002", 0, 32, 480, 2, 0, 2, 2, new byte[] { 2,3,1,1,2,0,3,0,0,0 }) },
            { 20503, new FoodItem(20503, 503, ItemType.Food, "ITM_FOD_Name_0503", "ITM_FOD_Info_0503", "itm_02_05003", 0, 33, 780, 4, 0, 3, 3, new byte[] { 1,3,3,0,1,2,2,0,0,0 }) },
            { 20504, new FoodItem(20504, 504, ItemType.Food, "ITM_FOD_Name_0504", "ITM_FOD_Info_0504", "itm_02_05004", 0, 34, 480, 2, 0, 1, 3, new byte[] { 0,2,0,1,0,3,3,0,0,0 }) },
            { 20600, new FoodItem(20600, 600, ItemType.Food, "ITM_FOD_Name_0600", "ITM_FOD_Info_0600", "itm_02_06000", 0, 35, 888, 3, 3, 3, 3, new byte[] { 2,0,2,3,3,2,1,0,0,0 }) },
            { 20601, new FoodItem(20601, 601, ItemType.Food, "ITM_FOD_Name_0601", "ITM_FOD_Info_0601", "itm_02_06001", 0, 36, 780, 12, 2, 0, 0, new byte[] { 3,2,3,2,3,0,0,0,0,0 }) },
            { 20602, new FoodItem(20602, 602, ItemType.Food, "ITM_FOD_Name_0602", "ITM_FOD_Info_0602", "itm_02_06002", 0, 37, 750, 12, 0, 0, 2, new byte[] { 2,0,3,2,3,1,0,0,0,0 }) },
            { 20603, new FoodItem(20603, 603, ItemType.Food, "ITM_FOD_Name_0603", "ITM_FOD_Info_0603", "itm_02_06003", 0, 38, 760, 12, 0, 2, 0, new byte[] { 0,2,3,0,2,0,0,0,0,0 }) },
            { 20604, new FoodItem(20604, 604, ItemType.Food, "ITM_FOD_Name_0604", "ITM_FOD_Info_0604", "itm_02_06004", 0, 39, 800, 12, 1, 1, 1, new byte[] { 0,2,3,0,0,0,1,0,0,0 }) },
            { 20700, new FoodItem(20700, 700, ItemType.Food, "ITM_FOD_Name_0700", "ITM_FOD_Info_0700", "itm_02_07000", 0, 40, 180, 4, 0, 0, 0, new byte[] { 3,0,2,2,1,2,0,0,0,0 }) },
            { 20701, new FoodItem(20701, 701, ItemType.Food, "ITM_FOD_Name_0701", "ITM_FOD_Info_0701", "itm_02_07001", 0, 41, 200, 5, 0, 0, 0, new byte[] { 3,0,0,3,2,2,2,0,0,0 }) },
            { 20702, new FoodItem(20702, 702, ItemType.Food, "ITM_FOD_Name_0702", "ITM_FOD_Info_0702", "itm_02_07002", 0, 42, 550, 7, 0, 2, 0, new byte[] { 0,0,0,3,2,2,1,0,0,0 }) },
            { 20703, new FoodItem(20703, 703, ItemType.Food, "ITM_FOD_Name_0703", "ITM_FOD_Info_0703", "itm_02_07003", 0, 43, 250, 4, 1, 0, 0, new byte[] { 0,0,0,3,3,2,2,0,0,0 }) },
            { 20704, new FoodItem(20704, 704, ItemType.Food, "ITM_FOD_Name_0704", "ITM_FOD_Info_0704", "itm_02_07004", 0, 44, 520, 2, 2, 1, 1, new byte[] { 3,0,2,2,2,3,1,0,0,0 }) },
            { 20705, new FoodItem(20705, 705, ItemType.Food, "ITM_FOD_Name_0705", "ITM_FOD_Info_0705", "itm_02_07005", 0, 45, 300, 3, 0, 1, 0, new byte[] { 0,0,0,3,3,0,0,0,0,0 }) },
            { 20800, new FoodItem(20800, 800, ItemType.Food, "ITM_FOD_Name_0800", "ITM_FOD_Info_0800", "itm_02_08000", 0, 46, 720, 12, 2, 0, 0, new byte[] { 0,1,2,0,3,3,0,0,0,0 }) },
            { 20801, new FoodItem(20801, 801, ItemType.Food, "ITM_FOD_Name_0801", "ITM_FOD_Info_0801", "itm_02_08001", 0, 47, 680, 12, 2, 1, 0, new byte[] { 2,0,2,3,1,0,1,0,0,0 }) },
            { 20802, new FoodItem(20802, 802, ItemType.Food, "ITM_FOD_Name_0802", "ITM_FOD_Info_0802", "itm_02_08002", 0, 48, 750, 12, 0, 3, 0, new byte[] { 1,3,3,0,1,2,0,0,0,0 }) },
            { 20803, new FoodItem(20803, 803, ItemType.Food, "ITM_FOD_Name_0803", "ITM_FOD_Info_0803", "itm_02_08003", 0, 49, 750, 12, 2, 0, 1, new byte[] { 2,0,3,0,2,3,0,0,0,0 }) },
            { 20804, new FoodItem(20804, 804, ItemType.Food, "ITM_FOD_Name_0804", "ITM_FOD_Info_0804", "itm_02_08004", 0, 50, 700, 9, 0, 2, 3, new byte[] { 0,3,3,0,2,0,2,0,0,0 }) },
            { 20805, new FoodItem(20805, 805, ItemType.Food, "ITM_FOD_Name_0805", "ITM_FOD_Info_0805", "itm_02_08005", 0, 51, 999, 10, 3, 3, 3, new byte[] { 1,1,0,3,3,2,1,0,0,0 }) },
            { 20900, new FoodItem(20900, 900, ItemType.Food, "ITM_FOD_Name_0900", "ITM_FOD_Info_0900", "itm_02_09000", 0, 52, 440, 4, 0, 3, 0, new byte[] { 2,3,2,0,1,1,0,0,0,0 }) },
            { 20901, new FoodItem(20901, 901, ItemType.Food, "ITM_FOD_Name_0901", "ITM_FOD_Info_0901", "itm_02_09001", 0, 53, 460, 3, 0, 4, 0, new byte[] { 1,3,0,0,1,2,2,0,0,0 }) },
            { 20902, new FoodItem(20902, 902, ItemType.Food, "ITM_FOD_Name_0902", "ITM_FOD_Info_0902", "itm_02_09002", 0, 54, 250, 4, 0, 2, 0, new byte[] { 3,0,2,1,0,2,0,0,0,0 }) },
            { 20903, new FoodItem(20903, 903, ItemType.Food, "ITM_FOD_Name_0903", "ITM_FOD_Info_0903", "itm_02_09003", 0, 55, 140, 0, 0, 1, 0, new byte[] { 1,3,2,3,1,0,1,0,0,0 }) },
            { 20904, new FoodItem(20904, 904, ItemType.Food, "ITM_FOD_Name_0904", "ITM_FOD_Info_0904", "itm_02_09004", 0, 56, 250, 0, 0, 2, 1, new byte[] { 0,2,3,2,1,0,1,0,0,0 }) },
            { 20905, new FoodItem(20905, 905, ItemType.Food, "ITM_FOD_Name_0905", "ITM_FOD_Info_0905", "itm_02_09005", 0, 57, 428, 0, 0, 0, 6, new byte[] { 0,0,3,0,3,0,0,0,0,0 }) },
            { 21000, new FoodItem(21000, 1000, ItemType.Food, "ITM_FOD_Name_1000", "ITM_FOD_Info_1000", "itm_02_10000", 0, 58, 350, 4, 0, 2, 0, new byte[] { 2,2,1,0,3,3,1,0,0,0 }) },
            { 21001, new FoodItem(21001, 1001, ItemType.Food, "ITM_FOD_Name_1001", "ITM_FOD_Info_1001", "itm_02_10001", 0, 59, 380, 2, 0, 3, 0, new byte[] { 2,2,2,3,2,0,2,0,0,0 }) },
            { 21002, new FoodItem(21002, 1002, ItemType.Food, "ITM_FOD_Name_1002", "ITM_FOD_Info_1002", "itm_02_10002", 0, 60, 400, 1, 3, 0, 1, new byte[] { 2,3,2,2,0,0,0,0,0,0 }) },
            { 21003, new FoodItem(21003, 1003, ItemType.Food, "ITM_FOD_Name_1003", "ITM_FOD_Info_1003", "itm_02_10003", 0, 61, 750, 0, 4, 0, 4, new byte[] { 2,3,0,1,0,0,2,0,0,0 }) },
            { 21004, new FoodItem(21004, 1004, ItemType.Food, "ITM_FOD_Name_1004", "ITM_FOD_Info_1004", "itm_02_10004", 0, 62, 400, 3, 3, 0, 0, new byte[] { 3,0,0,1,3,2,0,0,0,0 }) },
            { 21100, new FoodItem(21100, 1100, ItemType.Food, "ITM_FOD_Name_1100", "ITM_FOD_Info_1100", "itm_02_11000", 0, 63, 500, 4, 0, 3, 0, new byte[] { 2,0,0,0,1,2,3,0,0,0 }) },
            { 21101, new FoodItem(21101, 1101, ItemType.Food, "ITM_FOD_Name_1101", "ITM_FOD_Info_1101", "itm_02_11001", 0, 64, 450, 2, 0, 0, 4, new byte[] { 0,2,2,0,1,0,2,0,0,0 }) },
            { 21102, new FoodItem(21102, 1102, ItemType.Food, "ITM_FOD_Name_1102", "ITM_FOD_Info_1102", "itm_02_11002", 0, 65, 450, 4, 0, 0, 3, new byte[] { 0,3,2,2,0,0,3,0,0,0 }) },
            { 21103, new FoodItem(21103, 1103, ItemType.Food, "ITM_FOD_Name_1103", "ITM_FOD_Info_1103", "itm_02_11003", 0, 66, 550, 6, 3, 0, 0, new byte[] { 2,2,0,2,0,0,3,0,0,0 }) },
            { 21104, new FoodItem(21104, 1104, ItemType.Food, "ITM_FOD_Name_1104", "ITM_FOD_Info_1104", "itm_02_11004", 0, 67, 700, 2, 0, 5, 1, new byte[] { 1,3,2,3,1,0,2,0,0,0 }) },
            { 21200, new FoodItem(21200, 1200, ItemType.Food, "ITM_FOD_Name_1200", "ITM_FOD_Info_1200", "itm_02_12000", 0, 68, 300, 2, 1, 1, 0, new byte[] { 0,0,0,3,3,2,2,0,0,0 }) },
            { 21201, new FoodItem(21201, 1201, ItemType.Food, "ITM_FOD_Name_1201", "ITM_FOD_Info_1201", "itm_02_12001", 0, 69, 500, 5, 3, 0, 0, new byte[] { 1,3,2,1,0,0,0,0,0,0 }) },
            { 21202, new FoodItem(21202, 1202, ItemType.Food, "ITM_FOD_Name_1202", "ITM_FOD_Info_1202", "itm_02_12002", 0, 70, 400, 5, 2, 0, 0, new byte[] { 0,3,2,0,1,0,1,0,0,0 }) },
            { 21203, new FoodItem(21203, 1203, ItemType.Food, "ITM_FOD_Name_1203", "ITM_FOD_Info_1203", "itm_02_12003", 0, 71, 600, 6, 4, 0, 0, new byte[] { 0,2,3,2,1,0,1,0,0,0 }) },
            { 21300, new FoodItem(21300, 1300, ItemType.Food, "ITM_FOD_Name_1300", "ITM_FOD_Info_1300", "itm_02_13000", 0, 72, 680, 10, 1, 1, 0, new byte[] { 3,0,2,0,2,3,0,0,0,0 }) },
            { 21301, new FoodItem(21301, 1301, ItemType.Food, "ITM_FOD_Name_1301", "ITM_FOD_Info_1301", "itm_02_13001", 0, 73, 650, 7, 1, 0, 3, new byte[] { 0,3,3,0,1,2,0,0,0,0 }) },
            { 21302, new FoodItem(21302, 1302, ItemType.Food, "ITM_FOD_Name_1302", "ITM_FOD_Info_1302", "itm_02_13002", 0, 74, 700, 6, 2, 2, 0, new byte[] { 0,2,0,1,3,0,2,0,0,0 }) },
            { 21303, new FoodItem(21303, 1303, ItemType.Food, "ITM_FOD_Name_1303", "ITM_FOD_Info_1303", "itm_02_13003", 0, 75, 900, 0, 9, 0, 0, new byte[] { 2,3,2,1,2,2,0,0,0,0 }) },
            { 21400, new FoodItem(21400, 1400, ItemType.Food, "ITM_FOD_Name_1400", "ITM_FOD_Info_1400", "itm_02_14000", 0, 76, 120, 0, 0, 1, 0, new byte[] { 3,2,0,0,1,2,2,0,0,0 }) },
            { 21401, new FoodItem(21401, 1401, ItemType.Food, "ITM_FOD_Name_1401", "ITM_FOD_Info_1401", "itm_02_14001", 0, 77, 150, 0, 0, 1, 1, new byte[] { 0,3,0,0,0,1,3,0,0,0 }) },
            { 21402, new FoodItem(21402, 1402, ItemType.Food, "ITM_FOD_Name_1402", "ITM_FOD_Info_1402", "itm_02_14002", 0, 78, 220, 0, 1, 1, 0, new byte[] { 3,2,1,3,1,2,2,0,0,0 }) },
            { 21403, new FoodItem(21403, 1403, ItemType.Food, "ITM_FOD_Name_1403", "ITM_FOD_Info_1403", "itm_02_14003", 0, 79, 350, 0, 2, 1, 2, new byte[] { 0,2,1,3,0,1,3,0,0,0 }) },
            { 21500, new FoodItem(21500, 1500, ItemType.Food, "ITM_FOD_Name_1500", "ITM_FOD_Info_1500", "itm_02_15000", 0, 80, 680, 5, 2, 3, 0, new byte[] { 0,3,2,2,3,0,0,0,0,0 }) },
            { 21501, new FoodItem(21501, 1501, ItemType.Food, "ITM_FOD_Name_1501", "ITM_FOD_Info_1501", "itm_02_15001", 0, 81, 720, 6, 1, 4, 0, new byte[] { 2,3,3,1,2,0,0,0,0,0 }) },
            { 21502, new FoodItem(21502, 1502, ItemType.Food, "ITM_FOD_Name_1502", "ITM_FOD_Info_1502", "itm_02_15002", 0, 82, 800, 10, 2, 3, 0, new byte[] { 3,2,3,0,1,0,0,0,0,0 }) },
            { 21503, new FoodItem(21503, 1503, ItemType.Food, "ITM_FOD_Name_1503", "ITM_FOD_Info_1503", "itm_02_15003", 0, 83, 600, 7, 1, 2, 0, new byte[] { 2,2,0,2,0,2,3,0,0,0 }) },
            { 21504, new FoodItem(21504, 1504, ItemType.Food, "ITM_FOD_Name_1504", "ITM_FOD_Info_1504", "itm_02_15004", 0, 84, 500, 4, 1, 3, 0, new byte[] { 0,2,2,0,3,0,0,0,0,0 }) },
            { 21600, new FoodItem(21600, 1600, ItemType.Food, "ITM_FOD_Name_1600", "ITM_FOD_Info_1600", "itm_02_16000", 0, 85, 420, 3, 1, 0, 2, new byte[] { 3,0,0,1,2,3,3,0,0,0 }) },
            { 21601, new FoodItem(21601, 1601, ItemType.Food, "ITM_FOD_Name_1601", "ITM_FOD_Info_1601", "itm_02_16001", 0, 86, 600, 5, 0, 2, 2, new byte[] { 0,3,0,2,0,0,2,0,0,0 }) },
            { 21602, new FoodItem(21602, 1602, ItemType.Food, "ITM_FOD_Name_1602", "ITM_FOD_Info_1602", "itm_02_16002", 0, 87, 720, 6, 0, 2, 3, new byte[] { 0,3,3,2,0,0,2,0,0,0 }) },
            { 21603, new FoodItem(21603, 1603, ItemType.Food, "ITM_FOD_Name_1603", "ITM_FOD_Info_1603", "itm_02_16003", 0, 88, 450, 8, 0, 0, 1, new byte[] { 2,2,0,0,0,0,3,0,0,0 }) },
            { 21604, new FoodItem(21604, 1604, ItemType.Food, "ITM_FOD_Name_1604", "ITM_FOD_Info_1604", "itm_02_16004", 0, 89, 380, 5, 0, 1, 1, new byte[] { 1,3,2,0,1,0,2,0,0,0 }) },
            { 21700, new FoodItem(21700, 1700, ItemType.Food, "ITM_FOD_Name_1700", "ITM_FOD_Info_1700", "itm_02_17000", 0, 90, 600, 7, 0, 0, 3, new byte[] { 0,2,3,0,2,3,3,0,0,0 }) },
            { 21701, new FoodItem(21701, 1701, ItemType.Food, "ITM_FOD_Name_1701", "ITM_FOD_Info_1701", "itm_02_17001", 0, 91, 650, 2, 0, 4, 3, new byte[] { 0,3,0,2,1,0,3,0,0,0 }) },
            { 21702, new FoodItem(21702, 1702, ItemType.Food, "ITM_FOD_Name_1702", "ITM_FOD_Info_1702", "itm_02_17002", 0, 92, 650, 2, 0, 3, 4, new byte[] { 1,2,2,3,1,2,1,0,0,0 }) },
            { 21703, new FoodItem(21703, 1703, ItemType.Food, "ITM_FOD_Name_1703", "ITM_FOD_Info_1703", "itm_02_17003", 0, 93, 700, 5, 2, 0, 3, new byte[] { 2,3,2,0,0,0,2,0,0,0 }) },
            { 21704, new FoodItem(21704, 1704, ItemType.Food, "ITM_FOD_Name_1704", "ITM_FOD_Info_1704", "itm_02_17004", 0, 94, 900, 2, 0, 6, 3, new byte[] { 0,2,0,3,0,0,2,0,0,0 }) },
            { 31000, new BookItem(31000, 0, ItemType.Book, "ITM_BOK_Name_0000", "ITM_BOK_Info_0000", "itm_03_0004", 0, 801, -1, null, 0) },
            { 31001, new BookItem(31001, 1, ItemType.Book, "ITM_BOK_Name_0001", "ITM_BOK_Info_0000", "itm_03_0004", 0, 802, -1, null, 1) },
            { 31002, new BookItem(31002, 2, ItemType.Book, "ITM_BOK_Name_0002", "ITM_BOK_Info_0000", "itm_03_0004", 0, 803, -1, null, 2) },
            { 31003, new BookItem(31003, 3, ItemType.Book, "ITM_BOK_Name_0003", "ITM_BOK_Info_0000", "itm_03_0004", 0, 804, -1, null, 3) },
            { 31004, new BookItem(31004, 4, ItemType.Book, "ITM_BOK_Name_0004", "ITM_BOK_Info_0000", "itm_03_0004", 0, 805, -1, null, 4) },
            { 31005, new BookItem(31005, 5, ItemType.Book, "ITM_BOK_Name_0005", "ITM_BOK_Info_0000", "itm_03_0004", 0, 806, -1, null, 5) },
            { 31006, new BookItem(31006, 6, ItemType.Book, "ITM_BOK_Name_0006", "ITM_BOK_Info_0000", "itm_03_0004", 0, 807, -1, null, 6) },
            { 31007, new BookItem(31007, 7, ItemType.Book, "ITM_BOK_Name_0007", "ITM_BOK_Info_0000", "itm_03_0004", 0, 808, -1, null, 7) },
            { 31008, new BookItem(31008, 8, ItemType.Book, "ITM_BOK_Name_0008", "ITM_BOK_Info_0000", "itm_03_0004", 0, 809, -1, null, 8) },
            { 31009, new BookItem(31009, 9, ItemType.Book, "ITM_BOK_Name_0009", "ITM_BOK_Info_0000", "itm_03_0004", 0, 810, -1, null, 9) },
            { 31010, new BookItem(31010, 10, ItemType.Book, "ITM_BOK_Name_0010", "ITM_BOK_Info_0000", "itm_03_0004", 0, 811, -1, null, 10) },
            { 31011, new BookItem(31011, 11, ItemType.Book, "ITM_BOK_Name_0011", "ITM_BOK_Info_0000", "itm_03_0004", 0, 812, -1, null, 11) },
            { 31012, new BookItem(31012, 12, ItemType.Book, "ITM_BOK_Name_0012", "ITM_BOK_Info_0000", "itm_03_0004", 0, 813, -1, null, 12) },
            { 31013, new BookItem(31013, 13, ItemType.Book, "ITM_BOK_Name_0013", "ITM_BOK_Info_0000", "itm_03_0004", 0, 814, -1, null, 13) },
            { 31014, new BookItem(31014, 14, ItemType.Book, "ITM_BOK_Name_0014", "ITM_BOK_Info_0000", "itm_03_0004", 0, 815, -1, null, 14) },
            { 31015, new BookItem(31015, 15, ItemType.Book, "ITM_BOK_Name_0015", "ITM_BOK_Info_0000", "itm_03_0004", 0, 816, -1, null, 15) },
            { 31016, new BookItem(31016, 16, ItemType.Book, "ITM_BOK_Name_0016", "ITM_BOK_Info_0000", "itm_03_0004", 0, 817, -1, null, 16) },
            { 31017, new BookItem(31017, 17, ItemType.Book, "ITM_BOK_Name_0017", "ITM_BOK_Info_0000", "itm_03_0004", 0, 818, -1, null, 17) },
            { 31018, new BookItem(31018, 18, ItemType.Book, "ITM_BOK_Name_0018", "ITM_BOK_Info_0000", "itm_03_0004", 0, 819, -1, null, 18) },
            { 31019, new BookItem(31019, 19, ItemType.Book, "ITM_BOK_Name_0019", "ITM_BOK_Info_0000", "itm_03_0004", 0, 820, -1, null, 19) },
            { 31020, new BookItem(31020, 20, ItemType.Book, "ITM_BOK_Name_0020", "ITM_BOK_Info_0000", "itm_03_0004", 0, 821, -1, null, 20) },
            { 31021, new BookItem(31021, 21, ItemType.Book, "ITM_BOK_Name_0021", "ITM_BOK_Info_0000", "itm_03_0004", 0, 822, -1, null, 21) },
            { 31022, new BookItem(31022, 22, ItemType.Book, "ITM_BOK_Name_0022", "ITM_BOK_Info_0000", "itm_03_0004", 0, 823, -1, null, 22) },
            { 31023, new BookItem(31023, 23, ItemType.Book, "ITM_BOK_Name_0023", "ITM_BOK_Info_0000", "itm_03_0004", 0, 824, -1, null, 23) },
            { 31100, new BookItem(31100, 100, ItemType.Book, "ITM_BOK_Name_0100", "ITM_BOK_Info_0100", "itm_03_0000", 0, 825, 0, null, -1) },
            { 31101, new BookItem(31101, 101, ItemType.Book, "ITM_BOK_Name_0101", "ITM_BOK_Info_0113", "itm_03_0000", 0, 826, 13, null, -1) },
            { 31102, new BookItem(31102, 102, ItemType.Book, "ITM_BOK_Name_0102", "ITM_BOK_Info_0101", "itm_03_0000", 0, 827, 1, null, -1) },
            { 31103, new BookItem(31103, 103, ItemType.Book, "ITM_BOK_Name_0103", "ITM_BOK_Info_0102", "itm_03_0000", 0, 828, 2, null, -1) },
            { 31104, new BookItem(31104, 104, ItemType.Book, "ITM_BOK_Name_0104", "ITM_BOK_Info_0103", "itm_03_0000", 0, 829, 3, null, -1) },
            { 31105, new BookItem(31105, 105, ItemType.Book, "ITM_BOK_Name_0105", "ITM_BOK_Info_0104", "itm_03_0000", 0, 830, 4, null, -1) },
            { 31106, new BookItem(31106, 106, ItemType.Book, "ITM_BOK_Name_0106", "ITM_BOK_Info_0105", "itm_03_0000", 0, 831, 5, null, -1) },
            { 31107, new BookItem(31107, 107, ItemType.Book, "ITM_BOK_Name_0107", "ITM_BOK_Info_0106", "itm_03_0000", 0, 832, 6, null, -1) },
            { 31108, new BookItem(31108, 108, ItemType.Book, "ITM_BOK_Name_0108", "ITM_BOK_Info_0107", "itm_03_0000", 0, 833, 7, null, -1) },
            { 31109, new BookItem(31109, 109, ItemType.Book, "ITM_BOK_Name_0109", "ITM_BOK_Info_0134", "itm_03_0000", 0, 834, 34, null, -1) },
            { 31110, new BookItem(31110, 110, ItemType.Book, "ITM_BOK_Name_0110", "ITM_BOK_Info_0109", "itm_03_0000", 0, 835, 9, null, -1) },
            { 31111, new BookItem(31111, 111, ItemType.Book, "ITM_BOK_Name_0111", "ITM_BOK_Info_0112", "itm_03_0000", 0, 836, 12, null, -1) },
            { 31112, new BookItem(31112, 112, ItemType.Book, "ITM_BOK_Name_0112", "ITM_BOK_Info_0136", "itm_03_0000", 0, 837, 36, null, -1) },
            { 31113, new BookItem(31113, 113, ItemType.Book, "ITM_BOK_Name_0113", "ITM_BOK_Info_0120", "itm_03_0000", 0, 838, 20, null, -1) },
            { 31114, new BookItem(31114, 114, ItemType.Book, "ITM_BOK_Name_0114", "ITM_BOK_Info_0116", "itm_03_0000", 0, 839, 16, null, -1) },
            { 31115, new BookItem(31115, 115, ItemType.Book, "ITM_BOK_Name_0115", "ITM_BOK_Info_0117", "itm_03_0000", 0, 840, 17, null, -1) },
            { 31116, new BookItem(31116, 116, ItemType.Book, "ITM_BOK_Name_0116", "ITM_BOK_Info_0110", "itm_03_0000", 0, 841, 10, null, -1) },
            { 31117, new BookItem(31117, 117, ItemType.Book, "ITM_BOK_Name_0117", "ITM_BOK_Info_0118", "itm_03_0000", 0, 842, 18, null, -1) },
            { 31118, new BookItem(31118, 118, ItemType.Book, "ITM_BOK_Name_0118", "ITM_BOK_Info_0139", "itm_03_0000", 0, 843, 39, null, -1) },
            { 31119, new BookItem(31119, 119, ItemType.Book, "ITM_BOK_Name_0119", "ITM_BOK_Info_0124", "itm_03_0000", 0, 844, 24, null, -1) },
            { 31120, new BookItem(31120, 120, ItemType.Book, "ITM_BOK_Name_0120", "ITM_BOK_Info_0125", "itm_03_0000", 0, 845, 25, null, -1) },
            { 31121, new BookItem(31121, 121, ItemType.Book, "ITM_BOK_Name_0121", "ITM_BOK_Info_0114", "itm_03_0000", 0, 846, 14, null, -1) },
            { 31122, new BookItem(31122, 122, ItemType.Book, "ITM_BOK_Name_0122", "ITM_BOK_Info_0115", "itm_03_0000", 0, 847, 15, null, -1) },
            { 31123, new BookItem(31123, 123, ItemType.Book, "ITM_BOK_Name_0123", "ITM_BOK_Info_0121", "itm_03_0000", 0, 848, 21, null, -1) },
            { 31124, new BookItem(31124, 124, ItemType.Book, "ITM_BOK_Name_0124", "ITM_BOK_Info_0119", "itm_03_0000", 0, 849, 19, null, -1) },
            { 31125, new BookItem(31125, 125, ItemType.Book, "ITM_BOK_Name_0125", "ITM_BOK_Info_0130", "itm_03_0000", 0, 850, 30, null, -1) },
            { 31126, new BookItem(31126, 126, ItemType.Book, "ITM_BOK_Name_0126", "ITM_BOK_Info_0135", "itm_03_0000", 0, 851, 35, null, -1) },
            { 31127, new BookItem(31127, 127, ItemType.Book, "ITM_BOK_Name_0127", "ITM_BOK_Info_0133", "itm_03_0000", 0, 852, 33, null, -1) },
            { 31128, new BookItem(31128, 128, ItemType.Book, "ITM_BOK_Name_0128", "ITM_BOK_Info_0123", "itm_03_0000", 0, 853, 23, null, -1) },
            { 31129, new BookItem(31129, 129, ItemType.Book, "ITM_BOK_Name_0129", "ITM_BOK_Info_0108", "itm_03_0000", 0, 854, 8, null, -1) },
            { 31130, new BookItem(31130, 130, ItemType.Book, "ITM_BOK_Name_0130", "ITM_BOK_Info_0122", "itm_03_0000", 0, 855, 22, null, -1) },
            { 31131, new BookItem(31131, 131, ItemType.Book, "ITM_BOK_Name_0131", "ITM_BOK_Info_0137", "itm_03_0000", 0, 856, 37, null, -1) },
            { 31132, new BookItem(31132, 132, ItemType.Book, "ITM_BOK_Name_0132", "ITM_BOK_Info_0111", "itm_03_0000", 0, 857, 11, null, -1) },
            { 31133, new BookItem(31133, 133, ItemType.Book, "ITM_BOK_Name_0133", "ITM_BOK_Info_0138", "itm_03_0000", 0, 858, 38, null, -1) },
            { 31134, new BookItem(31134, 134, ItemType.Book, "ITM_BOK_Name_0134", "ITM_BOK_Info_0126", "itm_03_0000", 0, 859, 26, null, -1) },
            { 31135, new BookItem(31135, 135, ItemType.Book, "ITM_BOK_Name_0135", "ITM_BOK_Info_0127", "itm_03_0000", 0, 860, 27, null, -1) },
            { 31136, new BookItem(31136, 136, ItemType.Book, "ITM_BOK_Name_0136", "ITM_BOK_Info_0128", "itm_03_0000", 0, 861, 28, null, -1) },
            { 31137, new BookItem(31137, 137, ItemType.Book, "ITM_BOK_Name_0137", "ITM_BOK_Info_0129", "itm_03_0000", 0, 862, 29, null, -1) },
            { 31138, new BookItem(31138, 138, ItemType.Book, "ITM_BOK_Name_0138", "ITM_BOK_Info_0131", "itm_03_0000", 0, 863, 31, null, -1) },
            { 31139, new BookItem(31139, 139, ItemType.Book, "ITM_BOK_Name_0139", "ITM_BOK_Info_0132", "itm_03_0000", 0, 864, 32, null, -1) },
            { 31200, new BookItem(31200, 200, ItemType.Book, "ITM_BOK_Name_0200", "Com_Blank", "itm_03_0001", 0, 865, -1, new string[] { "ITM_BOK_Info_0200_1","ITM_BOK_Info_0200_2" }, -1) },
            { 31201, new BookItem(31201, 201, ItemType.Book, "ITM_BOK_Name_0201", "Com_Blank", "itm_03_0001", 0, 866, -1, new string[] { "ITM_BOK_Info_0201_1","ITM_BOK_Info_0201_2" }, -1) },
            { 31202, new BookItem(31202, 202, ItemType.Book, "ITM_BOK_Name_0202", "Com_Blank", "itm_03_0001", 0, 867, -1, new string[] { "ITM_BOK_Info_0202_1","ITM_BOK_Info_0202_2" }, -1) },
            { 31203, new BookItem(31203, 203, ItemType.Book, "ITM_BOK_Name_0203", "Com_Blank", "itm_03_0001", 0, 868, -1, new string[] { "ITM_BOK_Info_0203_1","ITM_BOK_Info_0203_2" }, -1) },
            { 31204, new BookItem(31204, 204, ItemType.Book, "ITM_BOK_Name_0204", "Com_Blank", "itm_03_0001", 0, 869, -1, new string[] { "ITM_BOK_Info_0204_1","ITM_BOK_Info_0204_2" }, -1) },
            { 31205, new BookItem(31205, 205, ItemType.Book, "ITM_BOK_Name_0205", "Com_Blank", "itm_03_0001", 0, 870, -1, new string[] { "ITM_BOK_Info_0205_1","ITM_BOK_Info_0205_2" }, -1) },
            { 31206, new BookItem(31206, 206, ItemType.Book, "ITM_BOK_Name_0206", "Com_Blank", "itm_03_0001", 0, 871, -1, new string[] { "ITM_BOK_Info_0206_1","ITM_BOK_Info_0206_2" }, -1) },
            { 31207, new BookItem(31207, 207, ItemType.Book, "ITM_BOK_Name_0207", "Com_Blank", "itm_03_0001", 0, 872, -1, new string[] { "ITM_BOK_Info_0207_1","ITM_BOK_Info_0207_2" }, -1) },
            { 31208, new BookItem(31208, 208, ItemType.Book, "ITM_BOK_Name_0208", "Com_Blank", "itm_03_0001", 0, 873, -1, new string[] { "ITM_BOK_Info_0208_1","ITM_BOK_Info_0208_2" }, -1) },
            { 31209, new BookItem(31209, 209, ItemType.Book, "ITM_BOK_Name_0209", "Com_Blank", "itm_03_0001", 0, 874, -1, new string[] { "ITM_BOK_Info_0209_1","ITM_BOK_Info_0209_2" }, -1) },
            { 31211, new BookItem(31211, 211, ItemType.Book, "ITM_BOK_Name_0211", "Com_Blank", "itm_03_0001", 0, 876, -1, new string[] { "ITM_BOK_Info_0211_1","ITM_BOK_Info_0211_2" }, -1) },
            { 31212, new BookItem(31212, 212, ItemType.Book, "ITM_BOK_Name_0212", "Com_Blank", "itm_03_0003", 0, 877, -1, new string[] { "ITM_BOK_Info_0212_1","ITM_BOK_Info_0212_2" }, -1) },
            { 31213, new BookItem(31213, 213, ItemType.Book, "ITM_BOK_Name_0213", "Com_Blank", "itm_03_0003", 0, 878, -1, new string[] { "ITM_BOK_Info_0213_1","ITM_BOK_Info_0213_2" }, -1) },
            { 31214, new BookItem(31214, 214, ItemType.Book, "ITM_BOK_Name_0214", "Com_Blank", "itm_03_0003", 0, 879, -1, new string[] { "ITM_BOK_Info_0214_1","ITM_BOK_Info_0214_2" }, -1) },
            { 31215, new BookItem(31215, 215, ItemType.Book, "ITM_BOK_Name_0215", "Com_Blank", "itm_03_0003", 0, 880, -1, new string[] { "ITM_BOK_Info_0215_1","ITM_BOK_Info_0215_2" }, -1) },
            { 31216, new BookItem(31216, 216, ItemType.Book, "ITM_BOK_Name_0216", "Com_Blank", "itm_03_0003", 0, 881, -1, new string[] { "ITM_BOK_Info_0216_1","ITM_BOK_Info_0216_2" }, -1) },
            { 31217, new BookItem(31217, 217, ItemType.Book, "ITM_BOK_Name_0217", "Com_Blank", "itm_03_0002", 0, 882, -1, new string[] { "ITM_BOK_Info_0217_1","ITM_BOK_Info_0217_2" }, -1) },
            { 31218, new BookItem(31218, 218, ItemType.Book, "ITM_BOK_Name_0218", "Com_Blank", "itm_03_0002", 0, 883, -1, new string[] { "ITM_BOK_Info_0218_1","ITM_BOK_Info_0218_2" }, -1) },
            { 31219, new BookItem(31219, 219, ItemType.Book, "ITM_BOK_Name_0219", "Com_Blank", "itm_03_0002", 0, 884, -1, new string[] { "ITM_BOK_Info_0219_1","ITM_BOK_Info_0219_2" }, -1) },
            { 31220, new BookItem(31220, 220, ItemType.Book, "ITM_BOK_Name_0220", "Com_Blank", "itm_03_0002", 0, 885, -1, new string[] { "ITM_BOK_Info_0220_1","ITM_BOK_Info_0220_2" }, -1) },
            { 31221, new BookItem(31221, 221, ItemType.Book, "ITM_BOK_Name_0221", "Com_Blank", "itm_03_0002", 0, 886, -1, new string[] { "ITM_BOK_Info_0221_1","ITM_BOK_Info_0221_2" }, -1) },
            { 31222, new BookItem(31222, 222, ItemType.Book, "ITM_BOK_Name_0222", "Com_Blank", "itm_03_0002", 0, 887, -1, new string[] { "ITM_BOK_Info_0222_1","ITM_BOK_Info_0222_2" }, -1) },
            { 31223, new BookItem(31223, 223, ItemType.Book, "ITM_BOK_Name_0223", "Com_Blank", "itm_03_0001", 0, 888, -1, new string[] { "ITM_BOK_Info_0223_1","ITM_BOK_Info_0223_2" }, -1) },
            { 31224, new BookItem(31224, 224, ItemType.Book, "ITM_BOK_Name_0224", "Com_Blank", "itm_03_0002", 0, 889, -1, new string[] { "ITM_BOK_Info_0224_1","ITM_BOK_Info_0224_2" }, -1) },
            { 31225, new BookItem(31225, 225, ItemType.Book, "ITM_BOK_Name_0225", "Com_Blank", "itm_03_0002", 0, 890, -1, new string[] { "ITM_BOK_Info_0225_1","ITM_BOK_Info_0225_2" }, -1) },
            { 31226, new BookItem(31226, 226, ItemType.Book, "ITM_BOK_Name_0226", "Com_Blank", "itm_03_0003", 0, 891, -1, new string[] { "ITM_BOK_Info_0226_1","ITM_BOK_Info_0226_2" }, -1) },
            { 31227, new BookItem(31227, 227, ItemType.Book, "ITM_BOK_Name_0227", "Com_Blank", "itm_03_0001", 0, 892, -1, new string[] { "ITM_BOK_Info_0227_1","ITM_BOK_Info_0227_2" }, -1) },
            { 31228, new BookItem(31228, 228, ItemType.Book, "ITM_BOK_Name_0228", "Com_Blank", "itm_03_0001", 0, 893, -1, new string[] { "ITM_BOK_Info_0228_1","ITM_BOK_Info_0228_2" }, -1) },
            { 31229, new BookItem(31229, 229, ItemType.Book, "ITM_BOK_Name_0229", "Com_Blank", "itm_03_0001", 0, 894, -1, new string[] { "ITM_BOK_Info_0229_1","ITM_BOK_Info_0229_2" }, -1) },
            { 31230, new BookItem(31230, 230, ItemType.Book, "ITM_BOK_Name_0230", "Com_Blank", "itm_03_0001", 0, 895, -1, new string[] { "ITM_BOK_Info_0230_1","ITM_BOK_Info_0230_2" }, -1) },
            { 31231, new BookItem(31231, 231, ItemType.Book, "ITM_BOK_Name_0231", "Com_Blank", "itm_03_0003", 0, 896, -1, new string[] { "ITM_BOK_Info_0231_1","ITM_BOK_Info_0231_2" }, -1) },
            { 31232, new BookItem(31232, 232, ItemType.Book, "ITM_BOK_Name_0232", "Com_Blank", "itm_03_0003", 0, 897, -1, new string[] { "ITM_BOK_Info_0232_1","ITM_BOK_Info_0232_2" }, -1) },
            { 31233, new BookItem(31233, 233, ItemType.Book, "ITM_BOK_Name_0233", "Com_Blank", "itm_03_0003", 0, 898, -1, new string[] { "ITM_BOK_Info_0233_1","ITM_BOK_Info_0233_2" }, -1) },
            { 31234, new BookItem(31234, 234, ItemType.Book, "ITM_BOK_Name_0234", "Com_Blank", "itm_03_0003", 0, 899, -1, new string[] { "ITM_BOK_Info_0234_1","ITM_BOK_Info_0234_2" }, -1) },
            { 31235, new BookItem(31235, 235, ItemType.Book, "ITM_BOK_Name_0235", "Com_Blank", "itm_03_0003", 0, 900, -1, new string[] { "ITM_BOK_Info_0235_1","ITM_BOK_Info_0235_2" }, -1) },
            { 31236, new BookItem(31236, 236, ItemType.Book, "ITM_BOK_Name_0236", "Com_Blank", "itm_03_0003", 0, 901, -1, new string[] { "ITM_BOK_Info_0236_1","ITM_BOK_Info_0236_2" }, -1) },
            { 31237, new BookItem(31237, 237, ItemType.Book, "ITM_BOK_Name_0237", "Com_Blank", "itm_03_0003", 0, 902, -1, new string[] { "ITM_BOK_Info_0237_1","ITM_BOK_Info_0237_2" }, -1) },
            { 31238, new BookItem(31238, 238, ItemType.Book, "ITM_BOK_Name_0238", "Com_Blank", "itm_03_0003", 0, 903, -1, new string[] { "ITM_BOK_Info_0238_1","ITM_BOK_Info_0238_2" }, -1) },
            { 31239, new BookItem(31239, 239, ItemType.Book, "ITM_BOK_Name_0239", "Com_Blank", "itm_03_0001", 0, 904, -1, new string[] { "ITM_BOK_Info_0239_1","ITM_BOK_Info_0239_2" }, -1) },
            { 31240, new BookItem(31240, 240, ItemType.Book, "ITM_BOK_Name_0240", "Com_Blank", "itm_03_0003", 0, 905, -1, new string[] { "ITM_BOK_Info_0240_1","ITM_BOK_Info_0240_2" }, -1) },
            { 31241, new BookItem(31241, 241, ItemType.Book, "ITM_BOK_Name_0241", "Com_Blank", "itm_03_0003", 0, 906, -1, new string[] { "ITM_BOK_Info_0241_1","ITM_BOK_Info_0241_2" }, -1) },
            { 31242, new BookItem(31242, 242, ItemType.Book, "ITM_BOK_Name_0242", "Com_Blank", "itm_03_0003", 0, 907, -1, new string[] { "ITM_BOK_Info_0242_1","ITM_BOK_Info_0242_2" }, -1) },
            { 31243, new BookItem(31243, 243, ItemType.Book, "ITM_BOK_Name_0243", "Com_Blank", "itm_03_0003", 0, 908, -1, new string[] { "ITM_BOK_Info_0243_1","ITM_BOK_Info_0243_2" }, -1) },
            { 32000, new CDItem(32000, 0, ItemType.CD, "ITM_CD_Name_0001", "ITM_MSC_Info_0001", "itm_03_0100", 0, 750, 1001, "MSC_Name_0001") },
            { 32001, new CDItem(32001, 1, ItemType.CD, "ITM_CD_Name_0011", "ITM_MSC_Info_0002", "itm_03_0100", 0, 751, 1002, "MSC_Name_0002") },
            { 32002, new CDItem(32002, 2, ItemType.CD, "ITM_CD_Name_0005", "ITM_MSC_Info_0003", "itm_03_0100", 0, 752, 1003, "MSC_Name_0003") },
            { 32003, new CDItem(32003, 3, ItemType.CD, "ITM_CD_Name_0008", "ITM_MSC_Info_0004", "itm_03_0100", 0, 753, 1004, "MSC_Name_0004") },
            { 32004, new CDItem(32004, 4, ItemType.CD, "ITM_CD_Name_0012", "ITM_MSC_Info_0005", "itm_03_0100", 0, 754, 1005, "MSC_Name_0005") },
            { 32005, new CDItem(32005, 5, ItemType.CD, "ITM_CD_Name_0009", "ITM_MSC_Info_0006", "itm_03_0100", 0, 755, 1006, "MSC_Name_0006") },
            { 32006, new CDItem(32006, 6, ItemType.CD, "ITM_CD_Name_0015", "ITM_MSC_Info_0007", "itm_03_0100", 0, 756, 1007, "MSC_Name_0007") },
            { 32007, new CDItem(32007, 7, ItemType.CD, "ITM_CD_Name_0006", "ITM_MSC_Info_0008", "itm_03_0100", 0, 757, 1008, "MSC_Name_0008") },
            { 32008, new CDItem(32008, 8, ItemType.CD, "ITM_CD_Name_0018", "ITM_MSC_Info_0009", "itm_03_0100", 0, 758, 1009, "MSC_Name_0009") },
            { 32009, new CDItem(32009, 9, ItemType.CD, "ITM_CD_Name_0010", "ITM_MSC_Info_0010", "itm_03_0100", 0, 759, 1010, "MSC_Name_0010") },
            { 32010, new CDItem(32010, 10, ItemType.CD, "ITM_CD_Name_0019", "ITM_MSC_Info_0011", "itm_03_0100", 0, 760, 1011, "MSC_Name_0011") },
            { 32011, new CDItem(32011, 11, ItemType.CD, "ITM_CD_Name_0016", "ITM_MSC_Info_0012", "itm_03_0100", 0, 761, 1012, "MSC_Name_0012") },
            { 32012, new CDItem(32012, 12, ItemType.CD, "ITM_CD_Name_0014", "ITM_MSC_Info_0013", "itm_03_0100", 0, 762, 1013, "MSC_Name_0013") },
            { 32013, new CDItem(32013, 13, ItemType.CD, "ITM_CD_Name_0017", "ITM_MSC_Info_0014", "itm_03_0100", 0, 763, 1014, "MSC_Name_0014") },
            { 32014, new CDItem(32014, 14, ItemType.CD, "ITM_CD_Name_0004", "ITM_MSC_Info_0015", "itm_03_0100", 0, 764, 1015, "MSC_Name_0015") },
            { 32015, new CDItem(32015, 15, ItemType.CD, "ITM_CD_Name_0003", "ITM_MSC_Info_0016", "itm_03_0100", 0, 765, 1016, "MSC_Name_0016") },
            { 32016, new CDItem(32016, 16, ItemType.CD, "ITM_CD_Name_0013", "ITM_MSC_Info_0017", "itm_03_0100", 0, 766, 1017, "MSC_Name_0017") },
            { 32017, new CDItem(32017, 17, ItemType.CD, "ITM_CD_Name_0007", "ITM_MSC_Info_0018", "itm_03_0100", 0, 767, 1018, "MSC_Name_0018") },
            { 32018, new CDItem(32018, 18, ItemType.CD, "ITM_CD_Name_0021", "ITM_MSC_Info_0019", "itm_03_0100", 0, 768, 1019, "MSC_Name_0019") },
            { 32019, new CDItem(32019, 19, ItemType.CD, "ITM_CD_Name_0020", "ITM_MSC_Info_0020", "itm_03_0100", 0, 769, 1020, "MSC_Name_0020") },
            { 32020, new CDItem(32020, 20, ItemType.CD, "ITM_CD_Name_0029", "ITM_MSC_Info_0021", "itm_03_0100", 0, 770, 1021, "MSC_Name_0021") },
            { 32021, new CDItem(32021, 21, ItemType.CD, "ITM_CD_Name_0002", "ITM_MSC_Info_0022", "itm_03_0100", 0, 771, 1022, "MSC_Name_0022") },
            { 32022, new CDItem(32022, 22, ItemType.CD, "ITM_CD_Name_0030", "ITM_MSC_Info_0023", "itm_03_0100", 0, 772, 1023, "MSC_Name_0023") },
            { 32023, new CDItem(32023, 23, ItemType.CD, "ITM_CD_Name_0022", "ITM_MSC_Info_0024", "itm_03_0100", 0, 773, 1024, "MSC_Name_0024") },
            { 32024, new CDItem(32024, 24, ItemType.CD, "ITM_CD_Name_0023", "ITM_MSC_Info_0025", "itm_03_0100", 0, 774, 1025, "MSC_Name_0025") },
            { 32025, new CDItem(32025, 25, ItemType.CD, "ITM_CD_Name_0024", "ITM_MSC_Info_0026", "itm_03_0100", 0, 775, 1026, "MSC_Name_0026") },
            { 32026, new CDItem(32026, 26, ItemType.CD, "ITM_CD_Name_0025", "ITM_MSC_Info_0027", "itm_03_0100", 0, 776, 1027, "MSC_Name_0027") },
            { 32027, new CDItem(32027, 27, ItemType.CD, "ITM_CD_Name_0026", "ITM_MSC_Info_0028", "itm_03_0100", 0, 777, 1028, "MSC_Name_0028") },
            { 32028, new CDItem(32028, 28, ItemType.CD, "ITM_CD_Name_0027", "ITM_MSC_Info_0029", "itm_03_0100", 0, 778, 1029, "MSC_Name_0029") },
            { 32029, new CDItem(32029, 29, ItemType.CD, "ITM_CD_Name_0028", "ITM_MSC_Info_0030", "itm_03_0100", 0, 779, 1030, "MSC_Name_0030") },
            { 32030, new CDItem(32030, 30, ItemType.CD, "ITM_CD_Name_0048", "ITM_MSC_Info_0031", "itm_03_0100", 0, 780, 1031, "MSC_Name_0031") },
            { 32031, new CDItem(32031, 31, ItemType.CD, "ITM_CD_Name_0044", "ITM_MSC_Info_0032", "itm_03_0100", 0, 781, 1032, "MSC_Name_0032") },
            { 32032, new CDItem(32032, 32, ItemType.CD, "ITM_CD_Name_0038", "ITM_MSC_Info_0033", "itm_03_0100", 0, 782, 1033, "MSC_Name_0033") },
            { 32033, new CDItem(32033, 33, ItemType.CD, "ITM_CD_Name_0047", "ITM_MSC_Info_0034", "itm_03_0100", 0, 783, 1034, "MSC_Name_0034") },
            { 32034, new CDItem(32034, 34, ItemType.CD, "ITM_CD_Name_0043", "ITM_MSC_Info_0035", "itm_03_0100", 0, 784, 1035, "MSC_Name_0035") },
            { 32035, new CDItem(32035, 35, ItemType.CD, "ITM_CD_Name_0036", "ITM_MSC_Info_0036", "itm_03_0100", 0, 785, 1036, "MSC_Name_0036") },
            { 32036, new CDItem(32036, 36, ItemType.CD, "ITM_CD_Name_0045", "ITM_MSC_Info_0037", "itm_03_0100", 0, 786, 1037, "MSC_Name_0037") },
            { 32037, new CDItem(32037, 37, ItemType.CD, "ITM_CD_Name_0034", "ITM_MSC_Info_0038", "itm_03_0100", 0, 787, 1038, "MSC_Name_0038") },
            { 32038, new CDItem(32038, 38, ItemType.CD, "ITM_CD_Name_0040", "ITM_MSC_Info_0039", "itm_03_0100", 0, 788, 1039, "MSC_Name_0039") },
            { 32039, new CDItem(32039, 39, ItemType.CD, "ITM_CD_Name_0046", "ITM_MSC_Info_0040", "itm_03_0100", 0, 789, 1040, "MSC_Name_0040") },
            { 32040, new CDItem(32040, 40, ItemType.CD, "ITM_CD_Name_0041", "ITM_MSC_Info_0041", "itm_03_0100", 0, 790, 1041, "MSC_Name_0041") },
            { 32041, new CDItem(32041, 41, ItemType.CD, "ITM_CD_Name_0049", "ITM_MSC_Info_0042", "itm_03_0100", 0, 791, 1042, "MSC_Name_0042") },
            { 32042, new CDItem(32042, 42, ItemType.CD, "ITM_CD_Name_0037", "ITM_MSC_Info_0043", "itm_03_0100", 0, 792, 1043, "MSC_Name_0043") },
            { 32043, new CDItem(32043, 43, ItemType.CD, "ITM_CD_Name_0039", "ITM_MSC_Info_0044", "itm_03_0100", 0, 793, 1044, "MSC_Name_0044") },
            { 32044, new CDItem(32044, 44, ItemType.CD, "ITM_CD_Name_0033", "ITM_MSC_Info_0045", "itm_03_0100", 0, 794, 1045, "MSC_Name_0045") },
            { 32045, new CDItem(32045, 45, ItemType.CD, "ITM_CD_Name_0032", "ITM_MSC_Info_0046", "itm_03_0100", 0, 795, 1046, "MSC_Name_0046") },
            { 32046, new CDItem(32046, 46, ItemType.CD, "ITM_CD_Name_0050", "ITM_MSC_Info_0047", "itm_03_0100", 0, 796, 1047, "MSC_Name_0047") },
            { 32047, new CDItem(32047, 47, ItemType.CD, "ITM_CD_Name_0035", "ITM_MSC_Info_0048", "itm_03_0100", 0, 797, 1048, "MSC_Name_0048") },
            { 32048, new CDItem(32048, 48, ItemType.CD, "ITM_CD_Name_0042", "ITM_MSC_Info_0049", "itm_03_0100", 0, 798, 1049, "MSC_Name_0049") },
            { 32049, new CDItem(32049, 49, ItemType.CD, "ITM_CD_Name_0051", "ITM_MSC_Info_0050", "itm_03_0100", 0, 799, 1050, "MSC_Name_0050") },
            { 32050, new CDItem(32050, 50, ItemType.CD, "ITM_CD_Name_0031", "ITM_MSC_Info_0051", "itm_03_0100", 0, 749, 1051, "MSC_Name_0051") },
        };

        private readonly Dictionary<byte, Brand> Brands = new Dictionary<byte, Brand>()
        {
            { 0, new Brand(0, "BRD_Name_0000", "brand_00", 0, new ushort[] { 0,0,0,0 }) },
            { 1, new Brand(1, "BRD_Name_0001", "brand_01", 1, new ushort[] { 5200,9700,13200,17200 }) },
            { 2, new Brand(2, "BRD_Name_0002", "brand_02", 2, new ushort[] { 5200,9700,14200,21200 }) },
            { 3, new Brand(3, "BRD_Name_0003", "brand_03", 3, new ushort[] { 5200,10800,17300,23200 }) },
            { 4, new Brand(4, "BRD_Name_0004", "brand_04", 4, new ushort[] { 5200,10700,16200,20700 }) },
            { 5, new Brand(5, "BRD_Name_0005", "brand_05", 5, new ushort[] { 4200,7600,11000,15400 }) },
            { 6, new Brand(6, "BRD_Name_0006", "brand_06", 6, new ushort[] { 5200,9700,14200,19600 }) },
            { 7, new Brand(7, "BRD_Name_0007", "brand_07", 7, new ushort[] { 5600,10100,15600,21200 }) },
            { 8, new Brand(8, "BRD_Name_0008", "brand_08", 8, new ushort[] { 5200,10700,15300,19200 }) },
            { 9, new Brand(9, "BRD_Name_0009", "brand_09", 9, new ushort[] { 5700,10100,14500,17700 }) },
            { 10, new Brand(10, "BRD_Name_0010", "brand_10", 10, new ushort[] { 4400,9000,12400,15600 }) },
            { 11, new Brand(11, "BRD_Name_0011", "brand_11", 11, new ushort[] { 5300,10700,15100,20600 }) },
            { 12, new Brand(12, "BRD_Name_0012", "brand_12", 12, new ushort[] { 4200,10700,16200,22200 }) },
            { 13, new Brand(13, "BRD_Name_0013", "brand_13", 13, new ushort[] { 3200,6700,10200,14600 }) },
            { 14, new Brand(14, "BRD_Name_0014", "brand_14", 14, new ushort[] { 3600,6900,10200,15600 }) },
            { 15, new Brand(15, "BRD_Name_0015", "brand_15", 15, new ushort[] { 2700,4900,7500,9900 }) },
        };

        private readonly Dictionary<sbyte, Shop> Shops = new Dictionary<sbyte, Shop>()
        {
            { 0, new Shop(0, "SHO_Name_001", "SHO_Category_001", 2, 0, 31200, 52, 1, 1021, "Shop_001", false, 0, new ushort[] { 15,33 }, new ushort[] { 8,15 }, new ushort[] { 0,0 }, new ushort[] { 100,101,102,103,104,105,106,107,108,109,110,111 }) },
            { 1, new Shop(1, "SHO_Name_002", "SHO_Category_002", 1, 0, 20003, 53, 2, 1021, "Shop_002", true, 1, new ushort[] { 25,60 }, new ushort[] { 8,15 }, new ushort[] { 0,0 }, new ushort[] { 200,201,202,203,204,205,206,207,208,209,210,211 }) },
            { 2, new Shop(2, "SHO_Name_003", "SHO_Category_003", 1, 0, 20100, 54, 3, 1021, "Shop_003", false, 2, new ushort[] { 25,60 }, new ushort[] { 8,15 }, new ushort[] { 0,0 }, new ushort[] { 300,301,302,303,304,305,306,307,308,309,310,311 }) },
            { 3, new Shop(3, "SHO_Name_004", "SHO_Category_004", 0, 2, 10200, 69, 4, 1021, "Shop_004", false, 3, new ushort[] { 3,6 }, new ushort[] { 8,15 }, new ushort[] { 1,1 }, new ushort[] { 400,401,402,403,404,405,406,407,408,409,410,411 }) },
            { 4, new Shop(4, "SHO_Name_005", "SHO_Category_005", 0, 1, 10100, 70, 5, 1021, "Shop_005", false, 4, new ushort[] { 3,5 }, new ushort[] { 8,15 }, new ushort[] { 1,1 }, new ushort[] { 500,501,502,503,504,505,506,507,508,509,510,511 }) },
            { 5, new Shop(5, "SHO_Name_006", "SHO_Category_006", 0, 13, 11301, 71, 6, 1021, "Shop_006", false, 5, new ushort[] { 7,14 }, new ushort[] { 8,15 }, new ushort[] { 1,1 }, new ushort[] { 600,601,602,603,604,605,606,607,608,609,610,611 }) },
            { 6, new Shop(6, "SHO_Name_007", "SHO_Category_007", 0, 8, 10800, 55, 7, 1021, "Shop_007", false, 6, new ushort[] { 3,7 }, new ushort[] { 8,15 }, new ushort[] { 1,1 }, new ushort[] { 700,701,702,703,704,705,706,707,708,709,710,711 }) },
            { 7, new Shop(7, "SHO_Name_008", "SHO_Category_008", 0, 12, 11216, 56, 8, 1021, "Shop_008", false, 7, new ushort[] { 4,9 }, new ushort[] { 8,15 }, new ushort[] { 1,1 }, new ushort[] { 800,801,802,803,804,805,806,807,808,809,810,811 }) },
            { 8, new Shop(8, "SHO_Name_010", "SHO_Category_010", 1, 0, 20800, 57, 9, 1021, "Shop_010", false, 9, new ushort[] { 15,40 }, new ushort[] { 8,15 }, new ushort[] { 0,0 }, new ushort[] { 1000,1001,1002,1003,1004,1005,1006,1007,1008,1009,1010,1011 }) },
            { 9, new Shop(9, "SHO_Name_011", "SHO_Category_011", 1, 0, 20200, 58, 10, 1021, "Shop_011", false, 10, new ushort[] { 20,50 }, new ushort[] { 8,15 }, new ushort[] { 0,0 }, new ushort[] { 1100,1101,1102,1103,1104,1105,1106,1107,1108,1109,1110,1111 }) },
            { 10, new Shop(10, "SHO_Name_012", "SHO_Category_012", 1, 0, 20301, 59, 11, 1021, "Shop_012", false, 11, new ushort[] { 15,40 }, new ushort[] { 8,15 }, new ushort[] { 0,0 }, new ushort[] { 1200,1201,1202,1203,1204,1205,1206,1207,1208,1209,1210,1211 }) },
            { 11, new Shop(11, "SHO_Name_013", "SHO_Category_013", 2, 0, 1000, 60, 12, 1021, "Shop_013", false, 12, new ushort[] { 4,8 }, new ushort[] { 8,15 }, new ushort[] { 0,0 }, new ushort[] { 1300,1301,1302,1303,1304,1305,1306,1307,1308,1309,1310,1311 }) },
            { 12, new Shop(12, "SHO_Name_014", "SHO_Category_014", 2, 0, 11201, 61, 13, 1021, "Shop_014", false, 13, new ushort[] { 4,8 }, new ushort[] { 8,15 }, new ushort[] { 0,0 }, new ushort[] { 1400,1401,1402,1403,1404,1405,1406,1407,1408,1409,1410,1411 }) },
            { 13, new Shop(13, "SHO_Name_015", "SHO_Category_015", 2, 0, 5101, 62, 14, 1021, "Shop_015", false, 14, new ushort[] { 4,8 }, new ushort[] { 8,15 }, new ushort[] { 0,0 }, new ushort[] { 1500,1501,1502,1503,1504,1505,1506,1507,1508,1509,1510,1511 }) },
            { 14, new Shop(14, "SHO_Name_016", "SHO_Category_016", 0, 10, 11001, 72, 15, 1021, "Shop_016", false, 15, new ushort[] { 6,12 }, new ushort[] { 14,20 }, new ushort[] { 1,1 }, new ushort[] { 1600,1601,1602,1603,1604,1605,1606,1607,1608,1609,1610,1611 }) },
            { 15, new Shop(15, "SHO_Name_017", "SHO_Category_017", 2, 0, 32000, 73, 16, 1021, "Shop_017", false, 16, new ushort[] { 6,14 }, new ushort[] { 14,20 }, new ushort[] { 0,0 }, new ushort[] { 1700,1701,1702,1703,1704,1705,1706,1707,1708,1709,1710,1711 }) },
            { 16, new Shop(16, "SHO_Name_018", "SHO_Category_018", 1, 0, 20400, 74, 17, 1021, "Shop_018", false, 17, new ushort[] { 15,40 }, new ushort[] { 14,20 }, new ushort[] { 0,0 }, new ushort[] { 1800,1801,1802,1803,1804,1805,1806,1807,1808,1809,1810,1811 }) },
            { 17, new Shop(17, "SHO_Name_019", "SHO_Category_019", 0, 6, 10600, 63, 18, 1021, "Shop_019", false, 18, new ushort[] { 7,16 }, new ushort[] { 8,15 }, new ushort[] { 1,1 }, new ushort[] { 1900,1901,1902,1903,1904,1905,1906,1907,1908,1909,1910,1911 }) },
            { 18, new Shop(18, "SHO_Name_020", "SHO_Category_020", 1, 0, 20900, 64, 19, 1021, "Shop_020", false, 19, new ushort[] { 20,50 }, new ushort[] { 8,15 }, new ushort[] { 0,0 }, new ushort[] { 2000,2001,2002,2003,2004,2005,2006,2007,2008,2009,2010,2011 }) },
            { 19, new Shop(19, "SHO_Name_021", "SHO_Category_021", 2, 0, 32030, 65, 20, 1021, "Shop_021", false, 20, new ushort[] { 11,23 }, new ushort[] { 8,15 }, new ushort[] { 0,0 }, new ushort[] { 2100,2101,2102,2103,2104,2105,2106,2107,2108,2109,2110,2111 }) },
            { 20, new Shop(20, "SHO_Name_022", "SHO_Category_022", 1, 0, 20500, 66, 21, 1021, "Shop_022", false, 21, new ushort[] { 25,55 }, new ushort[] { 14,20 }, new ushort[] { 0,0 }, new ushort[] { 2200,2201,2202,2203,2204,2205,2206,2207,2208,2209,2210,2211 }) },
            { 21, new Shop(21, "SHO_Name_023", "SHO_Category_023", 0, 11, 11101, 67, 22, 1021, "Shop_023", false, 22, new ushort[] { 7,16 }, new ushort[] { 14,20 }, new ushort[] { 1,1 }, new ushort[] { 2300,2301,2302,2303,2304,2305,2306,2307,2308,2309,2310,2311 }) },
            { 22, new Shop(22, "SHO_Name_024", "SHO_Category_024", 0, 2, 10212, 68, 23, 1021, "Shop_024", false, 23, new ushort[] { 3,6 }, new ushort[] { 14,20 }, new ushort[] { 1,1 }, new ushort[] { 2400,2401,2402,2403,2404,2405,2406,2407,2408,2409,2410,2411 }) },
            { 23, new Shop(23, "SHO_Name_025", "SHO_Category_025", 1, 0, 20601, 75, 24, 1021, "Shop_025", false, 24, new ushort[] { 15,50 }, new ushort[] { 8,15 }, new ushort[] { 0,0 }, new ushort[] { 2500,2501,2502,2503,2504,2505,2506,2507,2508,2509,2510,2511 }) },
            { 24, new Shop(24, "SHO_Name_026", "SHO_Category_026", 1, 0, 21500, 76, 25, 1021, "Shop_026", false, 25, new ushort[] { 15,45 }, new ushort[] { 8,15 }, new ushort[] { 0,0 }, new ushort[] { 2600,2601,2602,2603,2604,2605,2606,2607,2608,2609,2610,2611 }) },
            { 25, new Shop(25, "SHO_Name_027", "SHO_Category_027", 1, 0, 21300, 77, 26, 1021, "Shop_027", false, 26, new ushort[] { 20,50 }, new ushort[] { 8,15 }, new ushort[] { 0,0 }, new ushort[] { 2700,2701,2702,2703,2704,2705,2706,2707,2708,2709,2710,2711 }) },
            { 26, new Shop(26, "SHO_Name_028", "SHO_Category_028", 0, 4, 10400, 78, 27, 1021, "Shop_028", false, 27, new ushort[] { 7,16 }, new ushort[] { 8,15 }, new ushort[] { 1,1 }, new ushort[] { 2800,2801,2802,2803,2804,2805,2806,2807,2808,2809,2810,2811 }) },
            { 27, new Shop(27, "SHO_Name_029", "SHO_Category_029", 0, 3, 10301, 79, 28, 1021, "Shop_029", false, 28, new ushort[] { 8,17 }, new ushort[] { 8,15 }, new ushort[] { 1,1 }, new ushort[] { 2900,2901,2902,2903,2904,2905,2906,2907,2908,2909,2910,2911 }) },
            { 28, new Shop(28, "SHO_Name_030", "SHO_Category_030", 0, 8, 10801, 90, 29, 1021, "Shop_030", false, 29, new ushort[] { 2,5 }, new ushort[] { 14,20 }, new ushort[] { 1,1 }, new ushort[] { 3000,3001,3002,3003,3004,3005,3006,3007,3008,3009,3010,3011 }) },
            { 29, new Shop(29, "SHO_Name_031", "SHO_Category_031", 1, 0, 20700, 91, 30, 1021, "Shop_031", false, 30, new ushort[] { 25,60 }, new ushort[] { 14,20 }, new ushort[] { 0,0 }, new ushort[] { 3100,3101,3102,3103,3104,3105,3106,3107,3108,3109,3110,3111 }) },
            { 30, new Shop(30, "SHO_Name_032", "SHO_Category_032", 0, 9, 10901, 92, 31, 1021, "Shop_032", false, 31, new ushort[] { 7,14 }, new ushort[] { 14,20 }, new ushort[] { 1,1 }, new ushort[] { 3200,3201,3202,3203,3204,3205,3206,3207,3208,3209,3210,3211 }) },
            { 31, new Shop(31, "SHO_Name_033", "SHO_Category_033", 0, 12, 11215, 93, 32, 1021, "Shop_033", false, 32, new ushort[] { 3,7 }, new ushort[] { 14,20 }, new ushort[] { 1,1 }, new ushort[] { 3300,3301,3302,3303,3304,3305,3306,3307,3308,3309,3310,3311 }) },
            { 32, new Shop(32, "SHO_Name_034", "SHO_Category_034", 1, 0, 21101, 97, 33, 1021, "Shop_034", false, 33, new ushort[] { 25,55 }, new ushort[] { 19,23 }, new ushort[] { 0,0 }, new ushort[] { 3400,3401,3402,3403,3404,3405,3406,3407,3408,3409,3410,3411 }) },
            { 33, new Shop(33, "SHO_Name_035", "SHO_Category_035", 0, 5, 10500, 80, 34, 1021, "Shop_035", false, 34, new ushort[] { 6,13 }, new ushort[] { 8,15 }, new ushort[] { 1,1 }, new ushort[] { 3500,3501,3502,3503,3504,3505,3506,3507,3508,3509,3510,3511 }) },
            { 34, new Shop(34, "SHO_Name_036", "SHO_Category_036", 1, 0, 21603, 81, 35, 1021, "Shop_036", false, 35, new ushort[] { 20,50 }, new ushort[] { 8,15 }, new ushort[] { 0,0 }, new ushort[] { 3600,3601,3602,3603,3604,3605,3606,3607,3608,3609,3610,3611 }) },
            { 35, new Shop(35, "SHO_Name_037", "SHO_Category_037", 2, 0, 1308, 82, 36, 1021, "Shop_037", true, 36, new ushort[] { 4,7 }, new ushort[] { 14,20 }, new ushort[] { 0,0 }, new ushort[] { 3700,3701,3702,3703,3704,3705,3706,3707,3708,3709,3710,3711 }) },
            { 36, new Shop(36, "SHO_Name_038", "SHO_Category_038", 1, 0, 21400, 95, 37, 1021, "Shop_038", false, 37, new ushort[] { 20,55 }, new ushort[] { 19,23 }, new ushort[] { 0,0 }, new ushort[] { 3800,3801,3802,3803,3804,3805,3806,3807,3808,3809,3810,3811 }) },
            { 37, new Shop(37, "SHO_Name_039", "SHO_Category_039", 1, 0, 21200, 96, 38, 1021, "Shop_039", false, 38, new ushort[] { 20,60 }, new ushort[] { 19,23 }, new ushort[] { 0,0 }, new ushort[] { 3900,3901,3902,3903,3904,3905,3906,3907,3908,3909,3910,3911 }) },
            { 38, new Shop(38, "SHO_Name_040", "SHO_Category_040", 1, 0, 21700, 83, 39, 1021, "Shop_040", false, 39, new ushort[] { 20,55 }, new ushort[] { 14,20 }, new ushort[] { 0,0 }, new ushort[] { 4000,4001,4002,4003,4004,4005,4006,4007,4008,4009,4010,4011 }) },
            { 39, new Shop(39, "SHO_Name_041", "SHO_Category_041", 2, 0, 1001, 84, 40, 1021, "Shop_041", false, 40, new ushort[] { 5,10 }, new ushort[] { 14,20 }, new ushort[] { 0,0 }, new ushort[] { 4100,4101,4102,4103,4104,4105,4106,4107,4108,4109,4110,4111 }) },
            { 40, new Shop(40, "SHO_Name_042", "SHO_Category_042", 0, 14, 11400, 85, 41, 1021, "Shop_042", false, 41, new ushort[] { 6,12 }, new ushort[] { 14,20 }, new ushort[] { 1,1 }, new ushort[] { 4200,4201,4202,4203,4204,4205,4206,4207,4208,4209,4210,4211 }) },
            { 41, new Shop(41, "SHO_Name_043", "SHO_Category_043", 0, 1, 10102, 86, 42, 1021, "Shop_043", false, 42, new ushort[] { 2,5 }, new ushort[] { 14,20 }, new ushort[] { 1,1 }, new ushort[] { 4300,4301,4302,4303,4304,4305,4306,4307,4308,4309,4310,4311 }) },
            { 42, new Shop(42, "SHO_Name_044", "SHO_Category_044", 2, 0, 10219, 87, 43, 1021, "Shop_044", false, 43, new ushort[] { 3,6 }, new ushort[] { 14,20 }, new ushort[] { 0,0 }, new ushort[] { 4400,4401,4402,4403,4404,4405,4406,4407,4408,4409,4410,4411 }) },
            { 43, new Shop(43, "SHO_Name_045", "SHO_Category_045", 1, 0, 21000, 88, 44, 1021, "Shop_045", false, 44, new ushort[] { 25,55 }, new ushort[] { 14,20 }, new ushort[] { 0,0 }, new ushort[] { 4500,4501,4502,4503,4504,4505,4506,4507,4508,4509,4510,4511 }) },
            { 44, new Shop(44, "SHO_Name_046", "SHO_Category_046", 0, 7, 10700, 89, 45, 1021, "Shop_046", false, 45, new ushort[] { 7,14 }, new ushort[] { 14,20 }, new ushort[] { 1,1 }, new ushort[] { 4600,4601,4602,4603,4604,4605,4606,4607,4608,4609,4610,4611 }) },
            { 45, new Shop(45, "SHO_Name_047", "SHO_Category_047", 0, 15, 11500, 94, 46, 1021, "Shop_047", false, 46, new ushort[] { 3,6 }, new ushort[] { 14,20 }, new ushort[] { 1,1 }, new ushort[] { 4700,4701,4702,4703,4704,4705,4706,4707,4708,4709,4710,4711 }) }
        };

        private readonly Dictionary<ushort, Ability> Abilities = new Dictionary<ushort, Ability>()
        {
            { 1, new Ability(1, "ABL_Name_0001", "ABL_Info_0001", 1, 0, -1, new float[] { 0.05f,0f,0f,0 }, -1, -1) },
            { 2, new Ability(2, "ABL_Name_0002", "ABL_Info_0002", 1, 0, -1, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 3, new Ability(3, "ABL_Name_0003", "ABL_Info_0003", 1, 0, -1, new float[] { 0.2f,0f,0f,0 }, -1, -1) },
            { 4, new Ability(4, "ABL_Name_0004", "ABL_Info_0004", 1, 0, 1, new float[] { 0.05f,0f,0f,0 }, -1, -1) },
            { 5, new Ability(5, "ABL_Name_0005", "ABL_Info_0005", 1, 0, 1, new float[] { 0.15f,0f,0f,0 }, -1, -1) },
            { 6, new Ability(6, "ABL_Name_0006", "ABL_Info_0006", 1, 0, 1, new float[] { 0.25f,0f,0f,0 }, -1, -1) },
            { 7, new Ability(7, "ABL_Name_0007", "ABL_Info_0007", 1, 0, 3, new float[] { 0.05f,0f,0f,0 }, -1, -1) },
            { 8, new Ability(8, "ABL_Name_0008", "ABL_Info_0008", 1, 0, 3, new float[] { 0.15f,0f,0f,0 }, -1, -1) },
            { 9, new Ability(9, "ABL_Name_0009", "ABL_Info_0009", 1, 0, 3, new float[] { 0.25f,0f,0f,0 }, -1, -1) },
            { 10, new Ability(10, "ABL_Name_0010", "ABL_Info_0010", 1, 0, 2, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 11, new Ability(11, "ABL_Name_0011", "ABL_Info_0011", 1, 0, 4, new float[] { 0.075f,0f,0f,0 }, -1, -1) },
            { 12, new Ability(12, "ABL_Name_0012", "ABL_Info_0012", 1, 0, 4, new float[] { 0.15f,0f,0f,0 }, -1, -1) },
            { 13, new Ability(13, "ABL_Name_0013", "ABL_Info_0013", 1, 0, 4, new float[] { 0.225f,0f,0f,0 }, -1, -1) },
            { 14, new Ability(14, "ABL_Name_0014", "ABL_Info_0014", 1, 0, 5, new float[] { 0.225f,0f,0f,0 }, -1, -1) },
            { 15, new Ability(15, "ABL_Name_0015", "ABL_Info_0015", 1, 0, 5, new float[] { 0.35f,0f,0f,0 }, -1, -1) },
            { 16, new Ability(16, "ABL_Name_0016", "ABL_Info_0016", 1, 0, 6, new float[] { 0.5f,0f,0f,0 }, -1, -1) },
            { 17, new Ability(17, "ABL_Name_0017", "ABL_Info_0017", 1, 0, 7, new float[] { 0.4f,0f,0f,0 }, -1, -1) },
            { 18, new Ability(18, "ABL_Name_0018", "ABL_Info_0018", 2, 0, -1, new float[] { 0.8f,0.1f,0f,0 }, -1, -1) },
            { 19, new Ability(19, "ABL_Name_0019", "ABL_Info_0019", 2, 0, -1, new float[] { 0.8f,0.25f,0f,0 }, -1, -1) },
            { 20, new Ability(20, "ABL_Name_0020", "ABL_Info_0020", 4, 0, -1, new float[] { 0.05f,0f,0f,0 }, -1, -1) },
            { 21, new Ability(21, "ABL_Name_0021", "ABL_Info_0021", 4, 0, -1, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 22, new Ability(22, "ABL_Name_0022", "ABL_Info_0022", 5, 0, -1, new float[] { 1f,0.05f,0f,0 }, -1, -1) },
            { 23, new Ability(23, "ABL_Name_0023", "ABL_Info_0023", 6, 0, -1, new float[] { 1f,0.15f,0f,0 }, -1, -1) },
            { 24, new Ability(24, "ABL_Name_0024", "ABL_Info_0024", 7, 0, -1, new float[] { 0.25f,0.1f,0f,0 }, -1, -1) },
            { 25, new Ability(25, "ABL_Name_0025", "ABL_Info_0025", 7, 0, 6, new float[] { 0.25f,0.15f,0f,0 }, -1, -1) },
            { 26, new Ability(26, "ABL_Name_0026", "ABL_Info_0026", 402, 0, -1, new float[] { 0.25f,0.15f,0f,0 }, -1, -1) },
            { 27, new Ability(27, "Com_Blank", "Com_Blank", 700, 0, -1, new float[] { 0.25f,0.1f,0f,0 }, -1, -1) },
            { 28, new Ability(28, "ABL_Name_0028", "ABL_Info_0028", 2008, 0, -1, new float[] { 0f,0f,0f,0 }, -1, -1) },
            { 29, new Ability(29, "ABL_Name_0029", "ABL_Info_0029", 900, 0, -1, new float[] { 0.2f,0f,0f,0 }, -1, -1) },
            { 30, new Ability(30, "ABL_Name_0030", "ABL_Info_0030", 900, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 31, new Ability(31, "ABL_Name_0031", "ABL_Info_0031", 901, 0, -1, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 32, new Ability(32, "ABL_Name_0032", "ABL_Info_0032", 901, 0, -1, new float[] { 0.2f,0f,0f,0 }, -1, -1) },
            { 33, new Ability(33, "Com_Blank", "Com_Blank", 902, 0, -1, new float[] { 0.5f,0f,0f,0 }, -1, -1) },
            { 34, new Ability(34, "Com_Blank", "Com_Blank", 902, 0, -1, new float[] { 1f,0f,0f,0 }, -1, -1) },
            { 35, new Ability(35, "ABL_Name_0035", "ABL_Info_0035", 2007, 0, -1, new float[] { 0.2f,0f,0f,0 }, -1, -1) },
            { 36, new Ability(36, "ABL_Name_0036", "ABL_Info_0036", 8, 0, -1, new float[] { 1f,0.15f,0f,0 }, -1, -1) },
            { 37, new Ability(37, "ABL_Name_0037", "ABL_Info_0037", 8, 0, -1, new float[] { 2f,0.15f,0f,0 }, -1, -1) },
            { 38, new Ability(38, "ABL_Name_0038", "ABL_Info_0038", 8, 0, -1, new float[] { 3f,0.15f,0f,0 }, -1, -1) },
            { 39, new Ability(39, "ABL_Name_0039", "ABL_Info_0039", 8, 0, -1, new float[] { 4f,0.15f,0f,0 }, -1, -1) },
            { 40, new Ability(40, "ABL_Name_0040", "ABL_Info_0040", 8, 0, -1, new float[] { 5f,0.15f,0f,0 }, -1, -1) },
            { 41, new Ability(41, "ABL_Name_0041", "ABL_Info_0041", 8, 0, -1, new float[] { 6f,0.15f,0f,0 }, -1, -1) },
            { 42, new Ability(42, "Com_Blank", "Com_Blank", 8, 0, -1, new float[] { 1f,0.3f,0f,0 }, -1, -1) },
            { 43, new Ability(43, "ABL_Name_0043", "ABL_Info_0043", 9, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, 1) },
            { 44, new Ability(44, "ABL_Name_0044", "ABL_Info_0044", 9, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, 2) },
            { 45, new Ability(45, "ABL_Name_0045", "ABL_Info_0045", 9, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, 3) },
            { 46, new Ability(46, "ABL_Name_0046", "ABL_Info_0046", 9, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, 4) },
            { 47, new Ability(47, "ABL_Name_0047", "ABL_Info_0047", 9, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, 5) },
            { 48, new Ability(48, "ABL_Name_0048", "ABL_Info_0048", 9, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, 6) },
            { 49, new Ability(49, "ABL_Name_0049", "ABL_Info_0049", 9, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, 7) },
            { 50, new Ability(50, "ABL_Name_0050", "ABL_Info_0050", 9, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, 8) },
            { 51, new Ability(51, "ABL_Name_0051", "ABL_Info_0051", 9, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, 9) },
            { 52, new Ability(52, "ABL_Name_0052", "ABL_Info_0052", 9, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, 10) },
            { 53, new Ability(53, "ABL_Name_0053", "ABL_Info_0053", 9, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, 11) },
            { 54, new Ability(54, "ABL_Name_0054", "ABL_Info_0054", 9, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, 12) },
            { 55, new Ability(55, "ABL_Name_0055", "ABL_Info_0055", 9, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, 13) },
            { 56, new Ability(56, "ABL_Name_0056", "ABL_Info_0056", 9, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, 23) },
            { 57, new Ability(57, "ABL_Name_0057", "ABL_Info_0057", 1102, 1, -1, new float[] { 0.1f,0f,0f,0 }, 1, -1) },
            { 58, new Ability(58, "ABL_Name_0058", "ABL_Info_0058", 1102, 1, -1, new float[] { 0.1f,0f,0f,0 }, 2, -1) },
            { 59, new Ability(59, "ABL_Name_0059", "ABL_Info_0059", 1102, 1, -1, new float[] { 0.1f,0f,0f,0 }, 3, -1) },
            { 60, new Ability(60, "ABL_Name_0060", "ABL_Info_0060", 1102, 1, -1, new float[] { 0.1f,0f,0f,0 }, 4, -1) },
            { 61, new Ability(61, "ABL_Name_0061", "ABL_Info_0061", 1102, 1, -1, new float[] { 0.1f,0f,0f,0 }, 5, -1) },
            { 62, new Ability(62, "ABL_Name_0062", "ABL_Info_0062", 1102, 1, -1, new float[] { 0.1f,0f,0f,0 }, 6, -1) },
            { 63, new Ability(63, "ABL_Name_0063", "ABL_Info_0063", 1102, 1, -1, new float[] { 0.1f,0f,0f,0 }, 7, -1) },
            { 64, new Ability(64, "ABL_Name_0064", "ABL_Info_0064", 1102, 1, -1, new float[] { 0.1f,0f,0f,0 }, 8, -1) },
            { 65, new Ability(65, "ABL_Name_0065", "ABL_Info_0065", 1102, 1, -1, new float[] { 0.1f,0f,0f,0 }, 9, -1) },
            { 66, new Ability(66, "ABL_Name_0066", "ABL_Info_0066", 1102, 1, -1, new float[] { 0.1f,0f,0f,0 }, 10, -1) },
            { 67, new Ability(67, "ABL_Name_0067", "ABL_Info_0067", 1102, 1, -1, new float[] { 0.1f,0f,0f,0 }, 11, -1) },
            { 68, new Ability(68, "ABL_Name_0068", "ABL_Info_0068", 1102, 1, -1, new float[] { 0.1f,0f,0f,0 }, 12, -1) },
            { 69, new Ability(69, "ABL_Name_0069", "ABL_Info_0069", 1102, 1, -1, new float[] { 0.1f,0f,0f,0 }, 13, -1) },
            { 70, new Ability(70, "ABL_Name_0070", "ABL_Info_0070", 1102, 1, -1, new float[] { 0.1f,0f,0f,0 }, 14, -1) },
            { 71, new Ability(71, "ABL_Name_0071", "ABL_Info_0071", 1100, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 72, new Ability(72, "ABL_Name_0072", "ABL_Info_0072", 1100, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 73, new Ability(73, "ABL_Name_0073", "ABL_Info_0073", 1100, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 74, new Ability(74, "ABL_Name_0074", "ABL_Info_0074", 1100, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 75, new Ability(75, "ABL_Name_0075", "ABL_Info_0075", 1100, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 76, new Ability(76, "ABL_Name_0076", "ABL_Info_0076", 1100, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 77, new Ability(77, "ABL_Name_0077", "ABL_Info_0077", 1100, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 78, new Ability(78, "ABL_Name_0078", "ABL_Info_0078", 1100, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 79, new Ability(79, "ABL_Name_0079", "ABL_Info_0079", 1100, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 80, new Ability(80, "ABL_Name_0080", "ABL_Info_0080", 1100, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 81, new Ability(81, "ABL_Name_0081", "ABL_Info_0081", 1100, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 82, new Ability(82, "ABL_Name_0082", "ABL_Info_0082", 1100, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 83, new Ability(83, "ABL_Name_0083", "ABL_Info_0083", 1100, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 84, new Ability(84, "ABL_Name_0084", "ABL_Info_0084", 1100, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 85, new Ability(85, "ABL_Name_0085", "ABL_Info_0085", 100, 0, -1, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 86, new Ability(86, "ABL_Name_0086", "ABL_Info_0086", 100, 0, -1, new float[] { 0.2f,0f,0f,0 }, -1, -1) },
            { 87, new Ability(87, "ABL_Name_0087", "ABL_Info_0087", 100, 0, -1, new float[] { 0.4f,0f,0f,0 }, -1, -1) },
            { 88, new Ability(88, "ABL_Name_0088", "ABL_Info_0088", 100, 0, 1, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 89, new Ability(89, "ABL_Name_0089", "ABL_Info_0089", 100, 0, 1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 90, new Ability(90, "ABL_Name_0090", "ABL_Info_0090", 100, 0, 1, new float[] { 0.5f,0f,0f,0 }, -1, -1) },
            { 91, new Ability(91, "ABL_Name_0091", "ABL_Info_0091", 100, 0, 3, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 92, new Ability(92, "ABL_Name_0092", "ABL_Info_0092", 100, 0, 3, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 93, new Ability(93, "ABL_Name_0093", "ABL_Info_0093", 100, 0, 3, new float[] { 0.5f,0f,0f,0 }, -1, -1) },
            { 94, new Ability(94, "ABL_Name_0094", "ABL_Info_0094", 100, 0, 2, new float[] { 0.6f,0f,0f,0 }, -1, -1) },
            { 95, new Ability(95, "ABL_Name_0095", "ABL_Info_0095", 100, 0, 4, new float[] { 0.15f,0f,0f,0 }, -1, -1) },
            { 96, new Ability(96, "ABL_Name_0096", "ABL_Info_0096", 100, 0, 4, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 97, new Ability(97, "ABL_Name_0097", "ABL_Info_0097", 100, 0, 4, new float[] { 0.45f,0f,0f,0 }, -1, -1) },
            { 98, new Ability(98, "ABL_Name_0098", "ABL_Info_0098", 100, 0, 5, new float[] { 0.45f,0f,0f,0 }, -1, -1) },
            { 99, new Ability(99, "ABL_Name_0099", "ABL_Info_0099", 100, 0, 5, new float[] { 0.7f,0f,0f,0 }, -1, -1) },
            { 100, new Ability(100, "ABL_Name_0100", "ABL_Info_0100", 100, 0, 6, new float[] { 1f,0f,0f,0 }, -1, -1) },
            { 101, new Ability(101, "ABL_Name_0101", "ABL_Info_0101", 100, 0, 7, new float[] { 0.8f,0f,0f,0 }, -1, -1) },
            { 102, new Ability(102, "ABL_Name_0102", "ABL_Info_0102", 102, 0, -1, new float[] { 0.25f,0.2f,0f,0 }, -1, -1) },
            { 103, new Ability(103, "ABL_Name_0103", "ABL_Info_0103", 102, 0, 1, new float[] { 0.25f,0.5f,0f,0 }, -1, -1) },
            { 104, new Ability(104, "ABL_Name_0104", "ABL_Info_0104", 103, 0, -1, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 105, new Ability(105, "ABL_Name_0105", "ABL_Info_0105", 103, 0, -1, new float[] { 0.2f,0f,0f,0 }, -1, -1) },
            { 106, new Ability(106, "ABL_Name_0106", "ABL_Info_0106", 409, 1, -1, new float[] { 0.5f,0.5f,0f,0 }, -1, -1) },
            { 107, new Ability(107, "ABL_Name_0107", "ABL_Info_0107", 300, 0, -1, new float[] { 0.05f,0f,0f,0 }, -1, -1) },
            { 108, new Ability(108, "ABL_Name_0108", "ABL_Info_0108", 300, 0, -1, new float[] { 0.15f,0f,0f,0 }, -1, -1) },
            { 109, new Ability(109, "ABL_Name_0109", "ABL_Info_0109", 300, 0, -1, new float[] { 0.35f,0f,0f,0 }, -1, -1) },
            { 110, new Ability(110, "ABL_Name_0110", "ABL_Info_0110", 300, 0, -1, new float[] { 1f,0f,0f,0 }, -1, -1) },
            { 111, new Ability(111, "ABL_Name_0111", "ABL_Info_0111", 300, 0, 1, new float[] { 0.2f,0f,0f,0 }, -1, -1) },
            { 112, new Ability(112, "ABL_Name_0112", "ABL_Info_0112", 300, 0, 1, new float[] { 0.4f,0f,0f,0 }, -1, -1) },
            { 113, new Ability(113, "ABL_Name_0113", "ABL_Info_0113", 300, 0, 1, new float[] { 0.7f,0f,0f,0 }, -1, -1) },
            { 114, new Ability(114, "ABL_Name_0114", "ABL_Info_0114", 300, 0, 2, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 115, new Ability(115, "ABL_Name_0115", "ABL_Info_0115", 300, 0, 2, new float[] { 0.5f,0f,0f,0 }, -1, -1) },
            { 116, new Ability(116, "ABL_Name_0116", "ABL_Info_0116", 300, 0, 3, new float[] { 0.2f,0f,0f,0 }, -1, -1) },
            { 117, new Ability(117, "ABL_Name_0117", "ABL_Info_0117", 300, 0, 3, new float[] { 0.4f,0f,0f,0 }, -1, -1) },
            { 118, new Ability(118, "ABL_Name_0118", "ABL_Info_0118", 300, 0, 3, new float[] { 0.7f,0f,0f,0 }, -1, -1) },
            { 119, new Ability(119, "ABL_Name_0119", "ABL_Info_0119", 300, 0, 4, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 120, new Ability(120, "ABL_Name_0120", "ABL_Info_0120", 300, 0, 4, new float[] { 0.25f,0f,0f,0 }, -1, -1) },
            { 121, new Ability(121, "ABL_Name_0121", "ABL_Info_0121", 300, 0, 4, new float[] { 0.75f,0f,0f,0 }, -1, -1) },
            { 122, new Ability(122, "ABL_Name_0122", "ABL_Info_0122", 300, 0, 5, new float[] { 0.5f,0f,0f,0 }, -1, -1) },
            { 123, new Ability(123, "ABL_Name_0123", "ABL_Info_0123", 300, 0, 5, new float[] { 0.8f,0f,0f,0 }, -1, -1) },
            { 124, new Ability(124, "ABL_Name_0124", "ABL_Info_0124", 300, 0, 6, new float[] { 1.2f,0f,0f,0 }, -1, -1) },
            { 125, new Ability(125, "ABL_Name_0125", "ABL_Info_0125", 300, 0, 7, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 126, new Ability(126, "ABL_Name_0126", "ABL_Info_0126", 300, 0, 7, new float[] { 0.9f,0f,0f,0 }, -1, -1) },
            { 127, new Ability(127, "Com_Blank", "Com_Blank", 405, 0, -1, new float[] { 5f,0f,0f,0 }, -1, -1) },
            { 128, new Ability(128, "Com_Blank", "Com_Blank", 405, 0, -1, new float[] { 10f,0f,0f,0 }, -1, -1) },
            { 129, new Ability(129, "Com_Blank", "Com_Blank", 405, 0, -1, new float[] { 30f,0f,0f,0 }, -1, -1) },
            { 130, new Ability(130, "ABL_Name_0130", "ABL_Info_0130", 302, 0, -1, new float[] { 0.01f,8f,0f,0 }, -1, -1) },
            { 131, new Ability(131, "ABL_Name_0131", "ABL_Info_0131", 302, 0, -1, new float[] { 0.015f,8f,0f,0 }, -1, -1) },
            { 132, new Ability(132, "ABL_Name_0132", "ABL_Info_0132", 302, 0, -1, new float[] { 0.02f,8f,0f,0 }, -1, -1) },
            { 133, new Ability(133, "ABL_Name_0133", "ABL_Info_0133", 303, 0, -1, new float[] { 0.15f,0f,0f,0 }, -1, -1) },
            { 134, new Ability(134, "ABL_Name_0134", "ABL_Info_0134", 303, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 135, new Ability(135, "ABL_Name_0135", "ABL_Info_0135", 304, 0, -1, new float[] { 0.006f,0f,0f,0 }, -1, -1) },
            { 136, new Ability(136, "ABL_Name_0136", "ABL_Info_0136", 301, 1, -1, new float[] { 0.025f,0f,0f,0 }, -1, -1) },
            { 137, new Ability(137, "ABL_Name_0137", "ABL_Info_0137", 301, 1, -1, new float[] { 0.05f,0f,0f,0 }, -1, -1) },
            { 138, new Ability(138, "ABL_Name_0138", "ABL_Info_0138", 301, 1, -1, new float[] { 0.075f,0f,0f,0 }, -1, -1) },
            { 139, new Ability(139, "ABL_Name_0139", "ABL_Info_0139", 301, 1, -1, new float[] { 0.15f,0f,0f,0 }, -1, -1) },
            { 140, new Ability(140, "ABL_Name_0140", "ABL_Info_0140", 603, 1, -1, new float[] { 1f,0f,0f,0 }, -1, -1) },
            { 141, new Ability(141, "ABL_Name_0141", "ABL_Info_0141", 603, 1, -1, new float[] { 3f,0f,0f,0 }, -1, -1) },
            { 142, new Ability(142, "ABL_Name_0142", "ABL_Info_0142", 603, 1, -1, new float[] { 5f,0f,0f,0 }, -1, -1) },
            { 143, new Ability(143, "ABL_Name_0143", "ABL_Info_0143", 603, 1, 1, new float[] { 5f,0f,0f,0 }, -1, -1) },
            { 144, new Ability(144, "ABL_Name_0144", "ABL_Info_0144", 603, 1, 2, new float[] { 5f,0f,0f,0 }, -1, -1) },
            { 145, new Ability(145, "ABL_Name_0145", "ABL_Info_0145", 603, 1, 3, new float[] { 5f,0f,0f,0 }, -1, -1) },
            { 146, new Ability(146, "ABL_Name_0146", "ABL_Info_0146", 603, 1, 4, new float[] { 5f,0f,0f,0 }, -1, -1) },
            { 147, new Ability(147, "ABL_Name_0147", "ABL_Info_0147", 603, 1, 5, new float[] { 5f,0f,0f,0 }, -1, -1) },
            { 148, new Ability(148, "ABL_Name_0148", "ABL_Info_0148", 603, 1, 6, new float[] { 5f,0f,0f,0 }, -1, -1) },
            { 149, new Ability(149, "ABL_Name_0149", "ABL_Info_0149", 603, 1, 7, new float[] { 5f,0f,0f,0 }, -1, -1) },
            { 150, new Ability(150, "ABL_Name_0150", "ABL_Info_0150", 406, 1, -1, new float[] { 20f,0f,0f,0 }, -1, -1) },
            { 151, new Ability(151, "ABL_Name_0151", "ABL_Info_0151", 407, 1, -1, new float[] { 0.6f,10f,0f,0 }, -1, -1) },
            { 152, new Ability(152, "ABL_Name_0152", "ABL_Info_0152", 600, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 153, new Ability(153, "ABL_Name_0153", "ABL_Info_0153", 601, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 154, new Ability(154, "ABL_Name_0154", "ABL_Info_0154", 602, 1, -1, new float[] { 0.05f,0.05f,0f,0 }, -1, -1) },
            { 155, new Ability(155, "ABL_Name_0155", "ABL_Info_0155", 401, 1, -1, new float[] { 0.25f,0.2f,0.2f,0 }, -1, -1) },
            { 156, new Ability(156, "ABL_Name_0156", "ABL_Info_0156", 403, 1, -1, new float[] { 0f,0f,0f,0 }, -1, -1) },
            { 157, new Ability(157, "ABL_Name_0157", "ABL_Info_0157", 404, 1, -1, new float[] { 0f,0f,0f,0 }, -1, -1) },
            { 158, new Ability(158, "ABL_Name_0158", "ABL_Info_0158", 1101, 0, -1, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 159, new Ability(159, "ABL_Name_0159", "ABL_Info_0159", 800, 0, -1, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 160, new Ability(160, "ABL_Name_0160", "ABL_Info_0160", 800, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 161, new Ability(161, "ABL_Name_0161", "ABL_Info_0161", 800, 0, -1, new float[] { 0.5f,0f,0f,0 }, -1, -1) },
            { 162, new Ability(162, "ABL_Name_0162", "ABL_Info_0162", 801, 0, -1, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 163, new Ability(163, "ABL_Name_0163", "ABL_Info_0163", 801, 0, -1, new float[] { 0.2f,0f,0f,0 }, -1, -1) },
            { 164, new Ability(164, "ABL_Name_0164", "ABL_Info_0164", 801, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 165, new Ability(165, "ABL_Name_0165", "ABL_Info_0165", 802, 0, -1, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 166, new Ability(166, "ABL_Name_0166", "ABL_Info_0166", 802, 0, -1, new float[] { 0.15f,0f,0f,0 }, -1, -1) },
            { 167, new Ability(167, "ABL_Name_0167", "ABL_Info_0167", 802, 0, -1, new float[] { 0.2f,0f,0f,0 }, -1, -1) },
            { 168, new Ability(168, "ABL_Name_0168", "ABL_Info_0168", 803, 0, -1, new float[] { 0.2f,0f,0f,0 }, -1, -1) },
            { 169, new Ability(169, "ABL_Name_0169", "ABL_Info_0169", 803, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 170, new Ability(170, "ABL_Name_0170", "ABL_Info_0170", 803, 0, -1, new float[] { 0.5f,0f,0f,0 }, -1, -1) },
            { 171, new Ability(171, "ABL_Name_0171", "ABL_Info_0171", 804, 0, -1, new float[] { 0.2f,0f,0f,0 }, -1, -1) },
            { 172, new Ability(172, "ABL_Name_0172", "ABL_Info_0172", 804, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 173, new Ability(173, "ABL_Name_0173", "ABL_Info_0173", 804, 0, -1, new float[] { 0.5f,0f,0f,0 }, -1, -1) },
            { 174, new Ability(174, "ABL_Name_0174", "ABL_Info_0174", 805, 0, -1, new float[] { 0.2f,0f,0f,0 }, -1, -1) },
            { 175, new Ability(175, "ABL_Name_0175", "ABL_Info_0175", 805, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 176, new Ability(176, "ABL_Name_0176", "ABL_Info_0176", 805, 0, -1, new float[] { 0.5f,0f,0f,0 }, -1, -1) },
            { 177, new Ability(177, "ABL_Name_0177", "ABL_Info_0177", 806, 0, -1, new float[] { 0.2f,0f,0f,0 }, -1, -1) },
            { 178, new Ability(178, "ABL_Name_0178", "ABL_Info_0178", 806, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 179, new Ability(179, "ABL_Name_0179", "ABL_Info_0179", 806, 0, -1, new float[] { 0.5f,0f,0f,0 }, -1, -1) },
            { 180, new Ability(180, "ABL_Name_0180", "ABL_Info_0180", 807, 0, -1, new float[] { 2f,0.5f,0f,0 }, -1, -1) },
            { 181, new Ability(181, "ABL_Name_0181", "ABL_Info_0181", 807, 0, -1, new float[] { 8f,0.5f,0f,0 }, -1, -1) },
            { 182, new Ability(182, "ABL_Name_0182", "ABL_Info_0182", 807, 0, -1, new float[] { 1f,0.5f,0f,0 }, -1, -1) },
            { 183, new Ability(183, "ABL_Name_0183", "ABL_Info_0183", 500, 0, -1, new float[] { 1.3f,0f,0f,0 }, -1, -1) },
            { 184, new Ability(184, "ABL_Name_0184", "ABL_Info_0184", 200, 0, -1, new float[] { 0f,0f,0f,0 }, -1, -1) },
            { 185, new Ability(185, "ABL_Name_0185", "ABL_Info_0185", 202, 1, -1, new float[] { 0.8f,0f,0f,0 }, -1, -1) },
            { 186, new Ability(186, "ABL_Name_0186", "ABL_Info_0186", 504, 0, -1, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 187, new Ability(187, "ABL_Name_0187", "ABL_Info_0187", 502, 1, -1, new float[] { 0.05f,0f,0f,0 }, -1, -1) },
            { 188, new Ability(188, "ABL_Name_0188", "ABL_Info_0188", 502, 1, -1, new float[] { 0.075f,0f,0f,0 }, -1, -1) },
            { 189, new Ability(189, "ABL_Name_0189", "ABL_Info_0189", 502, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 190, new Ability(190, "ABL_Name_0190", "ABL_Info_0190", 503, 0, -1, new float[] { 0.5f,0f,0f,0 }, -1, -1) },
            { 191, new Ability(191, "ABL_Name_0191", "ABL_Info_0191", 503, 0, -1, new float[] { 0f,0f,0f,0 }, -1, -1) },
            { 192, new Ability(192, "ABL_Name_0192", "ABL_Info_0192", 408, 1, -1, new float[] { 0.3f,0.5f,0f,0 }, -1, -1) },
            { 193, new Ability(193, "ABL_Name_0193", "ABL_Info_0193", 1500, 1, -1, new float[] { 0.05f,0f,0f,0 }, -1, -1) },
            { 194, new Ability(194, "ABL_Name_0194", "ABL_Info_0194", 1500, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 195, new Ability(195, "ABL_Name_0195", "ABL_Info_0195", 1501, 1, -1, new float[] { 0.1f,0f,0f,0 }, -1, -1) },
            { 196, new Ability(196, "ABL_Name_0196", "ABL_Info_0196", 3000, 1, -1, new float[] { 0f,0f,0f,0 }, -1, -1) },
            { 197, new Ability(197, "ABL_Name_0197", "ABL_Info_0197", 1200, 0, -1, new float[] { 0.05f,0f,0f,0 }, -1, -1) },
            { 198, new Ability(198, "ABL_Name_0198", "ABL_Info_0198", 1201, 0, -1, new float[] { 0.05f,0f,0f,0 }, -1, -1) },
            { 199, new Ability(199, "ABL_Name_0199", "ABL_Info_0199", 1202, 0, -1, new float[] { 0.025f,0f,0f,0 }, -1, -1) },
            { 200, new Ability(200, "ABL_Name_0200", "ABL_Info_0200", 1502, 1, -1, new float[] { 0f,0f,0f,0 }, -1, -1) },
            { 201, new Ability(201, "Com_Blank", "Com_Blank", 808, 0, -1, new float[] { 0.2f,0f,0f,0 }, -1, -1) },
            { 202, new Ability(202, "Com_Blank", "Com_Blank", 808, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 203, new Ability(203, "Com_Blank", "Com_Blank", 808, 0, -1, new float[] { 0.5f,0f,0f,0 }, -1, -1) },
            { 204, new Ability(204, "ABL_Name_0231", "ABL_Info_0231", 1100, 0, -1, new float[] { 0.3f,0f,0f,0 }, -1, -1) },
            { 1001, new Ability(1001, "ABL_Name_0201", "ABL_Info_0201", 2000, 0, -1, new float[] { 0f,0f,0f,0 }, -1, -1) },
            { 1002, new Ability(1002, "ABL_Name_0202", "ABL_Info_0202", 2001, 0, -1, new float[] { 0f,0f,0f,0 }, -1, -1) },
            { 1003, new Ability(1003, "ABL_Name_0210", "ABL_Info_0210", 2002, 0, -1, new float[] { 0f,0f,0f,0 }, -1, -1) },
            { 1004, new Ability(1004, "ABL_Name_0208", "ABL_Info_0208", 2003, 0, -1, new float[] { 0f,0f,0f,0 }, -1, -1) },
            { 1005, new Ability(1005, "ABL_Name_0210", "ABL_Info_0210", 2004, 0, -1, new float[] { 0.18f,0f,0f,0 }, -1, -1) },
            { 1006, new Ability(1006, "Com_Blank", "Com_Blank", 2004, 0, -1, new float[] { 0.125f,0f,0f,0 }, -1, -1) },
            { 1007, new Ability(1007, "ABL_Name_0211", "ABL_Info_0211", 2005, 0, -1, new float[] { 20f,0f,0f,0 }, -1, -1) },
            { 1008, new Ability(1008, "ABL_Name_0211", "ABL_Info_0211", 2006, 0, -1, new float[] { 20f,0f,0f,0 }, -1, -1) },
            { 1009, new Ability(1009, "Com_Blank", "Com_Blank", 2009, 0, -1, new float[] { 0.5f,0.5f,0f,0 }, -1, -1) },
            { 1010, new Ability(1010, "ABL_Name_0213", "ABL_Info_0213", 2010, 0, -1, new float[] { 20f,0f,0f,0 }, -1, -1) },
            { 1011, new Ability(1011, "ABL_Name_0209", "ABL_Info_0209", 2011, 0, -1, new float[] { 0f,0f,0f,0 }, -1, -1) },
            { 1012, new Ability(1012, "ABL_Name_0214", "ABL_Info_0214", 1003, 0, -1, new float[] { 0.5f,0f,0f,0 }, -1, -1) },
            { 1013, new Ability(1013, "ABL_Name_0216", "ABL_Info_0216", 3, 0, -1, new float[] { 0.25f,0.5f,0f,0 }, -1, -1) },
            { 1014, new Ability(1014, "ABL_Name_0217", "ABL_Info_0217", 1201, 0, -1, new float[] { 0.5f,0f,0f,0 }, -1, -1) },
            { 1015, new Ability(1015, "ABL_Name_0215", "ABL_Info_0215", 1004, 0, -1, new float[] { 0.5f,0f,0f,0 }, -1, -1) },
            { 2000, new Ability(2000, "ABL_Name_0218", "ABL_Info_0218", 4000, 0, -1, new float[] { 6f,2f,0f,0 }, -1, -1) },
            { 2001, new Ability(2001, "ABL_Name_0219", "ABL_Info_0219", 4001, 0, -1, new float[] { 4f,0.5f,0f,0 }, -1, -1) },
            { 2002, new Ability(2002, "ABL_Name_0220", "ABL_Info_0220", 4000, 0, -1, new float[] { 3f,1f,0f,0 }, -1, -1) },
            { 2003, new Ability(2003, "ABL_Name_0221", "ABL_Info_0221", 4002, 0, -1, new float[] { 2f,0.1f,0f,0 }, -1, -1) },
            { 2004, new Ability(2004, "ABL_Name_0222", "ABL_Info_0222", 4003, 0, -1, new float[] { 2f,1f,0f,0 }, -1, -1) },
            { 2005, new Ability(2005, "ABL_Name_0223", "ABL_Info_0223", 4000, 0, -1, new float[] { 2f,0.5f,0f,0 }, -1, -1) },
            { 2006, new Ability(2006, "ABL_Name_0224", "ABL_Info_0224", 4004, 0, -1, new float[] { 2f,1f,0f,0 }, -1, -1) },
            { 2007, new Ability(2007, "ABL_Name_0225", "ABL_Info_0225", 4002, 0, -1, new float[] { 2f,0.5f,0f,0 }, -1, -1) },
            { 2008, new Ability(2008, "ABL_Name_0226", "ABL_Info_0226", 4005, 0, -1, new float[] { 2f,0.5f,0f,0 }, -1, -1) },
            { 2009, new Ability(2009, "ABL_Name_0227", "ABL_Info_0227", 4006, 0, -1, new float[] { 2f,1f,0f,0 }, -1, -1) },
            { 2010, new Ability(2010, "ABL_Name_0233", "ABL_Info_0233", 2012, 0, -1, new float[] { 0f,0f,0f,0 }, -1, -1) },
            { 2011, new Ability(2011, "ABL_Name_0232", "ABL_Info_0232", 903, 0, -1, new float[] { 3f,3f,0f,0 }, -1, -1) },
            { 9000, new Ability(9000, "Com_Blank", "Com_Blank", -1, -1, -1, new float[] { 0f,1f,0f,0 }, -1, -1) },
            { 9001, new Ability(9001, "Com_Blank", "Com_Blank", -1, -1, -1, new float[] { 0f,1f,1f,0 }, -1, -1) },
            { 9002, new Ability(9002, "Com_Blank", "Com_Blank", 501, 0, -1, new float[] { 1.5f,1f,1f,0 }, -1, -1) },
            { 9003, new Ability(9003, "Com_Blank", "Com_Blank", 9, 1, -1, new float[] { 0.2f,0f,0f,0 }, -1, 14) },
            { 9004, new Ability(9004, "Com_Blank", "Com_Blank", 9, 1, -1, new float[] { 0.2f,0f,0f,0 }, -1, 15) },
            { 9005, new Ability(9005, "Com_Blank", "Com_Blank", 9, 1, -1, new float[] { 0.2f,0f,0f,0 }, -1, 16) },
            { 9006, new Ability(9006, "Com_Blank", "Com_Blank", 9, 1, -1, new float[] { 0.2f,0f,0f,0 }, -1, 17) },
            { 9007, new Ability(9007, "Com_Blank", "Com_Blank", 9, 1, -1, new float[] { 0.2f,0f,0f,0 }, -1, 18) },
            { 9008, new Ability(9008, "Com_Blank", "Com_Blank", 9, 1, -1, new float[] { 0.2f,0f,0f,0 }, -1, 19) },
            { 9009, new Ability(9009, "Com_Blank", "Com_Blank", 9, 1, -1, new float[] { 0.2f,0f,0f,0 }, -1, 20) },
            { 9010, new Ability(9010, "Com_Blank", "Com_Blank", 9, 1, -1, new float[] { 0.2f,0f,0f,0 }, -1, 21) },
            { 9011, new Ability(9011, "Com_Blank", "Com_Blank", 9, 1, -1, new float[] { 0.2f,0f,0f,0 }, -1, 22) },
            { 9012, new Ability(9012, "Com_Blank", "Com_Blank", 9, 1, -1, new float[] { 0.2f,0f,0f,0 }, -1, 24) },
            { 9013, new Ability(9013, "Com_Blank", "Com_Blank", 9, 1, -1, new float[] { 0.2f,0f,0f,0 }, -1, 25) }
        };

        private readonly Dictionary<sbyte, string> PsychKeys = new Dictionary<sbyte, string>()
        {
            { 1, "X" },
            { 2, "Y" },
            { 3, "L" },
            { 4, "R" },
            { 5, "ZL" },
            { 6, "ZR" }
        };

        private readonly Dictionary<sbyte, PinAttackElement> AttackElements = new Dictionary<sbyte, PinAttackElement>()
        {
            { 0,         new PinAttackElement(0, "PSY_Element_Name_000", "Attribute_icon_0", "MashupBadge_15", 1) },
            { 1,         new PinAttackElement(1, "PSY_Element_Name_001", "Attribute_icon_1", "MashupBadge_12", 2) },
            { 2,         new PinAttackElement(2, "PSY_Element_Name_002", "Attribute_icon_2", "MashupBadge_13", 3) },
            { 3,         new PinAttackElement(3, "PSY_Element_Name_003", "Attribute_icon_3", "MashupBadge_05", 4) },
            { 4,         new PinAttackElement(4, "PSY_Element_Name_004", "Attribute_icon_4", "MashupBadge_14", 5) },
            { 5,         new PinAttackElement(5, "PSY_Element_Name_005", "Attribute_icon_5", "MashupBadge_03", 6) },
            { 6,         new PinAttackElement(6, "PSY_Element_Name_006", "Attribute_icon_6", "MashupBadge_07", 7) },
            { 7,         new PinAttackElement(7, "PSY_Element_Name_007", "Attribute_icon_7", "MashupBadge_06", 15) },
            { 8,         new PinAttackElement(8, "PSY_Element_Name_008", "Attribute_icon_8", "MashupBadge_04", 10) },
            { 9,         new PinAttackElement(9, "PSY_Element_Name_009", "Attribute_icon_9", "MashupBadge_01", 12) },
            { 10,         new PinAttackElement(10, "PSY_Element_Name_010", "Attribute_icon_10", "MashupBadge_08", 11) },
            { 11,         new PinAttackElement(11, "PSY_Element_Name_011", "Attribute_icon_11", "MashupBadge_09", 14) },
            { 12,         new PinAttackElement(12, "PSY_Element_Name_012", "Attribute_icon_12", "MashupBadge_11", 9) },
            { 13,         new PinAttackElement(13, "PSY_Element_Name_013", "Attribute_icon_13", "MashupBadge_02", 13) },
            { 14,         new PinAttackElement(14, "PSY_Element_Name_000", "", "", 0) },
            { 15,         new PinAttackElement(15, "PSY_Element_Name_000", "", "", 0) },
            { 16,         new PinAttackElement(16, "PSY_Element_Name_000", "", "", 0) },
            { 17,         new PinAttackElement(17, "PSY_Element_Name_000", "", "", 0) },
            { 18,         new PinAttackElement(18, "PSY_Element_Name_000", "", "", 0) },
            { 19,         new PinAttackElement(19, "PSY_Element_Name_000", "", "", 0) },
            { 20,         new PinAttackElement(20, "PSY_Element_Name_000", "", "", 0) },
            { 21,         new PinAttackElement(21, "PSY_Element_Name_000", "", "", 0) },
            { 22,         new PinAttackElement(22, "PSY_Element_Name_000", "", "", 0) },
            { 23,         new PinAttackElement(23, "PSY_Element_Name_014", "Attribute_icon_14", "MashupBadge_10", 8) },
            { 24,         new PinAttackElement(24, "PSY_Element_Name_000", "", "", 0) },
            { 25,         new PinAttackElement(25, "PSY_Element_Name_000", "", "", 0) }
        };

        private readonly Dictionary<byte, PinLevelUpTable> LevelUpTables = new Dictionary<byte, PinLevelUpTable>()
        {
            { 1, new PinLevelUpTable(1, 1, new uint[] { 0,0,0,0,0,0,0 }) },
            { 2, new PinLevelUpTable(2, 2, new uint[] { 16,22,32,35,39,42,0 }) },
            { 3, new PinLevelUpTable(3, 3, new uint[] { 35,49,71,77,85,92,0 }) },
            { 4, new PinLevelUpTable(4, 4, new uint[] { 58,81,117,128,141,152,0 }) },
            { 5, new PinLevelUpTable(5, 5, new uint[] { 86,120,173,189,208,225,0 }) },
            { 6, new PinLevelUpTable(6, 6, new uint[] { 116,163,234,256,282,305,0 }) },
            { 7, new PinLevelUpTable(7, 7, new uint[] { 149,210,301,330,363,393,0 }) },
            { 8, new PinLevelUpTable(8, 8, new uint[] { 186,262,375,412,452,490,0 }) },
            { 9, new PinLevelUpTable(9, 9, new uint[] { 227,319,457,502,550,596,0 }) },
            { 10, new PinLevelUpTable(10, 10, new uint[] { 270,379,543,596,653,708,0 }) },
            { 11, new PinLevelUpTable(11, 11, new uint[] { 315,442,633,695,761,825,0 }) },
            { 12, new PinLevelUpTable(12, 12, new uint[] { 362,508,728,799,875,948,0 }) },
            { 13, new PinLevelUpTable(13, 13, new uint[] { 411,577,827,908,994,1077,0 }) },
            { 14, new PinLevelUpTable(14, 14, new uint[] { 463,650,931,1023,1119,1213,0 }) },
            { 15, new PinLevelUpTable(15, 15, new uint[] { 518,727,1041,1144,1251,1356,0 }) },
            { 16, new PinLevelUpTable(16, 16, new uint[] { 575,807,1156,1271,1389,1506,0 }) },
            { 17, new PinLevelUpTable(17, 17, new uint[] { 635,892,1277,1404,1534,1663,0 }) },
            { 18, new PinLevelUpTable(18, 18, new uint[] { 698,981,1404,1544,1687,1828,0 }) },
            { 19, new PinLevelUpTable(19, 19, new uint[] { 764,1074,1537,1691,1847,2002,0 }) },
            { 20, new PinLevelUpTable(20, 20, new uint[] { 834,1172,1677,1845,2015,2184,0 }) },
            { 21, new PinLevelUpTable(21, 21, new uint[] { 907,1275,1824,2007,2192,2375,0 }) },
            { 22, new PinLevelUpTable(22, 22, new uint[] { 984,1383,1979,2177,2378,2576,0 }) },
            { 23, new PinLevelUpTable(23, 23, new uint[] { 1065,1496,2141,2356,2573,2787,0 }) },
            { 24, new PinLevelUpTable(24, 24, new uint[] { 1150,1615,2311,2544,2778,3009,0 }) },
            { 25, new PinLevelUpTable(25, 25, new uint[] { 1239,1740,2490,2741,2993,3242,0 }) },
            { 26, new PinLevelUpTable(26, 26, new uint[] { 1333,1871,2678,2948,3219,3486,0 }) },
            { 27, new PinLevelUpTable(27, 27, new uint[] { 1431,2009,2875,3165,3456,3743,0 }) },
            { 28, new PinLevelUpTable(28, 28, new uint[] { 1534,2154,3082,3393,3705,4013,0 }) },
            { 29, new PinLevelUpTable(29, 29, new uint[] { 1643,2306,3300,3632,3966,4296,0 }) },
            { 30, new PinLevelUpTable(30, 30, new uint[] { 1757,2466,3529,3883,4240,4593,0 }) },
            { 31, new PinLevelUpTable(31, 31, new uint[] { 1877,2634,3769,4147,4528,4905,0 }) },
            { 32, new PinLevelUpTable(32, 32, new uint[] { 2003,2810,4021,4424,4831,5233,0 }) },
            { 33, new PinLevelUpTable(33, 33, new uint[] { 2135,2995,4286,4715,5149,5577,0 }) },
            { 34, new PinLevelUpTable(34, 34, new uint[] { 2274,3189,4564,5021,5483,5938,0 }) },
            { 35, new PinLevelUpTable(35, 35, new uint[] { 2420,3393,4856,5342,5833,6318,0 }) },
            { 36, new PinLevelUpTable(36, 36, new uint[] { 2573,3607,5162,5679,6201,6717,0 }) },
            { 37, new PinLevelUpTable(37, 37, new uint[] { 2734,3832,5484,6033,6587,7136,0 }) },
            { 38, new PinLevelUpTable(38, 38, new uint[] { 2903,4068,5822,6405,6993,7575,0 }) },
            { 39, new PinLevelUpTable(39, 39, new uint[] { 3080,4316,6177,6795,7419,8036,0 }) },
            { 40, new PinLevelUpTable(40, 40, new uint[] { 3266,4577,6550,7205,7866,8521,0 }) },
            { 41, new PinLevelUpTable(41, 41, new uint[] { 3461,4851,6941,7635,8336,9030,0 }) },
            { 42, new PinLevelUpTable(42, 42, new uint[] { 3666,5138,7352,8087,8829,9564,0 }) },
            { 43, new PinLevelUpTable(43, 43, new uint[] { 3881,5440,7783,8562,9347,10125,0 }) },
            { 44, new PinLevelUpTable(44, 44, new uint[] { 4107,5757,8236,9060,9891,10714,0 }) },
            { 45, new PinLevelUpTable(45, 45, new uint[] { 4345,6090,8712,9583,10462,11333,0 }) },
            { 46, new PinLevelUpTable(46, 46, new uint[] { 4595,6440,9212,10133,11062,11983,0 }) },
            { 47, new PinLevelUpTable(47, 47, new uint[] { 4857,6807,9737,10710,11692,12665,0 }) },
            { 48, new PinLevelUpTable(48, 48, new uint[] { 5132,7192,10288,11316,12353,13381,0 }) },
            { 49, new PinLevelUpTable(49, 49, new uint[] { 5421,7597,10866,11952,13047,14133,0 }) },
            { 50, new PinLevelUpTable(50, 50, new uint[] { 5724,8022,11473,12620,13776,14923,0 }) },
            { 51, new PinLevelUpTable(51, 51, new uint[] { 6043,8468,12111,13322,14541,15752,0 }) },
            { 52, new PinLevelUpTable(52, 52, new uint[] { 6378,8937,12781,14059,15345,16623,0 }) },
            { 53, new PinLevelUpTable(53, 53, new uint[] { 6729,9429,13484,14832,16189,17537,0 }) },
            { 54, new PinLevelUpTable(54, 54, new uint[] { 7098,9946,14222,15644,17075,18497,0 }) },
            { 55, new PinLevelUpTable(55, 55, new uint[] { 7485,10489,14997,16497,18005,19505,0 }) },
            { 56, new PinLevelUpTable(56, 56, new uint[] { 7892,11059,15811,17392,18982,20563,0 }) },
            { 57, new PinLevelUpTable(57, 57, new uint[] { 8319,11657,16666,18332,20008,21674,0 }) },
            { 58, new PinLevelUpTable(58, 58, new uint[] { 8767,12285,17563,19319,21085,22841,0 }) },
            { 59, new PinLevelUpTable(59, 59, new uint[] { 9238,12945,18505,20356,22216,24066,0 }) },
            { 60, new PinLevelUpTable(60, 60, new uint[] { 9733,13638,19495,21445,23404,25353,0 }) },
            { 61, new PinLevelUpTable(61, 61, new uint[] { 10252,14365,20534,22588,24651,26704,0 }) },
            { 62, new PinLevelUpTable(62, 62, new uint[] { 10797,15129,21625,23788,25960,28122,0 }) },
            { 63, new PinLevelUpTable(63, 63, new uint[] { 11370,15931,22771,25048,27335,29611,0 }) },
            { 64, new PinLevelUpTable(64, 64, new uint[] { 11971,16773,23974,26371,28779,31175,0 }) },
            { 65, new PinLevelUpTable(65, 65, new uint[] { 12602,17657,25237,27760,30295,32817,0 }) },
            { 66, new PinLevelUpTable(66, 66, new uint[] { 13265,18585,26563,29219,31887,34541,0 }) },
            { 67, new PinLevelUpTable(67, 67, new uint[] { 13961,19560,27956,30751,33558,36352,0 }) },
            { 68, new PinLevelUpTable(68, 68, new uint[] { 14692,20583,29418,32360,35313,38253,0 }) },
            { 69, new PinLevelUpTable(69, 69, new uint[] { 15459,21658,30953,34049,37156,40249,0 }) },
            { 70, new PinLevelUpTable(70, 70, new uint[] { 16265,22786,32565,35822,39091,42345,0 }) },
            { 71, new PinLevelUpTable(71, 71, new uint[] { 17111,23971,34258,37684,41122,44546,0 }) },
            { 72, new PinLevelUpTable(72, 72, new uint[] { 17999,25215,36035,39639,43255,46857,0 }) },
            { 73, new PinLevelUpTable(73, 73, new uint[] { 18932,26521,37901,41692,45495,49283,0 }) },
            { 74, new PinLevelUpTable(74, 74, new uint[] { 19912,27893,39861,43848,47847,51831,0 }) },
            { 75, new PinLevelUpTable(75, 75, new uint[] { 20941,29333,41919,46112,50316,54506,0 }) },
            { 76, new PinLevelUpTable(76, 76, new uint[] { 22021,30845,44080,48489,52909,57315,0 }) },
            { 77, new PinLevelUpTable(77, 77, new uint[] { 23155,32433,46349,50985,55632,60264,0 }) },
            { 78, new PinLevelUpTable(78, 78, new uint[] { 24346,34100,48731,53605,58491,63361,0 }) },
            { 79, new PinLevelUpTable(79, 79, new uint[] { 25596,35851,51232,56356,61493,66613,0 }) },
            { 80, new PinLevelUpTable(80, 80, new uint[] { 26909,37689,53858,59245,64645,70027,0 }) },
            { 81, new PinLevelUpTable(81, 81, new uint[] { 28288,39619,56616,62279,67954,73612,0 }) },
            { 82, new PinLevelUpTable(82, 82, new uint[] { 29736,41646,59512,65464,71429,77376,0 }) },
            { 83, new PinLevelUpTable(83, 83, new uint[] { 31256,43774,62552,68809,75078,81329,0 }) },
            { 84, new PinLevelUpTable(84, 84, new uint[] { 32852,46009,65744,72321,78909,85479,0 }) },
            { 85, new PinLevelUpTable(85, 85, new uint[] { 34528,48355,69096,76008,82932,89837,0 }) },
            { 86, new PinLevelUpTable(86, 86, new uint[] { 36288,50819,72616,79880,87156,94413,0 }) },
            { 87, new PinLevelUpTable(87, 87, new uint[] { 38136,53406,76312,83945,91591,99218,0 }) },
            { 88, new PinLevelUpTable(88, 88, new uint[] { 40076,56122,80193,88214,96248,104263,0 }) },
            { 89, new PinLevelUpTable(89, 89, new uint[] { 42113,58974,84268,92696,101138,109560,0 }) },
            { 90, new PinLevelUpTable(90, 90, new uint[] { 44252,61969,88546,97402,106272,115122,0 }) },
            { 91, new PinLevelUpTable(91, 91, new uint[] { 46498,65113,93038,102344,111663,120962,0 }) },
            { 92, new PinLevelUpTable(92, 92, new uint[] { 48856,68415,97755,107533,117323,127094,0 }) },
            { 93, new PinLevelUpTable(93, 93, new uint[] { 51332,71882,102708,112981,123267,133533,0 }) },
            { 94, new PinLevelUpTable(94, 94, new uint[] { 53932,75522,107909,118702,129508,140294,0 }) },
            { 95, new PinLevelUpTable(95, 95, new uint[] { 56662,79344,113370,124709,136061,147393,0 }) },
            { 96, new PinLevelUpTable(96, 96, new uint[] { 59529,83357,119104,131016,142941,154847,0 }) },
            { 97, new PinLevelUpTable(97, 97, new uint[] { 62539,87571,125124,137638,150165,162674,0 }) },
            { 98, new PinLevelUpTable(98, 98, new uint[] { 65699,91996,131445,144592,157751,170892,0 }) },
            { 99, new PinLevelUpTable(99, 99, new uint[] { 69017,96642,138082,151893,165716,179521,0 }) },
            { 100, new PinLevelUpTable(100, 100, new uint[] { 72501,101520,145051,159559,174079,188581,0 }) },
        };

        #endregion

        #region QoL dictionaries
        private readonly Dictionary<ushort, ushort> Pin_GlobalIds = new Dictionary<ushort, ushort>();
        private readonly Dictionary<ushort, ushort> Clothing_GlobalIds = new Dictionary<ushort, ushort>();
        private readonly Dictionary<ushort, ushort> Food_GlobalIds = new Dictionary<ushort, ushort>();
        private readonly Dictionary<ushort, ushort> Book_GlobalIds = new Dictionary<ushort, ushort>();
        private readonly Dictionary<ushort, ushort> CD_GlobalIds = new Dictionary<ushort, ushort>();
        private readonly Dictionary<int, ushort> SaveIndexes_GlobalIds = new Dictionary<int, ushort>();
        #endregion

        public ItemManager()
        {
            foreach (IGameItem Item in GameItems.Values)
            {
                if (Item is PinItem)
                {
                    Pin_GlobalIds.Add(Item.ParticularId, Item.GlobalId);
                }
                else if (Item is ClothingItem)
                {
                    Clothing_GlobalIds.Add(Item.ParticularId, Item.GlobalId);
                }
                else if (Item is FoodItem)
                {
                    Food_GlobalIds.Add(Item.ParticularId, Item.GlobalId);
                }
                else if (Item is BookItem)
                {
                    Book_GlobalIds.Add(Item.ParticularId, Item.GlobalId);
                }
                else if (Item is CDItem)
                {
                    CD_GlobalIds.Add(Item.ParticularId, Item.GlobalId);
                }

                SaveIndexes_GlobalIds.Add(Item.CollectionSaveIndex, Item.GlobalId);
            }
        }

        #region Get Methods
        public Dictionary<ushort, IGameItem> GetItems()
        {
            return GameItems;
        }

        public Dictionary<int, ushort> GetSaveIndexes()
        {
            return SaveIndexes_GlobalIds;
        }

        public IGameItem GetItem(ushort Id)
        {
            if (GameItems.ContainsKey(Id))
            {
                return GameItems[Id];
            }

            return null;
        }

        public string GetItemName(ushort Id)
        {
            IGameItem Item = GetItem(Id);

            if (Item != null)
            {
                return Item.Name;
            }
            return string.Format("unknown_item{0}", Id);
        }

        public ushort GetGlobalIdWithPinId(ushort ParticularId)
        {
            if (Pin_GlobalIds.ContainsKey(ParticularId))
            {
                return Pin_GlobalIds[ParticularId];
            }
            return 0;
        }

        public ushort GetGlobalIdWithClothingId(ushort ParticularId)
        {
            if (Clothing_GlobalIds.ContainsKey(ParticularId))
            {
                return Clothing_GlobalIds[ParticularId];
            }
            return 0;
        }

        public ushort GetGlobalIdWithFoodId(ushort ParticularId)
        {
            if (Food_GlobalIds.ContainsKey(ParticularId))
            {
                return Food_GlobalIds[ParticularId];
            }
            return 0;
        }

        public ushort GetGlobalIdWithBookId(ushort ParticularId)
        {
            if (Book_GlobalIds.ContainsKey(ParticularId))
            {
                return Book_GlobalIds[ParticularId];
            }
            return 0;
        }

        public ushort GetGlobalIdWithCDId(ushort ParticularId)
        {
            if (CD_GlobalIds.ContainsKey(ParticularId))
            {
                return CD_GlobalIds[ParticularId];
            }
            return 0;
        }

        public PinItem GetPinItem(ushort ParticularId)
        {
            ushort GlobalId = GetGlobalIdWithPinId(ParticularId);

            return GetItem(GlobalId) as PinItem;
        }

        public ClothingItem GetClothingItem(ushort ParticularId)
        {
            ushort GlobalId = GetGlobalIdWithClothingId(ParticularId);

            return GetItem(GlobalId) as ClothingItem;
        }

        public FoodItem GetFoodItem(ushort ParticularId)
        {
            ushort GlobalId = GetGlobalIdWithFoodId(ParticularId);

            return GetItem(GlobalId) as FoodItem;
        }

        public BookItem GetBookItem(ushort ParticularId)
        {
            ushort GlobalId = GetGlobalIdWithBookId(ParticularId);

            return GetItem(GlobalId) as BookItem;
        }

        public CDItem GetCDItem(ushort ParticularId)
        {
            ushort GlobalId = GetGlobalIdWithCDId(ParticularId);

            return GetItem(GlobalId) as CDItem;
        }

        public IGameItem GetItemWithSaveIndex(ushort SaveIndex)
        {
            if (SaveIndexes_GlobalIds.ContainsKey(SaveIndex))
            {
                ushort GlobalId = SaveIndexes_GlobalIds[SaveIndex];

                return GetItem(GlobalId);
            }

            return null;
        }

        public Brand GetBrand(byte Id)
        {
            if (Brands.ContainsKey(Id))
            {
                return Brands[Id];
            }

            return null;
        }

        public Shop GetShop(sbyte Id)
        {
            if (Shops.ContainsKey(Id))
            {
                return Shops[Id];
            }

            return null;
        }

        public Brand GetShopBrand(sbyte ShopId)
        {
            Shop Shop = GetShop(ShopId);
            if (Shop == null)
            {
                return null;
            }

            return GetBrand(Shop.Brand);
        }

        public Ability GetAbility(ushort Id)
        {
            if (Abilities.ContainsKey(Id))
            {
                return Abilities[Id];
            }

            return null;
        }

        public PinAttackElement GetAttackElement(sbyte Id)
        {
            if (AttackElements.ContainsKey(Id))
            {
                return AttackElements[Id];
            }
            return null;
        }

        public PinLevelUpTable GetPinLevelUpTable(byte Level)
        {
            if (LevelUpTables.ContainsKey(Level))
            {
                return LevelUpTables[Level];
            }
            return null;
        }
        #endregion

        #region Pin methods
        public uint GetPinExperienceWithPinIdAndLevel(ushort ParticularId, byte Level)
        {
            if (Level < 1)
            {
                return 0;
            }

            PinItem Pin = GetPinItem(ParticularId);
            if (Pin == null)
            {
                return 0;
            }

            if (Level > Pin.MaxLevel)
            {
                Level = Pin.MaxLevel;
            }

            PinLevelUpTable LvUpTable = GetPinLevelUpTable(Level);
            if (LvUpTable == null)
            {
                return 0;
            }

            return (uint)Math.Floor((float)LvUpTable.Exp[Pin.LevelUpType] * Pin.LevelUpRate);
        }

        public byte GetPinLevelWithPinIdAndExperience(ushort ParticularId, uint Experience)
        {
            PinItem Pin = GetPinItem(ParticularId);
            if (Pin == null)
            {
                return 1; //or throw an error?
            }

            Experience = (uint)Math.Floor((float)Experience / Pin.LevelUpRate);

            byte Level = 1;
            foreach (PinLevelUpTable LvUpTable in LevelUpTables.Values)
            {
                if (LvUpTable.Level <= Pin.MaxLevel)
                {
                    if (LvUpTable.Exp[Pin.LevelUpType] <= Experience)
                    {
                        Level = LvUpTable.Level;
                    }
                }
            }

            return Level;
        }

        public bool PinIsUber(PinItem Pin)
        {
            if (Pin != null)
            {
                return Pin.PinClass == 5;
            }
            return false;
        }

        public bool PinIsMasterable(ushort ParticularId)
        {
            return PinIsMasterable(GetPinItem(ParticularId));
        }

        public bool PinIsMasterable(PinItem Pin)
        {
            if (Pin != null)
            {
                return Pin.LevelUpType != 6;
            }
            return false;
        }

        public string GetPsychKeyImage(PinItem Pin)
        {
            if (Pin == null || !PsychKeys.ContainsKey(Pin.InputKey))
            {
                return null;
            }

            return string.Format("PsychicButton_{0}{1}", PsychKeys[Pin.InputKey], PinIsUber(Pin) ? "_God" : string.Empty);
        }
        #endregion
    }
}