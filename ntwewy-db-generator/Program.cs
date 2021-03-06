using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NTwewyDbGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ntwewy-db-generator ~ made by T");
            Console.WriteLine("place the necessary .txt files in the application's folder.");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("0. All Items");
            Console.WriteLine("1. All Characters");
            Console.WriteLine("2. Game Locale Strings");
            Console.WriteLine("3. Ability");
            Console.WriteLine("4. Brand");
            Console.WriteLine("5. Battle Player");
            Console.WriteLine("6. Skill & Skill Tree");
            Console.WriteLine("7. Shop");
            Console.WriteLine("8. Attack Element");
            Console.WriteLine("9. Noisepedia");
            Console.WriteLine("10. Noise (EnemyData)");
            Console.WriteLine("11. Pin Level Up Table");
            Console.WriteLine("12. Turf War");
            Console.WriteLine("13. Trophy");
            Console.WriteLine("14. Shop Goods");
            Console.WriteLine("15. Scenario");
            Console.WriteLine("16. Event");
            Console.WriteLine("17. EventData, EventLog & EventLogSelect");
            Console.WriteLine("18. Chapter");
            Console.WriteLine("19. Id Dictionary");
            Console.WriteLine("20. Dive Data");

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

                case "6":
                    GenerateSkillData();
                    break;

                case "7":
                    GenerateShopData();
                    break;

                case "8":
                    GenerateAttackElementData();
                    break;

                case "9":
                    GenerateNoisepediaData();
                    break;

                case "10":
                    GenerateNoiseData();
                    break;

                case "11":
                    GeneratePinLevelUpTable();
                    break;

                case "12":
                    GenerateTurfWarData();
                    break;

                case "13":
                    GenerateTrophyData();
                    break;

                case "14":
                    GenerateShopGoodsData();
                    break;

                case "15":
                    GenerateScenarioData();
                    break;

                case "16":
                    GenerateEventData();
                    break;

                case "17":
                    GenerateEventOther();
                    break;

                case "18":
                    GenerateChapterData();
                    break;

                case "19":
                    GenerateIdDictionary();
                    break;

                case "20":
                    GenerateDiveData();
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

                string Constructor = string.Format("new PinItem({0}, {1}, {2}, \"{3}\", \"{4}\", \"{5}\", {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21},  {22}, {23}, {24}, {25})",
                    globalId,
                    pinId,
                    "ItemType.Pin",
                    pinName,
                    pinInfo,
                    pinData.mBadgeSpriteName,
                    (int)pinData.mBrand,
                    saveIndex,
                    Convert.ToInt32(((string)pinData.mNameChance).Replace("Chance_Name_", "")),
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
                    evolutionarray,
                    pinData.mMashupElement);

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
            string json_musicnames = File.ReadAllText("MusicName.txt");
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

        static void GenerateSkillData()
        {
            string json_skill = File.ReadAllText("Skill.txt");
            dynamic array_skill = JsonConvert.DeserializeObject(json_skill);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<ushort, Skill> Skills = new Dictionary<ushort, Skill>()");
            Builder.AppendLine("        {");

            foreach (var skillData in array_skill.mTarget)
            {
                int Id = (int)skillData.mId;
                string Name = (string)skillData.mName;
                string Info = (string)skillData.mInfo;
                int PointsReq = (int)skillData.mPoint;

                string paramArray = "null";
                List<double> paramList = skillData.mParameter.ToObject<List<double>>();

                if (paramList.Count > 0)
                {
                    paramArray = "new float[] { " + string.Join("f,", paramList) + " }";
                }

                int shopReward = (int)skillData.mShopReward;
                string dialogImage = (string)skillData.mDialogImage;
                int SaveIndex = (int)skillData.mSaveIndex;

                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");

                //        public Skill(ushort id, string name, string info, ushort pointsRequired, float[] parameters, int shopReward, string dialogImage, int saveIndex)
                string Constructor = string.Format("        new Skill({0}, \"{1}\", \"{2}\", {3}, {4}, {5}, {6}, {7})",
                    Id,
                    Name,
                    Info,
                    PointsReq,
                    paramArray,
                    shopReward,
                    string.IsNullOrWhiteSpace(dialogImage) ? "null" : "\"" + dialogImage + "\"",
                    SaveIndex
                    );

                Builder.Append(Constructor);
                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_skills.cs", Builder.ToString());


            string json_skilltree = File.ReadAllText("SkillTree.txt");
            dynamic array_skilltree = JsonConvert.DeserializeObject(json_skilltree);

            Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<ushort, SkillTree> SkillTreeItems = new Dictionary<ushort, SkillTree>()");
            Builder.AppendLine("        {");

            foreach (var treeData in array_skilltree.mTarget)
            {

                int Id = (int)treeData.mId;
                string CharaName = (string)treeData.mCharaName;
                string charaInfoarray = "null";
                List<string> charaInfoList = treeData.mCharaInfo.ToObject<List<string>>();
                charaInfoList = charaInfoList.Distinct().ToList();

                if (charaInfoList.Count > 0)
                {
                    charaInfoarray = "new string[] { \"" + string.Join("\",\"", charaInfoList) + "\" }";
                }

                bool InfoUpdateIfConnect = (bool)treeData.mInfoUpdateIfConnect;
                int InfoUpdateScenario = (int)treeData.mInfoUpdateScenario;
                string DayText = (string)treeData.mDayText;
                string PlaceText = (string)treeData.mPlaceText;
                int shopId = (int)treeData.mShop;
                int ReleaseValue = (int)treeData.mReleaseValue;
                int Board = (int)treeData.mBoard;
                int SkillId = (int)treeData.mSkill;

                string CharaIcon = treeData.mCharaIcon.ToObject<List<string>>()[0];
                int EntryDay = (int)treeData.mEntryDay;
                int ConnectDay = (int)treeData.mConnectDay;
                int ParentId = (int)treeData.mParent;
                int SaveIndex = (int)treeData.mSaveIndex;

                //        public SkillTree(short id, )


                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");

                string Constructor = string.Format("        new SkillTree({0}, \"{1}\", {2}, {3}, {4}, \"{5}\", \"{6}\", {7}, {8}, {9}, {10}, \"{11}\", {12}, {13}, {14}, {15})",
                    Id,
                    CharaName,
                    charaInfoarray,
                    InfoUpdateIfConnect.ToString().ToLower(),
                    InfoUpdateScenario,
                    DayText,
                    PlaceText,
                    shopId,
                    ReleaseValue,
                    Board,
                    SkillId,
                    CharaIcon,
                    EntryDay,
                    ConnectDay,
                    ParentId,
                    SaveIndex
    );

                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_skilltree.cs", Builder.ToString());

        }

        static void GenerateShopData()
        {
            string json_shop = File.ReadAllText("Shop.txt");
            dynamic array_shop = JsonConvert.DeserializeObject(json_shop);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<ushort, Shop> Shops = new Dictionary<ushort, Shop>()");
            Builder.AppendLine("        {");

            foreach (var shopData in array_shop.mTarget)
{
                int Id = (int)shopData.mId;
                string Name = (string)shopData.mName;
                string ShopCategory = (string)shopData.mShopCategory;
                int ShopType = (int)shopData.mShopType;
                int Brand = (int)shopData.mBrand; 
                int SymbolItem = (int)shopData.mSymbolItem;
                int SkillId = (int)shopData.mSkill;
                int Staff = (int)shopData.mStaff;
                int Bgm = (int)shopData.mBgmLabel;
                string Background = (string)shopData.mBgPath;
                bool ChangeBg = (bool)shopData.mChangeBg;
                int SaveIndex = (int)shopData.mSaveIndex;

                string regularbuy = "new ushort[] { " + string.Join(',', shopData.mRegularBuy.ToObject<List<int>>()) + " }";
                string regularday = "new ushort[] { " + string.Join(',', shopData.mRegularDay.ToObject<List<int>>()) + " }";
                string regularvip = "new ushort[] { " + string.Join(',', shopData.mRegularVip.ToObject<List<int>>()) + " }";
                string ShopTalk = "new ushort[] { " + string.Join(',', shopData.mShoptalk.ToObject<List<int>>()) + " }";


                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");

                //        public Shop(int id, string name, string shopCategory, int shopType, byte brand, ushort symbolItem, int skillId, int staffId, ushort bgm, string background, bool changeBackground, int saveIndex, ushort[] regularBuy, ushort[] regularDay, ushort[] regularVip, ushort[] shopTalk)

                string Constructor = string.Format("new Shop({0}, \"{1}\", \"{2}\", {3}, {4}, {5}, {6}, {7}, {8}, \"{9}\", {10}, {11}, {12}, {13}, {14}, {15})",
                    Id,
                    Name,
                    ShopCategory,
                    ShopType,
                    Brand,
                    SymbolItem,
                    SkillId,
                    Staff,
                    Bgm,
                    Background,
                    ChangeBg ? "true" : "false",
                    SaveIndex,
                    regularbuy,
                    regularday,
                    regularvip,
                    ShopTalk
                    );


                Builder.Append(Constructor);
                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_shops.cs", Builder.ToString());

        }

        static void GenerateAttackElementData()
        {
            string json_attackelement = File.ReadAllText("AttackElement.txt");
            dynamic array_ae = JsonConvert.DeserializeObject(json_attackelement);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<byte, PinAttackElement> AttackElements = new Dictionary<byte, PinAttackElement>()");
            Builder.AppendLine("        {");

            foreach (var aeData in array_ae.mTarget)
            {
                int Id = (int)aeData.mId;
                string ElementName = (string)aeData.mElementName;
                string ElementIcon = (string)aeData.mElementIcon;
                string MashupIcon = (string)aeData.mMashupIcon;
                int SortIndex = (int)aeData.mSortIndex;

                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");

                string Constructor = string.Format("        new PinAttackElement({0}, \"{1}\", \"{2}\", \"{3}\", {4})",
                    Id,
                    ElementName,
                    ElementIcon,
                    MashupIcon,
                    SortIndex);

                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_attackelements.cs", Builder.ToString());
        }

        static void GenerateNoisepediaData()
        {
            string json_noisepedia = File.ReadAllText("EnemyReport.txt");
            dynamic array_noise = JsonConvert.DeserializeObject(json_noisepedia);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<byte, NoisepediaEntry> Noisepedia = new Dictionary<byte, NoisepediaEntry>()");
            Builder.AppendLine("        {");

            foreach (var noiseData in array_noise.mTarget)
            {
                int Id = (int)noiseData.mId;
                int SortIndex = (int)noiseData.mSortIndex;
                int Character = (int)noiseData.mCharacter;
                string groupcharacter = "null";

                var GroupCharaList = noiseData.mGroupCharacter.ToObject<List<int>>();
                if (GroupCharaList.Count > 0)
                {
                    groupcharacter = "new ushort[] { " + string.Join(",", GroupCharaList) + " }";
                }

                int NoiseId = (int)noiseData.mEnemydata;
                string Icon = (string)noiseData.mIcon;
                int symboltype = (int)noiseData.mSymbolType;
                string Name = (string)noiseData.mName;
                string Info = (string)noiseData.mInfo;
                string IsBoss = (bool)noiseData.mIsBoss ? "true" : "false";

                string weakelements = "null";

                var WeakElementsList = noiseData.mWeak.ToObject<List<int>>();
                if (WeakElementsList.Count > 0)
                {
                    weakelements = "new sbyte[] { " + string.Join(",", WeakElementsList) + " }";
                }

                string NoiseImage = (string)noiseData.mNoiseImagePath;

                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");

                string Constructor = string.Format("        new NoisepediaEntry({0}, {1}, {2}, {3}, {4}, \"{5}\", {6}, \"{7}\", \"{8}\", {9}, {10}, \"{11}\")",
                    Id,
                    SortIndex,
                    Character,
                    groupcharacter,
                    NoiseId,
                    Icon,
                    symboltype,
                    Name,
                    Info,
                    IsBoss,
                    weakelements,
                    NoiseImage);

                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_noisepedia.cs", Builder.ToString());
        }

        static void GenerateNoiseData()
        {
            string json_noisedata = File.ReadAllText("EnemyData.txt");
            dynamic array_noise = JsonConvert.DeserializeObject(json_noisedata);

            string json_battlecharacter = File.ReadAllText("BattleCharacter.txt");
            dynamic array_battlecharacter = JsonConvert.DeserializeObject(json_battlecharacter);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<uint, Noise> NoiseData = new Dictionary<uint, Noise>()");
            Builder.AppendLine("        {");

            foreach (var noiseData in array_noise.mTarget)
            {
                int Id = (int)noiseData.mId;
                int Class = (int)noiseData.mClass;
                int Type = (int)noiseData.mType;
                int TypeVersion = (int)noiseData.mTypeVersion;
                string SoFileName = (string)noiseData.mSoFileName;
                int ResourceData = (int)noiseData.mResourceData;
                int BaseParam = (int)noiseData.mBaseParam;
                string Attack = "new uint[] { " + string.Join(',', noiseData.mAttack.ToObject<List<int>>()) + " }";
                string AttackWeightEasy = "new float[] { " + string.Join("f,", noiseData.mAttackWeightEasy.ToObject<List<double>>()) + "f }"; ;
                string AttackWeightNormal = "new float[] { " + string.Join("f,", noiseData.mAttackWeightNormal.ToObject<List<double>>()) + "f }"; ;
                string AttackWeightHard = "new float[] { " + string.Join("f,", noiseData.mAttackWeightHard.ToObject<List<double>>()) + "f }"; ;
                string AttackWeightUltimate = "new float[] { " + string.Join("f,", noiseData.mAttackWeightUltimate.ToObject<List<double>>()) + "f }"; ;
                int ShacHateGaugeMax = (int)noiseData.mShacHateGaugeMax;
                int ShacTriggerLine = (int)noiseData.mShacTriggerLine;
                int ShacAttackIndex = (int)noiseData.mShacAttackIndex;
                string ShacStateName = (string)noiseData.mShacStateName;
                int SightAngle = (int)noiseData.mSightAngle;
                string Scale = (double)noiseData.mScale + "f";
                int Exp = (int)noiseData.mExp;
                int Bp = (int)noiseData.mBp;
                string BattleTime = (double)noiseData.mBattleTime + "f";
                string Param = "new byte[] { " + string.Join(',', noiseData.mParam.ToObject<List<int>>()) + " }";
                int BlowedColRadius = (int)noiseData.mBlowedColRadius;
                int DesperateSe = (int)noiseData.mDesperateSe;
                int EscapeSe = (int)noiseData.mEscapeSe;
                int DesperateVoice = (int)noiseData.mDesperateVoice;
                string PinDropId = "new ushort[] { " + string.Join(',', noiseData.mDrop.ToObject<List<int>>()) + " }";
                string DropRate = "new float[] { " + string.Join("f,", noiseData.mDropRate.ToObject<List<double>>()) + "f }"; ;
                int DynamicBoneFps = (int)noiseData.mDynamicBoneFps;
                int DynamicBoneDistance = (int)noiseData.mDynamicBoneDistance;
                int DiseaseSyncroUpRate = (int)noiseData.mDiseaseSyncroUpRate;
                int DiseaseDamageCutRate = (int)noiseData.mDiseaseDamageCutRate;
                int Level = (int)noiseData.mLevel;
                int ResultCp = (int)noiseData.mResultCp;

                if (SoFileName == "")
                {
                    SoFileName = "null";
                }
                else
                {
                    SoFileName = "\"" + SoFileName + "\"";
                }

                if (Attack == "new uint[] { }")
                {
                    Attack = "null";
                }

                if (ShacStateName == "")
                {
                    ShacStateName = "null";
                }
                else
                {
                    ShacStateName = "\"" + ShacStateName + "\"";
                }

                int Hp = 0;
                int AttackVal = 0;
                int Damage = 0;
                int Weight = 0;

                foreach (var battleNoise in array_battlecharacter.mTarget)
                {
                    if (BaseParam == (int)battleNoise.mId)
                    {
                        Hp = (int)battleNoise.mHp;
                        AttackVal = (int)battleNoise.mAttack;
                        Damage = (int)battleNoise.mDamage;
                        Weight = (int)battleNoise.mWeight;
                    }
                }

                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");

                //        public Noise(uint id, byte _class, ushort type, byte typeVersion, string soFileName, ushort resourceData, ushort baseParam, uint[] attack, float[] attackWeightEasy, float[] attackWeightNormal, float[] attackWeightHard, float[] attackWeightUltimate, byte shacHateGaugeMax, byte shacTriggerLine, byte shacAttackIndex, string shacStateName, byte sightAngle, float scale, ushort exp, ushort bp, float battleTime, byte[] param, float blowedColRadius, int desperateSe, int escapeSe, int desperateVoice, ushort[] pinDropId, float[] dropRate, byte dynamicBoneFps, byte dynamicBoneDistance, byte diseaseSyncroUpRate, byte diseaseDamageCutRate, byte level, byte resultCp)

                string Constructor = string.Format("        new Noise({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23}, {24}, {25}, {26}, {27}, {28}, {29}, {30}, {31}, {32}, {33}, {34}, {35}, {36}, {37})",
                    Id,
                    Class,
                    Type,
                    TypeVersion,
                    SoFileName,
                    ResourceData,
                    BaseParam,
                    Attack,
                    AttackWeightEasy,
                    AttackWeightNormal,
                    AttackWeightHard,
                    AttackWeightUltimate,
                    ShacHateGaugeMax,
                    ShacTriggerLine,
                    ShacAttackIndex,
                    ShacStateName,
                    SightAngle,
                    Scale,
                    Exp,
                    Bp,
                    BattleTime,
                    Param,
                    BlowedColRadius,
                    DesperateSe,
                    EscapeSe,
                    DesperateVoice,
                    PinDropId,
                    DropRate,
                    DynamicBoneFps,
                    DynamicBoneDistance,
                    DiseaseSyncroUpRate,
                    DiseaseDamageCutRate,
                    Level,
                    ResultCp,
                    Hp,
                    AttackVal,
                    Damage,
                    Weight);

                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_noisedata.cs", Builder.ToString());
        }

        public static void GeneratePinLevelUpTable()
        {
            string json_pinlevelup = File.ReadAllText("BadgeLvUpTable.txt");
            dynamic array_pinlevel = JsonConvert.DeserializeObject(json_pinlevelup);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<byte, PinLevelUpTable> LevelUpTables = new Dictionary<byte, PinLevelUpTable>()");
            Builder.AppendLine("        {");

            foreach (var lvlUpData in array_pinlevel.mTarget)
            {
                int Id = (int)lvlUpData.mId;
                int Level = (int)lvlUpData.mLevel;
                string Exp = "new uint[] { " + string.Join(',', lvlUpData.mExp.ToObject<List<uint>>()) + " }";


                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");

                string Constructor = string.Format("new PinLevelUpTable({0}, {1}, {2})",
                    Id,
                    Level,
                    Exp);

                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_pinleveluptable.cs", Builder.ToString());
        }

        public static void GenerateTurfWarData()
        {
            string json_turfwar = File.ReadAllText("Struggle.txt");
            dynamic array_turfwar = JsonConvert.DeserializeObject(json_turfwar);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<ushort, TurfWar> TurfWars = new Dictionary<ushort, TurfWar>()");
            Builder.AppendLine("        {");

            foreach (var turfWar in array_turfwar.mTarget)
            {
                int Id = (int)turfWar.mId;
                string Title = (string)turfWar.mTitle;
                string RuleTitle = (string)turfWar.mRuleTitle;
                string Rule = "new string[] { \"" + string.Join("\",\"", turfWar.mRule.ToObject<List<string>>()) + "\" }";
                string Sub = (string)turfWar.mSub;
                int Rewards = (int)turfWar.mRewards;
                int Noise = (int)turfWar.mNoise;
                int Scenario = (int)turfWar.mScenario;
                string StartDataSo = (string)turfWar.mStartDataSo;
                int HideTeam = (int)turfWar.mHideTeam;
                string MapOpenArea = (string)turfWar.mMapOpenArea;
                int SaveIndex = (int)turfWar.mSaveIndex;

                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");

                //        public TurfWar(ushort id, string title, string ruleTitle, string[] rule, string sub, byte rewards, ushort noise, int scenario, string startDataSo, byte hideTeam, string mapOpenArea, int saveIndex)

                string Constructor = string.Format("new TurfWar({0}, \"{1}\", \"{2}\", {3}, \"{4}\", {5}, {6}, {7}, \"{8}\", {9}, \"{10}\", {11})",
                    Id,
                    Title,
                    RuleTitle,
                    Rule,
                    Sub,
                    Rewards,
                    Noise,
                    Scenario,
                    StartDataSo,
                    HideTeam,
                    MapOpenArea,
                    SaveIndex);

                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_turfwars.cs", Builder.ToString());
        }

        public static void GenerateTrophyData()
        {
            string json_trophy = File.ReadAllText("Trophy.txt");
            dynamic array_trophy = JsonConvert.DeserializeObject(json_trophy);

            string json_trophyrank = File.ReadAllText("TrophyRank.txt");
            dynamic array_trophyrank = JsonConvert.DeserializeObject(json_trophyrank);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<byte, Trophy> Trophies = new Dictionary<byte, Trophy>()");
            Builder.AppendLine("        {");

            foreach (var trophyData in array_trophy.mTarget)
            {
                int Id = (int)trophyData.mId;
                int SortIndex = (int)trophyData.mSortIndex;
                int Param = (int)trophyData.mParam;
                string TrophyTitle = (string)trophyData.mTrophyTitle;
                string TrophySummary = (string)trophyData.mTrophySummary;
                string TrophyHint = (string)trophyData.mTrophyHint;
                string TrophyIcon = (string)trophyData.mTrophyIcon;
                int TrophyGrade = (int)trophyData.mTrophyGrade;

                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");

                //                public Trophy(byte id, byte sortIndex, int param, string trophyTitle, string trophySummary, string trophyHint, string trophyIcon, byte trophyGrade)


                string Constructor = string.Format("new Trophy({0}, {1}, {2}, \"{3}\", \"{4}\", \"{5}\", \"{6}\", {7})",
                    Id,
                    SortIndex,
                    Param,
                    TrophyTitle,
                    TrophySummary,
                    TrophyHint,
                    TrophyIcon,
                    TrophyGrade
                    );

                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            Builder.AppendLine();

            Builder.AppendLine("        private readonly Dictionary<byte, TrophyRank> TrophyRanks = new Dictionary<byte, TrophyRank>()");
            Builder.AppendLine("        {");

            foreach (var rankData in array_trophyrank.mTarget)
            {
                int Id = (int)rankData.mId;
                string RankTitleIcon = (string)rankData.mRankTitleIcon;
                int Rate = (int)rankData.mRate;

                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");

                //                public Trophy(byte id, byte sortIndex, int param, string trophyTitle, string trophySummary, string trophyHint, string trophyIcon, byte trophyGrade)


                string Constructor = string.Format("new TrophyRank({0}, \"{1}\", {2})",
                    Id,
                    RankTitleIcon,
                    Rate
                    );

                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }
            Builder.AppendLine("        };");

            File.WriteAllText("output_dictionary_trophy.cs", Builder.ToString());
        }

        public static void GenerateShopGoodsData()
        {
            string json_shopgoods = File.ReadAllText("ShopGoods.txt");
            dynamic array_shopgoods = JsonConvert.DeserializeObject(json_shopgoods);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<ushort, ShopGood> ShopGoods = new Dictionary<ushort, ShopGood>()");
            Builder.AppendLine("        {");

            foreach (var shopGood in array_shopgoods.mTarget)
            {
                int Id = (int)shopGood.mId;
                int Shop = (int)shopGood.mShop;
                int Item = (int)shopGood.mItem;
                string ItemCount = "new byte[] { " + string.Join(",", shopGood.mItemCount.ToObject<List<int>>()) + " }";
                int Price = (int)shopGood.mPrice;
                int Exchange = (int)shopGood.mExchange;
                int ReleaseVip = (int)shopGood.mReleaseVip;
                int ReleaseDay = (int)shopGood.mReleaseDay;
                int ReleaseRegular = (int)shopGood.mReleaseRegular;
                int ReleaseSkill = (int)shopGood.mReleaseSkill;
                int SortIndex = (int)shopGood.mSortIndex;
                int SaveIndex = (int)shopGood.mSaveIndex;
                string GoodsName = "\"" + (string)shopGood.mGoodsName + "\"";
                int ReleaseParam = (int)shopGood.mReleaseParam;

                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");

                //        public TurfWar(ushort id, string title, string ruleTitle, string[] rule, string sub, byte rewards, ushort noise, int scenario, string startDataSo, byte hideTeam, string mapOpenArea, int saveIndex)

                string Constructor = string.Format("new ShopGood({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13})",
                    Id,
                    Shop,
                    Item,
                    ItemCount,
                    Price,
                    Exchange,
                    ReleaseVip,
                    ReleaseDay,
                    ReleaseRegular,
                    ReleaseSkill,
                    SortIndex,
                    SaveIndex,
                    GoodsName,
                    ReleaseParam);

                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_shopgoods.cs", Builder.ToString());
        }

        public static void GenerateScenarioData()
        {
            string json_scenario = File.ReadAllText("Scenario.txt");
            dynamic array_scenario = JsonConvert.DeserializeObject(json_scenario);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<uint, Scenario> Scenarios = new Dictionary<uint, Scenario>()");
            Builder.AppendLine("        {");

            foreach (var scenarioData in array_scenario.mTarget)
            {

                int Id = (int)scenarioData.mId;
                int Category = (int)scenarioData.mCategory;
                int[] Belong = scenarioData.mBelong.ToObject<List<int>>().ToArray();
                string Access = (bool)scenarioData.mAccess ? "true" : "false";
                int SaveIndex = (int)scenarioData.mSaveIndex;

                string Constructor = string.Format("new Scenario({0}, {1}, {2}, {3}, {4})",
                    Id,
                    "(ScenarioCategory)" + Category,
                    "new ScenarioBelong[] { (ScenarioBelong)" + string.Join(", (ScenarioBelong)", Belong) + " }",
                    Access,
                    SaveIndex);

                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");
                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_scenario.cs", Builder.ToString());
        }

        public static void GenerateEventData()
        {
            string json_event = File.ReadAllText("Event.txt");
            dynamic array_event = JsonConvert.DeserializeObject(json_event);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<uint, Event> Events = new Dictionary<uint, Event>()");
            Builder.AppendLine("        {");

            foreach (var eventData in array_event.mTarget)
            {
                /*		"mId": 50100200,
		"mSaveIndex": 101,
		"mBelong": 50010,
		"mPriority": 0,
		"mResultUpdate": false,
		"mSetData": false*/

                int Id = (int)eventData.mId;
                int SaveIndex = (int)eventData.mSaveIndex;
                int Belong = (int)eventData.mBelong;
                int Priority = (int)eventData.mPriority;
                string ResultUpdate = (bool)eventData.mResultUpdate ? "true" : "false";
                string SetData = (bool)eventData.mSetData ? "true" : "false";

                string Constructor = string.Format("new Event({0}, {1}, {2}, {3}, {4}, {5})",
                    Id,
                    SaveIndex,
                    "(ScenarioBelong)" + Belong,
                    Priority,
                    ResultUpdate,
                    SetData);

                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");
                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_event.cs", Builder.ToString());
        }

        public static void GenerateEventOther()
        {
            string json_eventdata = File.ReadAllText("EventData.txt");
            dynamic array_eventdata = JsonConvert.DeserializeObject(json_eventdata);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<uint, EventData> EventDataDic = new Dictionary<uint, EventData>()");
            Builder.AppendLine("        {");

            foreach (var eventDataData in array_eventdata.mTarget)
            {
                /*		"mId": 50100200,
		"mSaveIndex": 101,
		"mBelong": 50010,
		"mPriority": 0,
		"mResultUpdate": false,
		"mSetData": false*/

                int Id = (int)eventDataData.mId;
                int EventId = (int)eventDataData.mEventId;
                int SaveIndex = (int)eventDataData.mSaveIndex;

                string Constructor = string.Format("new EventData({0}, {1}, {2})",
                    Id,
                    EventId,
                    SaveIndex);

                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");
                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            Builder.AppendLine();

            string json_eventlog = File.ReadAllText("EventLog.txt");
            dynamic array_eventlog = JsonConvert.DeserializeObject(json_eventlog);

            Builder.AppendLine("        private readonly Dictionary<ushort, EventLog> EventLogs = new Dictionary<ushort, EventLog>()");
            Builder.AppendLine("        {");

            foreach (var eventlogData in array_eventlog.mTarget)
            {
                int Id = (int)eventlogData.mId;
                int SaveId = (int)eventlogData.mSaveId;
                int Chapter = (int)eventlogData.mChapter;

                string Constructor = string.Format("new EventLog({0}, {1}, {2})",
                    Id,
                    SaveId,
                    Chapter);

                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");
                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }
            Builder.AppendLine("        };");
            Builder.AppendLine();

            string json_eventlogselect = File.ReadAllText("EventLogSelect.txt");
            dynamic array_eventlogselect = JsonConvert.DeserializeObject(json_eventlogselect);

            Builder.AppendLine("        private readonly Dictionary<byte, EventLogSelect> EventLogSelectDic = new Dictionary<byte, EventLogSelect>()");
            Builder.AppendLine("        {");

            foreach (var eventlogselectData in array_eventlogselect.mTarget)
            {
                int Id = (int)eventlogselectData.mId;
                int SaveId = (int)eventlogselectData.mSaveId;

                string Constructor = string.Format("new EventLogSelect({0}, {1})",
                    Id,
                    SaveId);

                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");
                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }
            Builder.AppendLine("        };");
            Builder.AppendLine();

            File.WriteAllText("output_dictionary_eventdata_eventlog_eventlogselect.cs", Builder.ToString());
        }

        public static void GenerateChapterData()
        {
            string json_chapter = File.ReadAllText("Chapter.txt");
            dynamic array_chapter = JsonConvert.DeserializeObject(json_chapter);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<byte, Chapter> Chapters = new Dictionary<byte, Chapter>()");
            Builder.AppendLine("        {");

            foreach (var chapterData in array_chapter.mTarget)
            {
                /*		
                 
                 
        "mId": 24,
		"mChapterName": "Day_Name_another",
		"mChapterTitle": "Chapter_title_another",
		"mChapterSummary": "Chapter_summary_another",
		"mChapterBg": "Chapter_img24",
		"mChapterIcon": "Chapter_btn24",
		"mLogTextFile": "EVEw4d1",
		"mSubmissionSkill": [

		],
		"mPigNoise": [
			39,
			40,
			41,
			42,
			43
		],
		"mDiveId": [
			40100
		],
		"mStruggleId": -1
                */

                int Id = (int)chapterData.mId;
                string ChapterName = (string)chapterData.mChapterName;
                string ChapterTitle = (string)chapterData.mChapterTitle;
                string ChapterSummary = (string)chapterData.mChapterSummary;
                string ChapterBg = (string)chapterData.mChapterBg;
                string ChapterIcon = (string)chapterData.mChapterIcon;
                string LogTextFile = (string)chapterData.mLogTextFile;

                string SubmissionSkill = "new byte[] { " + string.Join(", ", chapterData.mSubmissionSkill.ToObject<List<int>>()) + " }";
                string PigNoise = "new uint[] { " + string.Join(", ", chapterData.mPigNoise.ToObject<List<int>>()) + " }";
                string DiveId = "new uint[] { " + string.Join(", ", chapterData.mDiveId.ToObject<List<int>>()) + "}";

                if (SubmissionSkill == "new byte[] { }")
                {
                    SubmissionSkill = "null";
                }

                if (PigNoise == "new uint[] { }")
                {
                    PigNoise = "null";
                }

                if (DiveId == "new uint[] { }")
                {
                    DiveId = "null";
                }

                int StruggleId = (int)chapterData.mStruggleId;

                string Constructor = string.Format("new Chapter({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})",
                    Id,
                    "\"" + ChapterName + "\"",
                    "\"" + ChapterTitle + "\"",
                    "\"" + ChapterSummary + "\"",
                    "\"" + ChapterBg + "\"",
                    "\"" + ChapterIcon + "\"",
                    "\"" + LogTextFile + "\"",
                    SubmissionSkill,
                    PigNoise,
                    DiveId,
                    StruggleId
                    );

                Builder.Append("            { ");
                Builder.Append(Id);
                Builder.Append(", ");
                Builder.Append(Constructor);

                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_chapter.cs", Builder.ToString());
        }

        public static void GenerateIdDictionary()
        {
            string json_iddic = File.ReadAllText("IdDic.json");
            dynamic array_iddic = JsonConvert.DeserializeObject(json_iddic);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<string, uint> IdDic = new Dictionary<string, uint>()");
            Builder.AppendLine("        {");

            foreach (var idData in array_iddic.columns)
            {
                string Key = (string)idData.key;
                uint Id = (uint)idData.id;

                Builder.Append("            { ");
                Builder.Append("\"" + Key + "\"");
                Builder.Append(", ");
                Builder.Append(Id);

                Builder.AppendLine(" },");
            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_iddic.cs", Builder.ToString());
        }

        public static void GenerateDiveData()
        {
            string dive_json = File.ReadAllText("Dive.txt");
            dynamic array_dive = JsonConvert.DeserializeObject(dive_json);

            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("        private readonly Dictionary<uint, Dive> NagiDives = new Dictionary<uint, Dive>()");
            Builder.AppendLine("        {");

            foreach (var diveData in array_dive.mTarget)
            {
                /*		"mId": 10400,
		"mBelong": 14,
		"mMapEnvParam": "DiveMapEnv_TypeRage",
		"mEmotionalType": 2,
		"mBattle": 9994,
		"mDifficultyLevel": 9,
		"mTimeLimit": 180,
		"mGold": 31,
		"mSilver": 43,
		"mBronze": 180,
		"mGoldItem": -1,
		"mGoldFrendPoint": 2,
		"mSilverItem": -1,
		"mSilverFrendPoint": 2,
		"mBronzeItem": -1,
		"mBronzeFrendPoint": 2,
		"mSaveIndex": 0*/

                int id = (int)diveData.mId;
                int belong = (int)diveData.mBelong;
                string mapenvparam = (string)diveData.mMapEnvParam;
                int emotionalType = (int)diveData.mEmotionalType;
                int battle = (int)diveData.mBattle;
                int difficultyLevel = (int)diveData.mDifficultyLevel;
                int timeLimit = (int)diveData.mTimeLimit;
                int gold = (int)diveData.mGold;
                int silver = (int)diveData.mSilver;
                int bronze = (int)diveData.mBronze;
                int golditem = (int)diveData.mGoldItem;
                int goldFp = (int)diveData.mGoldFrendPoint;
                int silveritem = (int)diveData.mSilverItem;
                int silverFp = (int)diveData.mSilverFrendPoint;
                int bronzeitem = (int)diveData.mBronzeItem;
                int bronzeFp = (int)diveData.mBronzeFrendPoint;
                int saveIndex = (int)diveData.mSaveIndex;

                string Constructor = string.Format("new Dive({0}, {1}, \"{2}\", {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16})",
                    id,
                    belong,
                    mapenvparam,
                    emotionalType,
                    battle,
                    difficultyLevel,
                    timeLimit,
                    gold,
                    silver,
                    bronze,
                    golditem,
                    goldFp,
                    silveritem,
                    silverFp,
                    bronzeitem,
                    bronzeFp,
                    saveIndex
                    );

                Builder.Append("            { ");
                Builder.Append(id);
                Builder.Append(", ");
                Builder.Append(Constructor);

                Builder.AppendLine(" },");

            }

            Builder.AppendLine("        };");
            File.WriteAllText("output_dictionary_dive.cs", Builder.ToString());

        }
    }
}
