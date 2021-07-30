using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NTwewyDbGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ntwewy-db-generator v0.1 ~ made by T");
            Console.WriteLine("place the necessary .txt files in the application's folder.");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("0. All Items");
            Console.WriteLine("1. All Characters");
            Console.WriteLine("2. Game Locale Strings");
            Console.WriteLine("3. Ability");
            Console.WriteLine("4. Brand");
            Console.WriteLine("5. Battle Player");

            Console.WriteLine();
            Console.Write("Select a dictionary: ");

            switch (Console.ReadLine())
            {
                case "0":
                    GenerateAllItemsData();
                    break;

                case "1":
                    GenerateAllCharaData();
                    break;

                case "2":
                    GenerateStrings();
                    break;

                case "3":
                    GenerateAbilityData();
                    break;

                case "4":
                    GenerateBrandData();
                    break;

                case "5":
                    GenerateBattlePlayerData();
                    break;

                default:
                    Console.WriteLine("not valid.");
                    break;
            }
        }
        static void GenerateAllItemsData()
        {
            string json_all = File.ReadAllText("AllItems.txt");
            dynamic array_all = JsonConvert.DeserializeObject(json_all);

            Dictionary<int, int> SaveIndexes = new Dictionary<int, int>();
            //Dictionary<int, int> ItemTypes = new Dictionary<int, int>();
            Dictionary<int, string> ItemNames = new Dictionary<int, string>();
            Dictionary<int, string> ItemInfo = new Dictionary<int, string>();

            foreach (var data in array_all.mTarget)
            {
                SaveIndexes.Add((int)data.mId, (int)data.mSaveId);
                //ItemTypes.Add((int)data.mId, (int)data.mItemType);
                ItemNames.Add((int)data.mId, (string)data.mName);
                ItemInfo.Add((int)data.mId, (string)data.mInfo);
            }

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<ushort, IGameItem> GameItems = new Dictionary<ushort, IGameItem>");
            Builder.AppendLine("        {");

            #region Pins
            string json_pins = File.ReadAllText("Badge.txt");
            dynamic array_pins = JsonConvert.DeserializeObject(json_pins);

            foreach (var pinData in array_pins.mTarget)
            {
                int globalId = pinData.mItemId;
                int pinId = pinData.mId;
                int saveIndex = SaveIndexes[globalId];
                string pinName = ItemNames[globalId];
                string pinInfo = ItemInfo[globalId];

                string abilityarray = "null";
                List<int> abilityList = pinData.mAbility.ToObject<List<int>>();

                if (abilityList.Count > 0)
                {
                    abilityarray = "new ushort[] { " + string.Join(",", abilityList) + " }";
                }

                string evolutionarray = "null";
                List<int> evolutionList = pinData.mEvolutionBadge.ToObject<List<int>>();

                if (evolutionList.Count > 0)
                {
                    evolutionarray = "new short[] { " + string.Join(",", evolutionList) + " }";

                }

                Builder.Append("            { ");
                Builder.Append(globalId);
                Builder.Append(", ");

                string Constructor = string.Format("new PinItem({0}, {1}, {2}, \"{3}\", \"{4}\", \"{5}\", {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21},  {22}, {23}, {24})",
                    globalId,
                    pinId,
                    "ItemType.Pin",
                    pinName,
                    pinInfo,
                    pinData.mBadgeSpriteName,
                    (int)pinData.mBrand,
                    saveIndex,
                    System.Convert.ToInt32(((string)pinData.mNameChance).Replace("Chance_Name_", "")),
                    pinData.mPsychic,
                    pinData.mPsychicKey,
                    pinData.mAttack,
                    (double)pinData.mChargeTime + "f",
                    pinData.mComboCount,
                    (double)pinData.mRebootTime + "f",
                    (double)pinData.mAutoRecoverTime + "f",
                    pinData.mMaxLevel,
                    pinData.mLevelUpType,
                    (double)pinData.mLevelUpRate + "f",
                    abilityarray,
                    pinData.mSellPrice,
                    pinData.mBadgeClass,
                    pinData.mEvolutionLevel,
                    pinData.mEcolutionCommon,
                    evolutionarray);

                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }
            #endregion

            #region Clothing
            string json_clth = File.ReadAllText("Costume.txt");
            dynamic array_clth = JsonConvert.DeserializeObject(json_clth);

            foreach (var clthData in array_clth.mTarget)
            {

                int id = (int)clthData.mId;
                int globalId = (int)clthData.mItemId;
                int saveIndex = SaveIndexes[globalId];
                string Name = ItemNames[globalId];
                string Info = ItemInfo[globalId];
                int brand = (int)clthData.mBrand;
                int slotType = (int)clthData.mSlotType;

                Builder.Append("            { ");
                Builder.Append(globalId);
                Builder.Append(", ");


                string Constructor = string.Format("new ClothingItem({0}, {1}, {2}, \"{3}\", \"{4}\", \"{5}\", {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13})",
                    globalId,
                    id,
                    "ItemType.Clothing",
                    Name,
                    Info,
                    (string)clthData.mUiSprite,
                    brand,
                    saveIndex,
                    slotType,
                    (int)clthData.mAbility,
                    (int)clthData.mOpenSense,
                    (int)clthData.mHp,
                    (int)clthData.mAttack,
                    (int)clthData.mDefence
                    );

                Builder.Append(Constructor);

                Builder.AppendLine(" },");

            }
            #endregion

            #region Food
            string json_food = File.ReadAllText("Food.txt");
            dynamic array_food = JsonConvert.DeserializeObject(json_food);

            foreach (var foodData in array_food.mTarget)
            {

                int globalId = (int)foodData.mItemId;
                int foodId = (int)foodData.mId;
                int saveIndex = SaveIndexes[globalId];
                string Name = ItemNames[globalId];
                string Info = ItemInfo[globalId];
                byte brand = 0;

                string likenessArray = "null";
                List<int> likenessList = foodData.mTaste.ToObject<List<int>>();

                if (likenessList.Count > 0)
                {
                    likenessArray = "new byte[] { " + string.Join(",", likenessList) + " }";
                }

                //        public FoodItem(ushort globalId, ushort particularId, ItemType type, string name, string info, string sprite, byte brand, int collectionSaveIndex, ushort calories, ushort hpBoost, ushort atkBoost, ushort defBoost, ushort styleBoost, byte[] charaLikeness)

                Builder.Append("            { ");
                Builder.Append(globalId);
                Builder.Append(", ");

                string Constructor = string.Format("new FoodItem({0}, {1}, {2}, \"{3}\", \"{4}\", \"{5}\", {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13})",
                    globalId,
                    foodId,
                    "ItemType.Food",
                    Name,
                    Info,
                    (string)foodData.mUiSprite,
                    brand,
                    saveIndex,
                    (int)foodData.mStomach,
                    (int)foodData.mHp,
                    (int)foodData.mAttack,
                    (int)foodData.mDefence,
                    (int)foodData.mSense,
                    likenessArray
                    );

                Builder.Append(Constructor);

                Builder.AppendLine(" },");

            }
            #endregion

            #region Book
            string json_book = File.ReadAllText("Book.txt");
            dynamic array_book = JsonConvert.DeserializeObject(json_book);

            foreach (var bookData in array_book.mTarget)
            {
                int globalId = (int)bookData.mItemId;
                int bookId = (int)bookData.mId;
                int saveIndex = SaveIndexes[globalId];
                string Name = ItemNames[globalId];
                string Info = ItemInfo[globalId];
                byte brand = 0;

                string textArray = "null";
                List<string> textList = bookData.mText.ToObject<List<string>>();

                if (textList.Count > 0)
                {
                    textArray = "new string[] { \"" + string.Join("\",\"", textList) + "\" }";
                }

                Builder.Append("            { ");
                Builder.Append(globalId);
                Builder.Append(", ");

                string Constructor = string.Format("new BookItem({0}, {1}, {2}, \"{3}\", \"{4}\", \"{5}\", {6}, {7}, {8}, {9}, {10})",
                    globalId,
                    bookId,
                    "ItemType.Book",
                    Name,
                    Info,
                    (string)bookData.mUiSprite,
                    brand,
                    saveIndex,
                    (int)bookData.mTips,
                    textArray,
                    (int)bookData.mSecretId
                    );

                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }
            #endregion

            #region CD
            string json_musicnames = File.ReadAllText("ENG/MusicName.txt");
            dynamic array_musicnames = JsonConvert.DeserializeObject(json_musicnames);

            Dictionary<int, string> MusicNames = new Dictionary<int, string>();

            foreach (var musicNameData in array_musicnames.columns)
            {
                string mnName = (string)musicNameData.name;

                int mnId = Convert.ToInt32(mnName.Replace("MSC_Name_", "")) + 1000;

                MusicNames.Add(mnId, mnName);
            }

            string json_cd = File.ReadAllText("Music.txt");
            dynamic array_cd = JsonConvert.DeserializeObject(json_cd);

            foreach (var musicData in array_cd.mTarget)
            {
                int globalId = (int)musicData.mItemId;
                int bookId = (int)musicData.mId;
                int saveIndex = SaveIndexes[globalId];
                string Name = ItemNames[globalId];
                string Info = ItemInfo[globalId];
                byte brand = 0;


                Builder.Append("            { ");
                Builder.Append(globalId);
                Builder.Append(", ");

                string Constructor = string.Format("new CDItem({0}, {1}, {2}, \"{3}\", \"{4}\", \"{5}\", {6}, {7}, {8}, \"{9}\")",
                    globalId,
                    bookId,
                    "ItemType.CD",
                    Name,
                    Info,
                    (string)musicData.mUiSprite,
                    brand,
                    saveIndex,
                    (int)musicData.mBgm,
                    MusicNames[(int)musicData.mBgm]
                    );

                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }
            //        public CDItem(ushort globalId, ushort particularId, ItemType type, string name, string info, string sprite, byte brand, int collectionSaveIndex, ushort bgmId, string bgmName)

            #endregion

            Builder.AppendLine("        };");

            File.WriteAllText("output_dictionary_all_items.cs", Builder.ToString());
        }

        static void GenerateAllCharaData()
        {
            string json_characters = File.ReadAllText("AllCharacters.txt");
            dynamic json_array = JsonConvert.DeserializeObject(json_characters);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<int, Character> Characters = new Dictionary<int, Character>()");
            Builder.AppendLine("        {");

            foreach (var charaData in json_array.mTarget)
            {
                int charaId = (int)charaData.mId;
                string charaName = (string)charaData.mName;
                string charaType = "(CharacterType)" + (int)charaData.mCharaType;
                string charaGender = "(Gender)" + (int)charaData.mGenderType;

                Builder.Append("            { ");
                Builder.Append(charaId);
                Builder.Append(", ");

                string Constructor = string.Format("new Character({0}, \"{1}\", {2}, {3})",
                    charaId,
                    charaName,
                    charaType,
                    charaGender
                    );

                Builder.Append(Constructor);

                Builder.AppendLine(" },");

            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_characters.cs", Builder.ToString());
        }

        static void GenerateStrings()
        {
            List<string> folders = new List<string>() { "ENG", "SPA", "JPN", "FRE", "ITA", "GER" };

            StringBuilder MainBuilder = new StringBuilder();

            foreach (string folder in folders)
            {
                string[] filePaths = Directory.GetFiles(folder, "*.txt",
                                         SearchOption.TopDirectoryOnly);

                StringBuilder Builder = new StringBuilder();
                Builder.Append("        private readonly Dictionary<string, string> ");
                Builder.Append(folder);
                Builder.AppendLine(" = new Dictionary<string, string>");
                Builder.AppendLine("        {");

                // name, content

                foreach (string file in filePaths)
                {
                    string json_file = File.ReadAllText(file);
                    dynamic array_file = JsonConvert.DeserializeObject(json_file);

                    foreach (var localData in array_file.columns)
                    {
                        string name = (string)localData.name;
                        string content = (string)localData.content;

                        if (content.Contains("\n"))
                        {
                            content = content.Replace("\n", "{LineBreak}");
                        }

                        Builder.Append("            { \"");
                        Builder.Append(name);
                        Builder.Append("\", \"");
                        Builder.Append(content);
                        Builder.AppendLine("\" },");
                    }
                }

                Builder.AppendLine("        };");

                MainBuilder.AppendLine(Builder.ToString());
                MainBuilder.AppendLine();
            }
            File.WriteAllText("output_dictionary_strings_ALL.cs", MainBuilder.ToString());

            Console.WriteLine("Finished.");
        }

        static void GenerateAbilityData()
        {
            string json_ability = File.ReadAllText("Ability.txt");
            dynamic json_array = JsonConvert.DeserializeObject(json_ability);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<ushort, Ability> Abilities = new Dictionary<ushort, Ability>()");
            Builder.AppendLine("        {");

                        /*
             "mTarget":[
        {
            "mId": 1,
            "mName": "ABL_Name_0001",
            "mInfoText": "ABL_Info_0001",
            "mType": 1,
            "mTarget": 0,
            "mCharaRestriction": -1,
            "mSortIndex": 1016,
            "mParam": [
                0.05,
                0.0,
                0.0,
                0.0
            ],
            "mBrandParam": -1,
            "mElement": -1
        },
            */

            foreach (var abilityData in json_array.mTarget)
            {
                int abilityId = (int)abilityData.mId;
                string abilityName = (string)abilityData.mName;
                string abilityInfo = (string)abilityData.mInfoText;

                int Type = (int)abilityData.mType;
                int Target = (int)abilityData.mTarget;
                int CharaRestriction = (int)abilityData.mCharaRestriction;

                string paramarray = "null";
                List<double> paramList = abilityData.mParam.ToObject<List<double>>();
                if (paramList.Count > 0)
                {
                    paramarray = "new float[] { " + string.Join("f,", paramList) + " }";
                }

                int brandparam = (int)abilityData.mBrandParam;
                int element = (int)abilityData.mElement;

                Builder.Append("            { ");
                Builder.Append(abilityId);
                Builder.Append(", ");

                string Constructor = string.Format("new Ability({0}, \"{1}\", \"{2}\", {3}, {4}, {5}, {6}, {7}, {8})",
                    abilityId,
                    abilityName,
                    abilityInfo,
                    Type,
                    Target,
                    CharaRestriction,
                    paramarray,
                    brandparam,
                    element
                    );

                Builder.Append(Constructor);

                Builder.AppendLine(" },");

            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_abitilies.cs", Builder.ToString());


        }

        static void GenerateBrandData()
        {
            string json_brand = File.ReadAllText("Brand.txt");
            dynamic json_array = JsonConvert.DeserializeObject(json_brand);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<byte, Brand> Brands = new Dictionary<byte, Brand>()");
            Builder.AppendLine("        {");

            foreach (var brandData in json_array.mTarget)
            {
                int brandId = (int)brandData.mId;
                string brandName = (string)brandData.mName;
                string brandSprite = (string)brandData.mUiSprite;
                int brandSaveIndex = (int)brandData.mSaveIndex;

                string rankpointsarray = "null";
                List<int> rankpointsList = brandData.mRankPoint.ToObject<List<int>>();
                if (rankpointsList.Count > 0)
                {
                    rankpointsarray = "new ushort[] { " + string.Join(",", rankpointsList) + " }";
                }

                Builder.Append("            { ");
                Builder.Append(brandId);
                Builder.Append(", ");

                string Constructor = string.Format("new Brand({0}, \"{1}\", \"{2}\", {3}, {4})",
                    brandId,
                    brandName,
                    brandSprite,
                    brandSaveIndex,
                    rankpointsarray
                    );

                Builder.Append(Constructor);

                Builder.AppendLine(" },");

            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_brands.cs", Builder.ToString());
        }

        static void GenerateBattlePlayerData()
        {
            string json_battlecharacter = File.ReadAllText("BattleCharacter.txt");
            dynamic array_battlecharacter = JsonConvert.DeserializeObject(json_battlecharacter);

            string json_battleplayer = File.ReadAllText("BattlePlayer.txt");
            dynamic array_battleplayer = JsonConvert.DeserializeObject(json_battleplayer);

            Dictionary<int, int> allcharacterIds = new Dictionary<int, int>();
            Dictionary<int, int> baseHp = new Dictionary<int, int>();
            Dictionary<int, int> baseAtk = new Dictionary<int, int>();
            Dictionary<int, int> baseDef = new Dictionary<int, int>();


            foreach (var bcData in array_battlecharacter.mTarget)
            {
                int Id = (int)bcData.mId;
                int characterId = (int)bcData.mAllCharacters;
                int baseHpval = (int)bcData.mHp;
                int baseAtkval = (int)bcData.mAttack;
                int baseDefenseval = (int)bcData.mDefense;

                allcharacterIds.Add(Id, characterId);
                baseHp.Add(Id, baseHpval);
                baseAtk.Add(Id, baseAtkval);
                baseDef.Add(Id, baseDefenseval);
            }

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<int, BattlePlayer> BattlePlayers = new Dictionary<int, BattlePlayer>()");
            Builder.AppendLine("        {");


            foreach (var bpData in array_battleplayer.mTarget)
            {
                int Id = (int)bpData.mId;
                int charaId = allcharacterIds[Id];
                int baseHpval = baseHp[Id];
                int baseAtkval = baseAtk[Id];
                int baseDefenseval = baseDef[Id];

                float DropRate = Convert.ToSingle(bpData.mDropRate);
                int baseSense = (int)bpData.mSense;
                int sortOrder = (int)bpData.mSortOrder;



                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");

                //        public BattlePlayer(int id, int globalId, float dropRate, int baseHp, int baseAtk, int baseDef, int baseSense, byte sortOrder)

                string Constructor = string.Format("new BattlePlayer({0}, {1}, {2}f, {3}, {4}, {5}, {6}, {7})",
                    Id,
                    charaId,
                    DropRate,
                    baseHpval,
                    baseAtkval,
                    baseDefenseval,
                    baseSense,
                    sortOrder
                    );

                Builder.Append(Constructor);
                Builder.AppendLine(" },");

            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_battleplayers.cs", Builder.ToString());
        }
    }
}
