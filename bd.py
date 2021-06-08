from types import MappingProxyType
import json
import csv
import random
import string
import datetime
import functools
 

listTeams = [
  {
    "id": "iran",
    "name": "Iran",
    "leader": "M3hran",
    "description": "Iran description"
  },
  {
    "id": "russian-chess-players",
    "name": "Russian Chess Players",
    "leader": "Kakurenbo",
    "description": "Russian Chess Players description"
  },
  {
    "id": "levitov-chess",
    "name": "Levitov Chess",
    "leader": "LevitovChess",
    "description": "Levitov Chess description"
  },
  {
    "id": "chesslandia",
    "name": "Chesslandia",
    "leader": "DrChessshtern",
    "description": "Chesslandia description"
  },
  {
    "id": "vishwaganga-online-tournaments",
    "name": "Vishwaganga Online Tournaments",
    "leader": "Shardul__Vishwaganga",
    "description": "Vishwaganga Online Tournaments description"
  },
  {
    "id": "team-huschi",
    "name": "Team Huschi",
    "leader": "Niclas",
    "description": "Team Huschi description"
  },
  {
    "id": "wim-chelsie-club",
    "name": "WIM Chelsie - Club",
    "leader": "sieica",
    "description": "WIM Chelsie - Club description"
  },
  {
    "id": "--elite-chess-players-union--",
    "name": " Elite Chess Players Union",
    "leader": "AnIndianTal",
    "description": " Elite Chess Players Union description"
  },
  {
    "id": "--chessmaster",
    "name": "ChessMaster",
    "leader": "maxneo",
    "description": "ChessMaster description"
  },
  {
    "id": "im-satranc",
    "name": "IM Satran\u00e7",
    "leader": "Satranc_Youtube",
    "description": "IM Satran\u00e7 description"
  },
  {
    "id": "shahmatkanal-fan-club",
    "name": "ShahMatKanal Fan Club",
    "leader": "ShahMatKanal",
    "description": "ShahMatKanal Fan Club description"
  },
  {
    "id": "satranc-medya-youtube",
    "name": "chess24 T\u00fcrk\u00e7e",
    "leader": "SatrancMedyaYoutube",
    "description": "chess24 T\u00fcrk\u00e7e description"
  },
  {
    "id": "im-penguinim1-fan-club",
    "name": "GM penguingim1 fan club",
    "leader": "masterintraning2",
    "description": "GM penguingim1 fan club description"
  },
  {
    "id": "alleppey-team",
    "name": "Alleppey team",
    "leader": "Shaji-PM",
    "description": "Alleppey team description"
  },
  {
    "id": "rochade-europa-schachzeitung",
    "name": "Rochade Europa - Schachzeitung",
    "leader": "jeffforever",
    "description": "Rochade Europa - Schachzeitung description"
  }
]

leadersUsername = ["M3hran","Kakurenbo","LevitovChess","DrChessshtern","Shardul__Vishwaganga","Niclas","sieica","AnIndianTal","maxneo","Satranc_Youtube","ShahMatKanal","SatrancMedyaYoutube","masterintraning2","Shaji-PM","jeffforever"]
listUsers = leadersUsername + ["jeevithprasath2020",
"JoniWal","big-cowboy-son","Alexander11235813","victor_cwb","LosConquistadores","MASTERPJ3","FatihEymen2014","Pranjal70","jan2011","Ali1818","Artash0125","rezi09","Rune_0604","El_Pollo_Diablo","Saishrithik","Misha321_theBest","Holakase007009","ScottPilgrim","Alex_97","Mr_winner_man","Maram6644","Chess_student_9","Cavaleronegro","AmySantiagooo","Josefbohac","Younes_Berkan","Carlsenete","Keno64","skaan220","Rob1854","Paarth43572","Rojus9","magicpot","Xxgabi_xX","Michael-007","superj","bubububub","aarush23","Scientor_YT","dejbug","Aliusubov2003","x_reza","Potkhoraia_Kira_2012","mathegenie","KB-nueve","maximederkek","bahodiraxmedov","yassinetaoufiki","M1ch110112021","MASTERCHESSOAK","ILYASSCASTOR","LuckyLucker","Gagous4004","MATIPesO","GeneralArthur","StevenStark11","sups20","Captainjacksparrow20","R-Mes","Ran130","fabulous_shark5","puesnada","ArtemHyron","staticenter20","aaaenzo","AREENKULKARNI","anb13","sarafradheya","Dunkler_Krieger","Jorithey","mAsTeRiNgCheSs_IG","Al-Airotciv","drgalileojimenez","shravya11","AlexLair89","aslanbash","jacuare","ShyNize","Elias08Ke","Emrys3007","Asalih65","chessbira-2","stepa26","juanarango123","chessvoldemort","Samruddh2012","STAVROS_100","Ongarreuben","elgoncis","Chess_student_72","rickey226","jeanlesage","xadrezbaiano","drkukku","Kulygin_EA","Vinipux123","chessmaster_app","Fachgerecht","Peter-999","Schachopa59",
"voyager_faraway","Kingmidasmaze","dika2010","C000li0","Rania125th","Lizabeth13","AleX7654321","Jakob01Ke","JohnRebus","miflosch","DILIP19","Loaf01","krikss","Thisandu2","Chess_coaching_2002","datodato1992","Bersek_account","soham-jas_2007","ali_reza_masoumi_t","Charlienuney","Tropheus08","Master_G_M_Master","mivin83","TiSiFox","Locomooooootion22","Lionel2349","ELMAGISTRAL2018","Nishantches","Der_Jesper","parsa_karimi","adityaram1","AnshMittal2705","Bensopa","TheGrandChessKnight","Florian113","m__moeller","paul-hurtado","ShahanAbu","SPECTRUM_OW","Transcenden","karateschach","Smbturm","paulito99","klerkz","irafava","Oo0o-TETA-o0oO","Spaetlerner","brightbeauty","ChessWizard_25","AssasinLegendman_84","Dark_Shadow2008","PANDACI24","vangerwenfan","garyanderson69","Rodotheos_Eskotraus","Dubov1bliz","Nimzowic","xvvt","thinflakylynx","KhaarthiK17","zaablok","Han1Falcon","AliceLlanes-Kaede","Carter67","Ferdaouspasteura","demir054","M_i_a_10","Rockboy-2021","CP9FC8","EMrahaC","HOPPJO","Sudhinx","registrarrafic","NIAina56","Kevinbo","Illegaltactics","OskarSueSue","aynour1384","Super_Lion","Sanilthegreat","edgarjusselme","Ozancemm","romania1234","Fabschmier","hadz1956","Cars2020","gerardoors","Tikhon_Stolyarov","YsY_Dano","Igor_Melyoschin","MEF-ozturke","NoobGamingYT","thejou","Enno_chess","Tarangchess01","Yuriy1980","CatalonianDestroyer","MMA_Kungrad","manitgupta","Hias83",
"mattliu","egetekin","atanwiN","BUDHY","Savva-Luchkin","Arturo262626","arthur_nouvian","e2d4knight7","edmundas2650","Irenebordozo12","Ruben1982","LVucetic","Denis_Kereytov2012","AlexGiam","rasermatti110","lavren1974","Borrach0","karacam-bjksatranc","AstRoBoYz123456","shashione","Danial-kerdar","ASIERMACARRON","Minh_An","AMGED2400","Alex_Lavri","KulyaBodya","stefa_n011","MithiranAMS","chessmaster123489","coolking1","Komodini","jonathan122333","Global_2009","Springergabel77","MeTeErEnAsLAN2011","Jan_L","Emeric14","Paff-Morris","Rodrigocatayas1972","Foudre78","abrakadabraszach","leoncant","Slashernax-24","attractors","James_Ashwood","KokaKakoka","adityasaxena1003","PEYAZOO007","shawesh2003","Matej-Mydlar","pascal_chess","requena","Yolelosky","reut4","OmSalunke1121","Postpunk96","Shourya29","JakeMVP","Scammer2210","Caval05","Yayin_Hesabi","Iamyour_Destiny","PowerlifterLenny","DRAGON2310","Shlok2013","Duha_Selim_Gunen","zippzappdoing","OrestisKyr","CreepysugarzJX","Querdenken-711","mind_93","Doppelbauer1","mema2009","hawaiitoast","Blunder-Jack","Lichtrebell","Bauernmarsch","Detlef_Roefe","jatro17","Chess_A_Master","SteinStein","Thattearnav","eshaansingh123","Athrina","Baharloo12","DarkLionSoldier","Lukas-2010","schavhaf","Karotten","Shiro__1","karl61","HughManatee","Anirudh-rajan","kh1234aaryan","Thomas-Erland","Nazar_2013","juandivc","chessgamer49","drunken_rabbit","Alexander555",
"vasrafa","vnmath","Kaninchen2020","Pegasus31","Paul6032","QMOHH","alimaleki1390","LegalLeopard","dimkaranasios","Zwiin","Debu_Chess","A62492518juandedios","TulparAzra","AlexanderSvanidze","zekiefish","RostislavKnyazev","manindueshan2021","rachelfa","Nathanaelpro4567","giacomo28","SunnyMathew","PawnStar90","pubgpro12","Ryan0210","AlexSolovykh","Eymen352","ShevchenkoRostislav","SUPRIMEWINNER","Sc00py_1","zygi_07","bekkamorto","Michael_008","Jakob10000","Jackmatefce","Arjun9090","Ulyssesmoore","Enwemo","IgorKaloev","X-C-Z","Ruschess225","Farzin200","Mariya_100204","AnilBayar","Honhon8","SiapKalah","Totonho78","Shoniyozovch","Zhuikov","er-ffm","kaspesky98","ishaanb123","Pegguin","PhoenixTC","SURFEUR","Kronorom","TheYellowBaron","Madjrs72","Steppenwolf_62","thechessdabbler","Leonidsam","AnasAli_786","Anhelina","felix-hase","theternalshadow","ZeppJ","HarryP2019","Viking86","jorgepro2010","preussnas12","Spiderman812","Deep_bluee","lightningmaster5","blindfish","Majonase5","Elkidora","Sifar69","Pivete11","FrausX","Sarp_Cesmeli","chuky2811","kastriotrevaj","Arganier","Behta","PijusGry","TalentedStar","Jakob5-2","Aspihan_Rajakepe","Proxxxxx","Piekay","Pskov_rulit","AdrianME","black_pawn_in_6th","LondonsFinest","Moritz-B","Behailu","AnujKumar12","Black_Zorbas","Vitjok","Crazymove22","krtko11",
"ILOVEKONFETI","LivetoEnjoy","UriyAP","DogBrainSally","jpablito","SVWB","Proboymarc","sourabhk_nitb","jayi2010","A129","Ojasya5678","kompospiel","Waldenfels","SMP_1996","Judge59","jblick","Felix-Schach","JR1109","Chess_keshav","Roya_lGame_Player","ArnoldEssing","GhostAgent","RetiLangweiler","DanijelDimovski","parsa_hero89","kristbbjorg","dartanyan54321","sfantul","Wadmann","Rishav_Debnath-123","SamuelDragomir","Jay1210","KathrinGremer","NikolayF12","GaelCastro","DanielCATM","PROFEMAXI2","BrunoCE","Pikachu_10","Pavanputhiran","pavanputhirand","LysenkoG","Ciclon2021","aLaDa222","Daizarius","The_AnaMacharashvili","Vanya0707","ChessYt123","MohammedElasha","On_18thOctober1988","BrucceLee1940","Anatolekek","PawnCapturesQueen","mangeshrayban","shahada","Schachtiger52","Bazinga87","maciekkam","lolxdoriginal","h0j0f","ladrilloverde","ragorix","SweetChinMusic_04","PINARS-S09","barbishop","Sanya_SV","reallybadatatomic","Rogovoj_Nazar","Ala_Sa","E100118819","McCieb","yuriantonio","bucre910r15","Kookagin","August2012","Pandastarr","Carlo-Paul","AkulVishruth","BEGOJAN","LVH2005","lazzavrakid","Chadul13410","The_Green_Mind","rufusson_dufus","Rapidking2010","F4everRunningHumBird","Denni07","champion_Pranav","rOnAvIVi","emp4","DUENDECILLOH","nalin_123","Aa_EnjangBKD","gedonism","baellouf","Fritzi03003","Marcelluskoenig","moppel1966","Chessexplore-Youtube","NIRO2009",
"New_Eagle","Keytma","Don99999","natig2013","Sandoulov","Nunca_te_rindas_18","Uwe0305","cims","karlik228","karthikeya_mullangi","Osnabruecker","magnuscarslen11","f1re261","naserik","d_rohan","mansimum","dugong161","kkoutras","happitier","TheDrunkenLawyer","Lookingforgirlfriend","Atomic_Fan","Macuilcozcacuauhtli","Optomais365","Athina88","Lexxx79","AmatoareFlory","Eminem313313","ForeignAsp_17","rkluecki","Khoilam1","niemalsE4","Estefany14043","Nleppo","ulubeg","dakshsuchday","Moxley25","kamaraaaaa","bistiparda","Girls_play_chess","Egger1","Rickbone2","Mephisto_59","ayushshukla","Berkin_Demirci","Fedor_29","Yaponets","Themutiny123","stopas","vinaleeGupta","Achintya_01","rusbiathlon","CMalisaid","Peransa3000","Op123456789","LeloucheZiBritannia","FurkanKing_2626","mIHIRdHALLA","DavideTarantino","dornieden_d","PaPuchiraPtor","isez82","AdminGSMFC","dragonv2","VictorPariasca","xiang-qi","nicobroady","Schachgaloppa","Gello10","AbdullayevB","dream_theater88","Kojisan","BenjaSG","fernais","GrafiCHESS","Artyom_2020","PashokKotov","Gino06","MAXIMILIANO_DONOSO","Girt_6677","Leomagna","BoRaOzCeLiK","akshaygmys","Soyfer1","Savinov_ChessCoach","O_M_G_Checkmate","sandwich12","AnonymousRussianGM","KillBill2009","sohampparit","SC_Frederick_M_St3","ushakiran1234","emilsuperschlau","Angeldrez01","The_King_of_the_hill","Zweiteiler","Supersonic10","JesusJael10","Notsogooood","Rini90",
"zirkazi2020","AhAaNMaHeShWaRi1","kaushikezhilpriya","IwilllWINyou","Kadyrjumayew03","Atyaf","chessnycneeln","yudaking","DenishevM","fazeclan2020","Victor-95","Klimi21","natiavasadze","MacDuhn","HaydenSony","SONIC321","OlympeDG","kykskak","Arsenyi_Tochilin","jeansrocks","HI-THIS-IS-ANAND","kubiksyoutube","CPHIWE","DefiantChair","Guelson","danitaa","LTH1","Drunkenstyle36","Godzilla_11","Andenker","ReallyFastMoves","megalidonjay","SJC_SHANILKA2011","Stronghold-X","mentenblanc","Nikiforos_Fokas","son7moons","HUNTERS8800","YusufKazan","shivaraj1234","Cornflakes_Crisps","Alex032032","said1399","SISTEMATIC","Peluncur16","Kasimdzhanov","Rixdorf","braindude123","Best-In-Improvement","HORSEMATH","DerTaktikmeister734","Sputnik_Monroe","emicitas","Paul___Keres","Saparbaev_2094","AtalF","Manfred-Lube","AmirHoja","vrgg","SamuelDerEchte","Silkwormk_2020","elias2012","PrnguinBob","massaoud_ya","JJ999","BaranBEE","kingtom66","elevn","Azulgrana1970","Cleberson_Nascimento","SuperGeneral","training_gambits","J2002081427","Sahib12132","Thot586","David-K","Faiblesse20","B37hHarm0n","TraintoBusan","Deveshraj0711","felixm44","Raditura","Khalil-MAMANE","Malik_03","Adri_3","JancoGj","LeArN_ChEsS_10","nikolozmaglakelidze","Almaryk","soldier23","katarinaostojic","noonoslitlefriend","aminsamimi40","Pol_LOMBARTE","Dimitarexpert","escoubille","thinking_south","GUSTAV2011","Alin86king","alisch2",
"unai777","Ilya_Danilov","Kratos_chesss","sushanebahri","Kirill_Zheltyakov","JosePiscoya","MohammadAayanKhan","derekc1_oficial","DakshRayban","kiketf","SBaraiya","BybaneTilHop","Pluto1929","mano15671","razzak1","kotiwd_bakr_6e","Zongwangmima","Encemo","Muhammad-2003","NotGiveUp","Mishraamit350","fruitchess","NENECHESSN1","Mesonema","ivakoka","TheStarPlayer","Feniks714","Davrishov_Omar","mbechecs","kitziz","williams1982","AlexKom","Vinny_Puk64","Chess_omar_2009","StockchenFichen","davidbretema","omerakifkoman61","Serafim1234","jpw1","JMArnold","MattoxSanYearZero","TYC2020","Anna2323","CHARANA","Acshetty1054","ReinholdNA","A7meb054","MaDeLiNeBaUdEt","ArthurAH21","TURIK_ProFEssAr","lnefi611","vincent11205","nag55","blackstone20091","co_ya","GUNCHA71","kaganoz","Atomic_Is_Back","Motahar92","a_sin","Folen_King","TheFord","mavahom","Denny_the_dog777","BerserkModePlayer","honey2010","Durchstreifenerleben","PeterJumper","Pablo_Ruofan","LightningChess22","lutfinsky72","hichemtall","PrithviRajPrajeesh","dhruvdekoning","Rochade97","Yuvan_raaj8","tt-27","The_King_Crusher","Morenoteambarrio","ChessPatches","richi23941","Phoneix-Eye","Savethemate","Sauce_ta","andyzhao","fonollosa33","Nicolas2013","prvndon","Ryskal","michel1964","algoyany","destroyerantichessFM","Movses12","SweetGreenHoneydew","kaaba2","ARandomMove","kasparov1891","ZaretskyVadim","DartMater","Ivangeorge2010",
"che444","Aruama","fowze","alufhaolam","TksatXmateuS","sever99","Ronnyhernandez89","nahuefcs","mayur713","rodsterdair","westteam","wwcd2012","ovejo1","c-jutsu","KhaledabdelgwwaD","ilkobari4","kanes23","tony1294","BaleevK","Rezo-Masr","matapichis","AariyanMadhu","Kverulant","BansodeSwapnil","Dhrub_Prasad_278","MaSoUd2005","BlackStroke","SaN-AnToNio","Druckschmerz","KrishBhatia1234","MastacticaTeoria","Sayed_ALattar","Dipro888","sergeward22","vsa1974","haarshi2009","Night-King2","M3aouia","pjchess1197","Ferhatkayrak","ShuOuma2","lalalalalalalll","ahmed7777777","TheOldWitcher","LaMetilernantoBrazil","SenseiNgcongo","omar_ms","JacksterThePro","vasiya","Ahmed_7777","BALEOT","ConnorGalvez","monkeyflush","Kxrma","nerocukku","Endermen","ValPilloud","WorldChampion2007","ElmundoCR","Pavlin1214","VadimLeclere","ChessTigran","AKTEP","luis1706","TallMagicalFlamingo","Colamix","DakshBhatia","mendlero","CuentaSecretaJAJA","xh4823","MAXSI","pamacs18121812","Zigisk","Kasplit","KrishBhatia","sensizvagon","zygomatum","Shashorin","victory00099","a3ora6only","superclorinda","ald2","kratos82","HansVDLeiter","ethan12345678","Davking","A-No-Name","xavier2017","icarbama","Titugina","FIL_2010","botellazo","mehdi_af","mertnihat23","garkysh","oleg1974","Plusmacher","Funny1chess","elsenosy","vmf78",
"Chess3Knights","saeid14052","AVIQ184","janisdaudz","ShuuMaster","Elmongd","Ramyzekaria80","Mir3000","ahmed-toly","Aarav1Arora","dimkas4","sriavinsh","NikOlay6","Matik88","Heaven_Fady","Tiger_Claw66","reem123","FuriousTiger","Dr-Yaman","rborfao","KonstHov","fynsta","Entropy_Dragon","Cap_Vin_Spime","hussamaldeen004","Uykucu_Sandy","Eagleeye2020","Tommaso_Corleone","Legend666","MFurkanAlli48","wicked_knight","Dragonzeno","ALLENFERNANDES","arash-behdarvandi","Feuerflieg","MerjenBatyrova","aworldchampion","BenWil","m-schacho","Praveenkumarmani","Tivyakov_vlad","sohamks","gezakekazeg","Airat-1","Gleb-888","RowanTheAwesome","DruggyG","JoseAlvarez07","Mrchess3000","Weisser-Turm","AbdoSoS","MaximMaria2011","parsariazi","Les_Legendaire","solega_20","TeamChessbuddies","kozan-chess123y","Elisey-B","Denis147","DuduRyan","unparalled99","Riko2020_chess","Chali1971","SashaFedotova400","rzvan28","kollege","DimaMishin","RodSeb_2012","I-AM-THE-GRIMM","C4LJamesW","Stefan_Izbinsky","ayat789456123a","GuessWhoIAm15","waist","Rijin-Nadar","KonstantinPlysov","Marczorg","The_Sky_Blazer","Richie78","wingsofchess","Odishababhan10","ReBorN_ReVeNgeR2629","SA_mad","sai1803","aymansdz","Leodan02","Nurcholis","karimovitsh","themarkedone","N00B_RU","ahmedsamehmohamed","DaVoJ","PlayWithFun","FedotovVasily","S7A7L7A7HHHHHH","Chess_warior007","bunOJhTB","ALADANE123","amgadhani1","TamimSrahin",
"Omar2242","shenkafshen","Hamoddah","Majdi_Majdi","EinsteinJunior999","iceman73","CATCANDY","Busina","Muhammedeid777","Sandokanner","krishbird123","rchod","ZMarsson","JoeMineMdr","Pharaohs-Curse","kerollosss_ezat","NItkis2012","ProElcin","Eldar_Yakimov","Gollatzproblem","mhamedlaagab","Drahmedmoamen","ethanl20122012","BedrouneS","SamerOnFire","OLeynik_Alex","Pinuno","basharchess123","An-Onym","DrTamer1","seif2","MarIamalaa","Abdallah515","dida123","ChessAl_Pandeglangi","Schachmatte2345","Akka17","Teshrlyes","RedanoX","MhmadAli123","calmNot","Samaherkattan","jxt_a_panda","samirovic280675","Cleverhero","macsrelax","hamzimosta","AliAyman127","Facuken_sol","KobeKobe24","Zugzuoneg","Ihsan_Kilic","Coffee_Holic","Redano","kayfarik777","BLG125","Klachkou_Platon","derekc1","agunglumumba","JazzmharlB","benjmigz1511","mikhail_tal_23","None_Master","chiz196","Adrian__Chess","c456113","snupper1","gmizavac","mady1313","Aaron52","Perkelt","Milana_F","ruzgaralp2013","Bayern_Schach_Markus","elektroblitz","jeppisan","rckjambi1976","Hokoyoiwe","Cassian","Soypeje","AntiberserkM","A_L_B","FiQui","gopivikram","bryan1234567","KRAMvsKRAM","Gleb2711","Amon_Sul","VatiFelix","Callanad","pradas2056","nurabpi24","Kamilia_02","WANGGHaooo","guest2959","MattImNaechsten","Keith_GM","Le_Ferrailleur","Gary_Cooper","Vordenker",
"nagappan08","PositiveSquadGang","Krzysztof_27","eulaliabt","OrionX_09YV","MatthewBoci_2010","Erik20062009","TinaValentina","ilyesoo","ogitw1","Cheerful_chess","AlbertOOO44444","andjela_djidjika","Sanjarbek_eshpolatov","ManoduraZeus","kka23466","szachmat12345","akystah","Baguette333","unnamedkid2008","Bently001","Worldcupchampion","Vinvin","AScWNiKits","Mr_CHA","Selvam47","Stormflash1","IssacNewt","gmrivas","Chubansky777","IronmanIM","aadisreenu","AMCDiegoTm","Strikes_Softly","B_O_O_M","bassspieler","melkaya_gnida","Antoonyvkl","PeterBoci_2020","mikdadeyo455","nocasr","Luismaher","SuperTyphoon","Ali_1111","FedorRu","Rad2607x","MkrtchyanS","Gu_Stl72","bratetzlis-E","LouisChessBullet","neomensch","lulu-04","ExSponsor","ErnesticoCuba","Mymind2","atharv_mandhare","PeterCavs","balarab-sultan","Lollo007","cape_64","solimsalara","hesham_elmasry3","madhavjoshi_21","kennyscherzer","es191","Bobylinconlloud123","ypey","turtlepie64","Halaow11","Eyad122","lavosier-chess","Igorek2012","vestigeprestige","ZufolgeWeierstrass","TheSimulPlayer","arzu-k","AexnradL","Gatesmicro911","FiLenz","Drunken_Drongo","HighPingAbuser","Player9012","Jupinderjit","ONEPLUS8NORD","Kolesnikov_Kost","vinvivo","Emanuelalfredo","voltage_1964","LUCASNOTLOSINGHEWINS","afiqmuhaimin2008","Saadmer","Chapulineando","BlitzKing22","ketanp","soyalfinegro","nbarony","Sid_Chat","GeOrGeRoY","ChapalDebShuva","bgunes",
"NotAMushroom","AloneChess_YouTube","Ironmaroc84","Ich-lerne-es-nie","S_0907","julesSTS","otters12","Ildragomanucci","Ivana_TAG","OliverGuenther","dmitriyk","bomba10","Cosmicsquirrel","Bhvanamadiwada123","Waqas_410","Arcthc","Juel128","azaytsev2017","pROpC","kasmaran","woll","Eladio_LimIVTacloban","thal_2019","Appelle_moi_Fischer","Adrian_b","davidArtB","javlon07","Whatsup_Danger","sasaltykov","Hi3232","Miteiro","ichess55","mari-tevzadze23","Supernick","ToprakOS","jhu001","JAVLONXONN","jiejie9","slamar123","Mano1432","LafaDragon","NOYAAN","Stormy-ChessWorld","ThomasB2020","Mamasitaisback","ramadan5555","Thmidu2008","Danish175","FabioIm","Kingstown_chess","Mercan80","MubaChessPlayers","Magunya","arda232","Radostniy_bober","Samgamer66","Reyansh30","Felfecir_satranc","anjacota","Dhaarukeesh","AL-absi10","klugeEule","Gabriel2020","chessc777","lorenzo_duebler","Camilo74","erincaku","kaushikezhil09","Jeff16","littleghostrider","sat1611","Efecinco","NADIR1","NeyGuerrero_3PRO","linplayschess","raman123456789","rowelzamora0000","bexron","Baconhairgueste128","pUrpLegReeNniNga","Eliecer_Jimenez","DevotedManatee","bratetzlis-A","Holger_Velisky","IlyaDm","vytuuu","abo_bak_2008","YJChess1-yj_chess","Erwin_1958","Gharibyan-Tigran","karamela444","DeLeonClair09","elparfait","NOMER_1","AbhijitBiswas","KhentErdylDaling5","Zeus_Bill","Dkr1311","alawwyaka","ah_AraD_0_06086",
"JuergenWF","Waidlock9","Abelnoel123","d1V4n","Loscuates","emadam","kobelevegor2007","Sanitajahan","DoctorDrawish","Grossmester2020","Stepan_Zhelobkov","marvin_bronoso","Paolicchia1412","ARubinstein","unbondiable","sarvesh0512","KLASSISCH","WIZARD49","superfastninjaj","B-15_Ivan2007","errabaled","redhorse9fire","Smurf0815","mSchmitz","SniffTal","Mohammad12343","AOOP09","chuvak1603","Nepo2775","Abenaldo10","tkottysch","DK1313","alimohamad1390","Kiyankpatel","Jesper_Simonsen","Solo33","JoseAngel2007","chicofischer","zuziak117","Rinkudon","Mishluch","ShayanShayan","krisses","Almitrachess2","Roman2010","ManvelArtur","Andi0412","Zenisbek","SilvaOmar10","AvengersF","kubxpolandgame","MADMAX-2","Beardeeed","AdiL888","shleev228","chessfish2012","AOOEFI","Yash_raman","TiredPuppet","KoddelHP","DavidRGomez","mehrab_boozhmehrani","alfaomegasas555","Ademola","CAPA67","MJTAHMASEBI","masterofchess1029384","mikele12","Mirabror00777","DIPAK13","moitorras","Samytito99","Sandro3","gmmatteo11","TheJuniorProdigy","PRIT2205","GhostMachinery","ebrahd","Rafayel12","schattenspringer2011","aftabmengal","Avo8","Macedon_pudin","Reno2019","pawnminer","Miraqyan7777777","Ghambaryan2009","SALAH347","tthhai","SJMK","samuelvillaruz","ChesspatzerPHI","Ess_danny","Daniela20california","Rococotte","PFW","SubhabrataRoy2003","schachisttoll","Andy9611","Gundamboy",
"Umidjon2011","chanante","evdekalspor_2020","Josep_h","meysam-ro","czasnaszachy","Akshatagarwal123","EinWildesHazon","Petsona2020","zazabebo","Gufus","ADITHRG","Nemox1","Bgln","DrawingLikeAnish","White-Knight-X","GMTom","drontala64","HarshSurajPlayz","ArnishBasu","patzersoner","abstract_concept","MiguelZaragoza","GilbertoValencia_Caq","pallevente","Abdulazizbek_GM","Srikar-KAN","parfen01","he42","sahebchess","Ventriloquism","babapremnath12","TaigarZindahe","Omnamdev","kuudere8008","g7learn","chenyuan","PlinWave2020","Skarso","buni_cat_30","S_Akash","Pranav-nair78","ChesstheThird","EA_CAPAL","Mr-Energy","edwardjawara","Darklordorus","xmen123","Shivraj__349","ilyasking2005","formerreputation94","Medhanka","kirillgenius","kanishkanithiyapathy","DrNTK","Ejasiel","MX2009","Narpumma2017","Mbah_Bejo_KBPL","Megha-Hatirampur77","Sam881","ubiquti","dlusio","Walterdchess","Louie_2020","schadoup","CantThinkAtAll","Yar2006","Nordkaper","NoneofmyBusiness","UnreinerCalmund","SANVARTA2012","Sattaraustria","KasiMeiyappan","Yugkhiani","forge82","thewinner04","chessknight100","OmarAnssary","Sawant_Diksha","Dr_Knusperkeks","Eshasimuma","sandra-bele_09","Ostin27","papagalli","Abdullah_2014","Sid1410","agnivo2008","FWNietzsche","Mertkapanli1","king1304","CalebSenior","I_LOVE_YOU99","thecca-123","jab17","Chipindrik2","Drbobidrol","Pablo_go","DyLaN2008","burgazmemo12",
"ZaherOmnipotentz","Andialb","Alex-75","MilesW123","Hauts-de-France","Pasindubg","Aryan2311","Rayhan12","suryaputran","flaming241104","decoyIsaac777","Alpinitodecaramelo22","santinosalguero11","Tebarek-Hopk","InferiorWarrior","DanSah12","santibasti","HaPpY_gG","YashRathi2011","DSanya1","Mginsburg","HelgeA","Armin-BB","jokob0","chessplayergood123","heinz_bloed","Toga_Felix","ChessMaster2706","hirya","DKondratev","GlebSvidruk","ChessFamil2008","Maksman_KM","SFNNUE","amuthan09","E09090E95","officialhitomitanaka","FAUM","MouflonChess","A62501433IKER","Sahan2009","FT-physicist","ShahramTiger2000","RapidBlitzPlayer","ElephantZero","Chessnock","FabianPonzo","Mainlander","SirAiden369","elevin25","Tatavafs","CHANAMNE9","Stoic_Player","Koala3113","VIBHAVVIRESHRAWOOL","riturajtamuli2","Caarlsenisback","Faustercio","XXXTeantacion01","Tanabie","ahmad_houmani","ChessaGM","wizarw","RAFAELMALDONADO-5VES","BARCALONA1","successkafle","chris_gl","AntiKlimaktisch","reamadjer21","Mridwanst","leifstrahl","So67_kalra","Cheeky-Gorilla","rajiv30","titoVSanguares","vany_007","Vaibhavi123","BorisDerKommunist","Rafik_Kalijian","snazzybait","Krishav_K","Deeksha7","Dingdongdilli","ModestBee","Greyninja","NoNickButGoodTrick","Wizard0112","PARTH643","markanthonynava","AlchPortugal","Adrianyf","atraiu_mahata","Radiaktivo_Biohazard","randeepnath","Kaanito2011","Luckyboy01","Adhitmisra","AgataDom","SUMANPANDEY2","Ndunlop",
"Paul-MAXENCE","ShreyashRocks","vatsalchess","nafian","Gaudeoo","DanIlaM","Gabriel_Zapata","HeartBreaker0","mano-1610","abhijeet9711","Braveprisoner","marko6azaola","AnonymousTo2800","Divyesh161109","mehakhan","chessfefe","QuarinSoda","Ash18gm","RobertMan2009","ATHARVVED3307","Sharanyo","Mukesh14","miguelucho18","ramz_mihailov","gil13579","Lerox1385","MarianIUrchik1972","Shamyxanov","Fabianbm","FireForceNoChess","BraveBeer","Andre_haas","azoogazla","hinne","crazychess0","Amin_champion_2012","Fugitiveforliving","Lustre_Mark001","Richessie","Kingnightfury","Vova_061110","yuvansingh2009","zavalliaslan","Chess_kosickii","mandarria","tiger2189","Fossarov","Mohammadsaleh2006","DiasporaALB","LinnHansen","Triroxandra","Petterling","DIPTI2511","TimurRizoev","AsilbekBoboqulov_1","mojave2020","tfz76","savva_shmel","FightingFurious","Aleksei_Kireev","Fusion_Droid","Galaxy_Master","anantchess","Hareeshkaarthik2011","Llanfairpwllgwyngyl","overwatch24","The_Matrix_Chess","tb212","JOHANJOBSY","windstern","stingyuncle","Common1608","show-time","ChessGroot","Arad_Nazari","AdityaLovesChess","laura_soares","Ronaldo1234","Sandra666","hemant10","Combinational_CM","JuanPablo22","nella_foresta","DRHOOKK","Ippo-Makanaochi","Bekhruz2010","Thor90","Hisyam_MambaulHisan","Andrei_Reznikov","Artemiy_A","Tirititi","MuthuMadav","ultrascoreR","areen201024","JosepSalguero","Alexander021212","TheQuestionOfChoice","sehasgunasekara","frietimo","SANJAI_SHIVA_2007",
"Fierychamp2009","MJTHEGOAT","Anastasia-17","PALASH_45","AlgaOSH","DenisBorisenko","A-Kawhi","MIGUEL_ST2020","Fireboy69","Johnson_The_Rock","RimidalvSelaznog22","Manan2212","leomiller","emmysscaryspider","abolfazlmf","Krishan123456","Chennakeshavalu","tst2206","Railocarbyne","karpovsazote2","JuanDuran","devedi34","omerk12","wriddhish","Quotet","ClubforfutureGM_bot","AngelLuque","sonic1253","AustinXie","Ogrilla_Fan","Soumilmitra","eshtayderman","shivaansh123","takotak2021","coachidfparis","Belito2013","bkrtv","Gregoryartinsabu","sanjaysundar","giacomomagnific","chess_boy_07","titan00013","HOT5","atulyas2009","SteynSandbergh","Dima-Turov","random_guess","G_Man-Squad","Xhess_Blaster","Leon1001-2","pathani","Tanaka08","MARICONZULETA","levialkerman","Renacer","fernandopacoh","fabio_escudero","Kodalineall-whant","RandyOrtonser","Dalagan_lar09","Nowosibirsk","Vominhnhatmilo","NicoVillalba","ilazhalili","Salm211","minino002","Genius_Revival","alanperalta7","urielperalta7","Busyplayer","Karthik6161131110","kuzeytastekin","Lubyanov_Roman","LBOT007","mfstar17","MJSREVANTH","blancdauphin","ArchismanPatra","CovalentBond","Cuchungo","Sithtropper","alekhinesDefense","crak1221","Ryan10m","s234567","TANGO2020","ANNAMAUSI","zakaria48zaki","emiligamer","KYLOREN07","KomplikadongATAKE","DHAIRYA2006","JEsseMendes","JuFi","nimemr","mdunlop","Avataraang2","Zafarjon2007","PoorPlayerr","PierinaRMurillo",
"Romus12345","naisha_the_winner","vitor12345","Polgar10","keremucucu","Castiel25","wookash_888","AsHnilakAn","SturdyScorpion","UberAlligator","PLEIADIAN-EMISSARY","Satranc_and_Fish","B2KSANJAY","Ron_legend","Chessking248","vaaridgupta1234","MATEONADAL","Vadim-111","Nanuxy","Ch210","anic78","Atharv_Gupta","Swarnadeepnath10","jumakomati2000","Vancud","KingOfThieves","Babebo","ChristopherChabris","ZVEROBOY4IK","KarlMarx20","MarcelChessPlay","ELpezlopex","NaThAnErDeNe","Avataraang7","DareToHackMyAccount","Raimon12","KruemelMoonster","Shiva_S","Dodik_001","RK_ENTRY","AlexSmirnov1990","gabriel_chaves","Hunterr88","MagnusFischer4","timtim56","PhilDaum","Atomic_champion","S_alonzo","Avgustiner","Alpha_Crusher","ManishPlaysChess","Melkumyan","MAX20098","k_i_K","magnusarsen08","AARONSSEBASTIAN","M-Amin-Borji","AirTraning","Chubarov_Denis","Besimrrahmani1","aren2012","sherifhaxhaj1","Er_YasarAbdullah","Kalanoglu","Willydelatorre","juan_264","Dipitashabilidades","a3h3hk","jozhik","Eddymyson","andrzejwuj94","hipno","SimonChrast","Ballsofsteal","unitybuilder","DATTGURU","chessgamer29","tccsarthak","BonneNuitChaton","fgjju07","Alleina","Nilkhant11111111","Zabour","Yura_2010","Mendrec","David2069","Ellsyum","SergioWright","AlanRFMS","Andreas_69","mewstor","jeff_0808","Jeffrey-Romera","EzhilAadhav","Somanshusaha","SimaoRodriguez_6COC","CyricDucks","Rezzanstar","balckit","Pidgurskyi_Yaroslav",
"hasanzenuni","robi8","Melgibson1559","thisis_ferrrari814","Hamdy7777","hpnrlx","Jayanth5372m","iceman2008","superstar987","Sher03","OnlineSatrancLigi","SHTIGER","angel4204","roman_si","protekta","Erathesthenos","Alexej_Cherepov","PedritoLaPiedra","spainscrack","chelseafanclub","Ladamanegra31","mohamedtiger","Ivanbarad","shayanz99","alireza888","YJCHESS","nevpopad","DiamondWIN","Luz_paricagua8","Bavariafanclub","srijitdey","kuka0408","STORMCHESS_ALDEN","Dipayanchess45","Abeer12","Sanjaychess12","Hornitex","Samuel_W","CHESSBALL101","Netherlantsfun","Abhijit2011","AsilbekHaydarov100","VCA_Sanjay_13","strngwrd","James-Jolly","Ruel_37_Catbalogan","Aizen-sama20","NOqueen","IOANNIS2010","KalimullinaKamilya","Aditya-Chincholkar","Feuer1","eli_legends2010","pobeditel5","SD_FIDE_MASTER","ehsanabbasi10000","haringsablay","cristenagacova","Sanctus2020","Imperiality13","KOLDO666","TheNeiro","kemalkaragulle","Sulaymon_0105","kapuso","MahaShiva","Emonej11","JuanEstebanc","BRIAN_KONG","chess32138","Chesspsico","deadly_turtle","ThusSpokeNietzsche","Malesuurmeister","TopMadHouse","Swisher14","nikolamikovic","BERTAUNAI","OrkhanBagir_12_Baku","RobertManukyan2009","ALIXb","Emin916","KAVISHVARAN","annamaria2013","SebD2000","Albert_shaft-20","Sindelfinger","phaenomenologe","DharunBhoopathy","ADITYAJAIN_2005","Coolplay","MatviiAlokhin","jaqueman","Leonschneider333","Arun-Kuga","Rosimayer005","chess_shuen","Chess-Newbie-2004","dinkaaaaa"]

formats = [
         
        {
            "id": 1,
            "name": "Bullet",
            "time": "1",
            "increment": "0"
        },
        {
            "id": 2,
            "name": "Bullet",
            "time": "2",
            "increment": "1"
        },
        {
            "id": 3,
            "name": "Blitz",
            "time": "3",
            "increment": "0"
        },
        {
            "id": 4,
            "name": "Blitz",
            "time": "3",
            "increment": "2"
        },
        {
            "id": 5,
            "name": "Blitz",
            "time": "5",
            "increment": "0"
        },
        {
            "id": 6,
            "name": "Rapid",
            "time": "10",
            "increment": "0"
        },
        {
            "id": 7,
            "name": "Rapid",
            "time": "10",
            "increment": "5"
        },
        {
            "id": 8,
            "name": "Rapid",
            "time": "15",
            "increment": "10"
        },
        {
            "id": 9,
            "name": "Classical",
            "time": "30",
            "increment": "0"
        },
        {
            "id": 10,
            "name": "Classical",
            "time": "30",
            "increment": "20"
        }
    
]

emailTerminations = ["@gmail.com", "@hotmail.com", "@yahoo.com", "@aol.com"]

countries = [ {"name": "Åland Islands", "code": "AX"},
    {"name": "Albania", "code": "AL"},
    {"name": "Algeria", "code": "DZ"},
    {"name": "American Samoa", "code": "AS"},
    {"name": "AndorrA", "code": "AD"},
    {"name": "Angola", "code": "AO"},
    {"name": "Anguilla", "code": "AI"},
    {"name": "Antigua and Barbuda", "code": "AG"},
    {"name": "Argentina", "code": "AR"},
    {"name": "Armenia", "code": "AM"},
    {"name": "Aruba", "code": "AW"},
    {"name": "Australia", "code": "AU"},
    {"name": "Austria", "code": "AT"},
    {"name": "Bahamas", "code": "BS"},
    {"name": "Bahrain", "code": "BH"},
    {"name": "Bangladesh", "code": "BD"},
    {"name": "Barbados", "code": "BB"},
    {"name": "Belize", "code": "BZ"},
    {"name": "Benin", "code": "BJ"},
    {"name": "Bermuda", "code": "BM"},
    {"name": "Bhutan", "code": "BT"},
    {"name": "Bolivia", "code": "BO"},
    {"name": "Bosnia and Herzegovina", "code": "BA"},
    {"name": "Botswana", "code": "BW"},
    {"name": "Bouvet Island", "code": "BV"},
    {"name": "Brazil", "code": "BR"},
    {"name": "British Indian Ocean Territory", "code": "IO"},
    {"name": "Burkina Faso", "code": "BF"},
    {"name": "Burundi", "code": "BI"},
    {"name": "Cambodia", "code": "KH"},
    {"name": "Cameroon", "code": "CM"},
    {"name": "Canada", "code": "CA"},
    {"name": "Cape Verde", "code": "CV"},
    {"name": "Cayman Islands", "code": "KY"},
    {"name": "Central African Republic", "code": "CF"},
    {"name": "Chad", "code": "TD"},
    {"name": "Christmas Island", "code": "CX"},
    {"name": "Cocos (Keeling) Islands", "code": "CC"},
    {"name": "Colombia", "code": "CO"},
    {"name": "Comoros", "code": "KM"},
    {"name": "Congo", "code": "CG"},
    {"name": "Congo, The Democratic Republic of the", "code": "CD"},
    {"name": "Cook Islands", "code": "CK"},
    {"name": "Costa Rica", "code": "CR"},
    {"name": "Cuba", "code": "CU"},
    {"name": "Cyprus", "code": "CY"},
    {"name": "Czech Republic", "code": "CZ"},
    {"name": "Denmark", "code": "DK"},
    {"name": "Djibouti", "code": "DJ"},
    {"name": "Ecuador", "code": "EC"},
    {"name": "Equatorial Guinea", "code": "GQ"},
    {"name": "Eritrea", "code": "ER"},
    {"name": "Estonia", "code": "EE"},
    {"name": "Faroe Islands", "code": "FO"},
    {"name": "Fiji", "code": "FJ"},
    {"name": "French Guiana", "code": "GF"},
    {"name": "French Polynesia", "code": "PF"},
    {"name": "French Southern Territories", "code": "TF"},
    {"name": "Gabon", "code": "GA"},
    {"name": "Gambia", "code": "GM"},
    {"name": "Georgia", "code": "GE"},
    {"name": "Germany", "code": "DE"},
    {"name": "Greece", "code": "GR"},
    {"name": "Greenland", "code": "GL"},
    {"name": "Guam", "code": "GU"},
    {"name": "Guatemala", "code": "GT"},
    {"name": "Guernsey", "code": "GG"},
    {"name": "Guinea", "code": "GN"},
    {"name": "Guinea-Bissau", "code": "GW"},
    {"name": "Honduras", "code": "HN"},
    {"name": "Hong Kong", "code": "HK"},
    {"name": "Iraq", "code": "IQ"},
    {"name": "Ireland", "code": "IE"},
    {"name": "Kiribati", "code": "KI"},
    {"name": "Korea, Republic of", "code": "KR"},
    {"name": "Libyan Arab Jamahiriya", "code": "LY"},
    {"name": "Liechtenstein", "code": "LI"},
    {"name": "Lithuania", "code": "LT"},
    {"name": "Luxembourg", "code": "LU"},
    {"name": "Macao", "code": "MO"},
    {"name": "Malawi", "code": "MW"},
    {"name": "Malaysia", "code": "MY"},
    {"name": "Maldives", "code": "MV"},
    {"name": "Mali", "code": "ML"},
    {"name": "Malta", "code": "MT"},
    {"name": "Marshall Islands", "code": "MH"},
    {"name": "Martinique", "code": "MQ"},
    {"name": "Mauritania", "code": "MR"},
    {"name": "Mauritius", "code": "MU"},
    {"name": "Mayotte", "code": "YT"},
    {"name": "Mexico", "code": "MX"},
    {"name": "Micronesia, Federated States of", "code": "FM"},
    {"name": "Moldova, Republic of", "code": "MD"},
    {"name": "Monaco", "code": "MC"},
    {"name": "Morocco", "code": "MA"},
    {"name": "Mozambique", "code": "MZ"},
    {"name": "Myanmar", "code": "MM"},
    {"name": "Namibia", "code": "NA"},
    {"name": "Netherlands", "code": "NL"},
    {"name": "Netherlands Antilles", "code": "AN"},
    {"name": "New Caledonia", "code": "NC"},
    {"name": "New Zealand", "code": "NZ"},
    {"name": "Nicaragua", "code": "NI"},
    {"name": "Niger", "code": "NE"},
    {"name": "Nigeria", "code": "NG"},
    {"name": "Niue", "code": "NU"},
    {"name": "Northern Mariana Islands", "code": "MP"},
    {"name": "Oman", "code": "OM"},
    {"name": "Panama", "code": "PA"},
    {"name": "Paraguay", "code": "PY"},
    {"name": "Peru", "code": "PE"},
    {"name": "Philippines", "code": "PH"},
    {"name": "Pitcairn", "code": "PN"},
    {"name": "Poland", "code": "PL"},
    {"name": "Portugal", "code": "PT"},
    {"name": "Puerto Rico", "code": "PR"},
    {"name": "Qatar", "code": "QA"},
    {"name": "Reunion", "code": "RE"},
    {"name": "Romania", "code": "RO"},
    {"name": "Saint Helena", "code": "SH"},
    {"name": "Saint Vincent and the Grenadines", "code": "VC"},
    {"name": "Samoa", "code": "WS"},
    {"name": "Sao Tome and Principe", "code": "ST"},
    {"name": "Saudi Arabia", "code": "SA"},
    {"name": "Senegal", "code": "SN"},
    {"name": "Serbia and Montenegro", "code": "CS"},
    {"name": "Seychelles", "code": "SC"},
    {"name": "Sierra Leone", "code": "SL"},
    {"name": "Singapore", "code": "SG"},
    {"name": "Somalia", "code": "SO"},
    {"name": "South Africa", "code": "ZA"},
    {"name": "Sudan", "code": "SD"},
    {"name": "Suriname", "code": "SR"},
    {"name": "Svalbard and Jan Mayen", "code": "SJ"},
    {"name": "Taiwan, Province of China", "code": "TW"},
    {"name": "Tajikistan", "code": "TJ"},
    {"name": "Tanzania, United Republic of", "code": "TZ"},
    {"name": "Thailand", "code": "TH"},
    {"name": "Timor-Leste", "code": "TL"},
    {"name": "Togo", "code": "TG"},
    {"name": "Tokelau", "code": "TK"},
    {"name": "Tonga", "code": "TO"},
    {"name": "Uganda", "code": "UG"},
    {"name": "Ukraine", "code": "UA"},
    {"name": "United Arab Emirates", "code": "AE"},
    {"name": "United Kingdom", "code": "GB"},
    {"name": "United States", "code": "US"},
    {"name": "Vanuatu", "code": "VU"},
    {"name": "Venezuela", "code": "VE"},
    {"name": "Wallis and Futuna", "code": "WF"},
    {"name": "Western Sahara", "code": "EH"},
    {"name": "Yemen", "code": "YE"},
    {"name": "Zambia", "code": "ZM"},
    {"name": "Zimbabwe", "code": "ZW"}
]

titles = [
    "Grandmaster",
    "International Master",
    "Master",
    "Candidate Master",
    "Woman Grandmaster",
    "Woman International Master" ,
    "Woman FIDE Master" ,
    "Woman Candidate Master"
]


tournaments = [
  {
    "name" : "Hourly Bullet Arena",
    "duration" : 47,
    "format": "Bullet"
  },
  {
    "name":"Hourly UltraBullet Arena",
    "duration": 27,
    "format": "Bullet"
  },
  {
    "name":"Hourly Blitz Arena",
    "duration": 57,
    "format": "Blitz"
  },
  {
    "name": "Hourly SuperBlitz Arena",
    "duration": 37,
    "format": "Blitz"
  },
  {
    "name": "Hourly SuperBlitz Arena",
    "duration": 37,
    "format": "Blitz"
  },
  {
    "name": "Hourly Rapid Arena",
    "duration": 37,
    "format": "Rapid"
  },
    {
    "name" : "Daily Bullet Arena",
    "duration" : 47,
    "format": "Bullet"
  },
  {
    "name":"Daily UltraBullet Arena",
    "duration": 27,
    "format": "Bullet"
  },
  {
    "name":"Daily Blitz Arena",
    "duration": 57,
    "format": "Blitz"
  },
  {
    "name": "Daily SuperBlitz Arena",
    "duration": 37,
    "format": "Blitz"
  },
  {
    "name": "Daily SuperBlitz Arena",
    "duration": 37,
    "format": "Blitz"
  },
  {
    "name": "Daily Rapid Arena",
    "duration": 37,
    "format": "Rapid"
  },
  {
    "name": "Daily Classical Arena",
    "duration": 180,
    "format": "Classical"
  },
      {
    "name" : "Monthly Bullet Arena",
    "duration" : 47,
    "format": "Bullet"
  },
  {
    "name":"Monthly UltraBullet Arena",
    "duration": 27,
    "format": "Bullet"
  },
  {
    "name":"Monthly Blitz Arena",
    "duration": 57,
    "format": "Blitz"
  },
  {
    "name": "Monthly SuperBlitz Arena",
    "duration": 37,
    "format": "Blitz"
  },
  {
    "name": "Monthly SuperBlitz Arena",
    "duration": 37,
    "format": "Blitz"
  },
  {
    "name": "Monthly Rapid Arena",
    "duration": 37,
    "format": "Rapid"
  },
  {
    "name": "Monthly Classical Arena",
    "duration": 180,
    "format": "Classical"
  }
]
"""
Problemas:
  Puzzles de jogos aleatorios
  User, descrepancia entre currentPuzzleRating e maxPuzzleRating
  O tournament deve ter um formato
  Duration dos jogos irrealista
  Falta tournaments participation e ratings ganhos e perdidos
"""

startTime = datetime.date(2017, 12, 1)
endTime = datetime.date(2020, 1, 1)
startTimeGame = datetime.date(2017, 12, 1)
endTimeGame = datetime.date(2019, 1, 1)
nUsers = 1000
nFriends = 500
nPuzzles = 10000
nPuzzleRecords = 10000
nTournaments = 100
maxRating = 3000
nGames = 4000
defaultFormatRating = 400
minNMember = 10
maxNMember = 40

def main():
    getUsers()
    getTournaments()
    getOpenings()
    createGames()
    getTeams()
    getFriends()
    getFormats()
    getPuzzles()
    createPuzzleRecords()
    createInsertAllFile()
    return 

#tournaments participation
def createInsertAllFile():
  filenames = ['INSERT_users.sql', 'INSERT_titles.sql', 'INSERT_friends.sql', 'INSERT_teams.sql', 'INSERT_member.sql', 'INSERT_formats.sql', 'INSERT_tournaments.sql', 'INSERT_openings.sql',
              'INSERT_games.sql', 'INSERT_ranked.sql', 'INSERT_casual.sql', 'INSERT_classified.sql', 'INSERT_theme.sql', 'INSERT_puzzles.sql', 'INSERT_puzzleTheme.sql', 'INSERT_puzzleRecords.sql']
  with open('INSERT_ALL.sql', 'w') as outfile:
      for fname in filenames:
          with open(fname) as infile:
              for line in infile:
                  outfile.write(line)

def getTeams():    
    sqlTeam = "" 
    sqlMembers = ""
    jsonMembers = []

    with open("JSON_users.json") as json_file:
      users = json.load(json_file)
    
    for team in listTeams:
      sqlTeam += f"INSERT INTO Chess_Team ([Name],Leader,[Description]) VALUES (\'{team['name']}\', \'{team['leader']}\', \'{team['description']}\')\n"
      
      #create members
      nMembers = random.randint(minNMember,maxNMember)
      for i in range(0,nMembers):
        username = random.choice(users)["username"]
        jsonMembers.append({'Team': team['name'], 'User': username})
        sqlMembers += f"INSERT INTO Chess_Member (Team,[User]) VALUES (\'{team['name']}\', \'{username}\')\n"
    
    file = open("INSERT_teams.sql", "w")
    file.write(sqlTeam)
    file.close()

    file = open("JSON_teams.json","w")
    file.write(json.dumps(listTeams, indent=2))
    file.close()

    file = open("INSERT_member.sql", "w")
    file.write(sqlMembers)
    file.close()

    file = open("JSON_member.json","w")
    file.write(json.dumps(jsonMembers, indent=2))
    file.close()

def getClassified(username):

  classifiedSql = ""
  classifiedJson = []
  for format in formats:
    if(random.randint(1,100) > 30):
        formatId = format["id"] 
        currentFormatRating = random.randint(defaultFormatRating,maxRating)
        maxFormatRating = random.randint(currentFormatRating,currentFormatRating+500)

        classifiedSql += "INSERT INTO Chess_Classified([User],[FormatID],Position,MaxRating,CurrentRating) VALUES " + \
                         f"(\'{username}\', \'{formatId}\', DEFAULT, \'{maxFormatRating}\', \'{currentFormatRating}\')\n"
        classifiedJson.append({"User": username, "FormatID": formatId, "Position": "DEFAULT", "MaxRating": maxFormatRating, "CurrentRating": currentFormatRating})
  
  return [classifiedSql, classifiedJson]

def getUsers():
    
    users = []
    usersSql = ""
    classifiedSql = ""
    classifiedJson = []
    titlesSql = ""
    titlesJson = []

    i = 0
    for user in listUsers:
        if(i >= nUsers):
          break
        username = user
        password = random_string_generator()
        name = user
        email = user + random.choice(emailTerminations)
        country = random.choice(countries)['name']
        registationDate = random_date_between_range(startTime, endTime)
        
        if (random.randint(1,100) <= 10):
          title = random.choice(titles)
          titlesSql += "INSERT INTO Chess_UserTitle ([User], Title) " + \
                     f"VALUES (\'{username}\', \'{title}\')\n"
          titlesJson.append({"User": username,"Title": title})
        currentPuzzleRating = random.randint(defaultFormatRating,maxRating)
        maxPuzzleRating = random.randint(currentPuzzleRating,currentPuzzleRating+500)
        usersSql += f"INSERT INTO Chess_User (Username,[Password],[Name],Country,Email,RegistrationDate,MaxPuzzleRating,CurrentPuzzleRating) VALUES \n(\'{username}\', \'{password}\', \'{name}\', \'{country}\', \'{email}\', \'{registationDate.__str__()}\', \'{maxPuzzleRating}\', \'{currentPuzzleRating}\')\n"
        users.append({'userId': i + 1, 'username': username, 'password': password, 'name': name, 'email': email, 'country': country, 'registationDate': registationDate.__str__(), 'currentPuzzleRating': currentPuzzleRating, 'maxPuzzleRating': maxPuzzleRating})
        
        [userClSql, userClJson] = getClassified(username)
        classifiedJson.append(userClJson)
        classifiedSql += userClSql

        i += 1

    file = open("INSERT_classified.sql", "w")
    file.write(classifiedSql)
    file.close()
    file = open("JSON_classified.json", "w")
    file.write(json.dumps(classifiedJson, indent=2))
    file.close()

    file = open("JSON_users.json", 'w')
    file.write(json.dumps(users,indent=2))
    file.close()
    file = open("INSERT_users.sql", "w")
    file.write(usersSql)
    file.close()

    file = open("JSON_titles.json", 'w')
    file.write(json.dumps(titlesJson,indent=2))
    file.close()
    file = open("INSERT_titles.sql", "w")
    file.write(titlesSql)
    file.close()

def getFriends():
  friendsSql = ""
  friendsJson = []

  friends = []

  for i in range(1,nFriends):
    friend1 = random.choice(listUsers[0: nUsers])
    friend2 = random.choice(listUsers[0: nUsers]) 
    while(friend2 == friend1):
      friend2 = random.choice(listUsers)

    friendship = {friend1, friend2}
    friendshipL = list(friendship)

    if(friendship not in friends):
      friends.append(friendship)
      friendsJson.append({'Suser': friendshipL[0], 'TUser': friendshipL[1]})
      friendsSql += f"INSERT INTO Chess_Friends (SUsername, TUsername) VALUES (\'{friendshipL[0]}\', \'{friendshipL[1]}\')\n"

    fileFriends = open("INSERT_friends.sql", "w")
    fileFriends.write(friendsSql)
    fileFriends.close()

    fileFriends = open("JSON_friends.json", "w")
    fileFriends.write(json.dumps(friendsJson, indent=2))
    fileFriends.close()

def createUsermames():
    userFile = open("rochade-europa-schachzeitung_users", 'r', encoding='utf-8')
    userFile.close()

    str = ""
    for i in range(0,nUsers):
        line = userFile.readline()
        str += "\"" + json.loads(line)["username"] + "\","
        if(i % 100 == 0):
            str += "\n"

    print(str)

#user1 - white, user2 - black
def createCasualRecord(user1ID, user2ID, gameID):
  casualRecordSql = ""
  casualRecordJson = []

  casualRecordJson.append({"user": user1ID, "game":gameID, "Color": "White"})
  casualRecordJson.append({"user": user2ID, "game":gameID, "Color": "Black"})
  
  casualRecordSql += f"INSERT INTO Chess_Casual ([User], Game, Color) VALUES (\'{user1ID}\', \'{gameID}\', \'White\')\n"
  casualRecordSql += f"INSERT INTO Chess_Casual ([User], Game, Color) VALUES (\'{user2ID}\', \'{gameID}\', \'Black\')\n"

  return [casualRecordJson, casualRecordSql]

#user1 - white, user2 - black
def createRankedRecord(user1ID, user1Rating, user2ID, user2Rating, gameID):
  rankedRecordSql = ""
  rankedRecordJson = []

  rankedRecordJson.append({"user": user1ID, "game":gameID, "Color": "White", "Rating": user1Rating})
  rankedRecordJson.append({"user": user2ID, "game":gameID, "Color": "Black", "Rating": user2Rating})
  
  rankedRecordSql += f"INSERT INTO Chess_Ranked ([User], Game, Color, Rating) VALUES (\'{user1ID}\', \'{gameID}\', \'White\', \'{user1Rating}\')\n"
  rankedRecordSql += f"INSERT INTO Chess_Ranked ([User], Game, Color, Rating) VALUES (\'{user2ID}\', \'{gameID}\', \'Black\', \'{user2Rating}\')\n"

  return [rankedRecordJson, rankedRecordSql]

def createPuzzleRecords():
  puzzleRecordJson = []
  puzzleRecordSql = ""

  with open("JSON_puzzles.json") as json_file:
    puzzles = json.load(json_file)
  
  with open("JSON_users.json") as json_file:
    users = json.load(json_file)

  for i in range(0, nPuzzleRecords):
      user = random.choice(users)
      username = user["username"]
      [y, m, d] = map(lambda x: int(x), user["registationDate"].split("-"))
      date = random_date_between_range(datetime.date(y, m, d), endTime).__str__()
      puzzle = random.choice(puzzles)
      rating = users[0]["maxPuzzleRating"]
      rating = rating - random.randint(d,800)
      while(rating < 0):
        rating = rating - random.randint(1,400)
      puzzleID = puzzle["id"]
      puzzleRecordSql += "INSERT INTO Chess_PuzzleRecord ([User],RecordDate,Rating, PuzzleID) " + \
                      f"VALUES (\'{username}\', \'{date}\',\'{rating}\',\'{puzzleID}\')\n"
      puzzleRecordJson.append({ "ID": i + 1, "User": username, "RecordDate": date, "Rating": rating, "PuzzleID": puzzleID})

  file = open("INSERT_puzzleRecords.sql", "w")
  file.write(puzzleRecordSql)
  file.close()

  file = open("JSON_puzzleRecords.json", "w")
  file.write(json.dumps(puzzleRecordJson, indent=2))
  file.close()

def createGames():
  openings = None
  with open("JSON_openings.json") as json_file:
    openings = json.load(json_file)

  with open("JSON_users.json") as json_file:
    users = json.load(json_file)
  
  with open("JSON_classified.json") as json_file:
    classified = json.load(json_file)

  with open("JSON_tournaments.json") as json_file:
    tournaments = json.load(json_file)
  
  def readGame(i, games, tournamentID = None, date = None, type = None, format = None):
    line = games.readline()[1:-2]

    gameJson = []
    gameSql = ""

    if(line != ""):
      [name, content] = line.split(" ", 1)
    while name != "Result":
      line = games.readline()[1:-2]
    
      if(line != ""):
        [name, content] = line.split(" ", 1)
    
    if content[1:-2] == "1-0":
      result = "black" 
    elif content[1:-2] == "0-1":
      result = "white"
    else:
      result = "draw" 

    while name != "Opening":
      line = games.readline()[1:-2]
  
      if(line != ""):
        [name, content] = line.split(" ", 1)
    
    openingName = content[1:-1]

    while name != "Termination":
      line = games.readline()[1:-2]
      if(line != ""):
        [name, content] = line.split(" ", 1)

    termination = content[1:-1]

    while name != "1.":
      line = games.readline()
      if(line != "" and line != "\n"):
        [name, content] = line.split(" ", 1)

    pgn = name + content[0:-1]

    duration = "{:02d}:{:02d}".format(random.randint(1,59), random.randint(1,59))
    gameDate = random_date_between_range(startTimeGame, endTimeGame).__str__() if date == None else date.__str__()
    opening = [open["id"] for open in openings if openingName == open["Name"] or open["Name"] in openingName]
    openingID = opening[0] if opening != [] else random.choice(openings)["id"] 
    formatID = random.choice(formats)["id"] if format == None else format
    tourID = "NULL" if ( tournamentID == None) else tournamentID

    gameJson = {"id": i+1, "duration": duration , "PGN": pgn, "GameDate": gameDate
                      , "Outcome": termination, "FormatID": formatID, "OpeningID": openingID, "tournamentID": tourID}

    gameSql = "INSERT INTO Chess_Game (Duration,PGN,GameDate,OutCome,FormatID,OpeningID,TournamentID) VALUES" + \
               f"(\'{duration}\',\'{pgn}\', \'{gameDate}\', \'{termination}\', \'{formatID}\',\'{openingID}\',{tourID})\n" 


    cJson = None
    cSql = None
    rJson = None
    rSql  = None
    if(tournamentID == None):
      #Choose between causal and ranked
      gameType = random.choice(["ranked", "casual"])
  
      #Choose players and create game records
      #bug
      p1 = random.choice(users)
      while(p1["registationDate"] < gameDate):
        p1 = random.choice(users)
      
      p2 = random.choice(users)
      while(p2["registationDate"] < gameDate):
        p2 = random.choice(users)

      if(gameType == "casual"):
        [cJson, cSql] = createCasualRecord(p1["username"], p2["username"], i+1)
      
      else:
        p1FormatsCl = classified[p1["userId"] - 1]
        p1Ratings = [cl for cl in p1FormatsCl if cl["FormatID"] == formatID ]
        
        if p1Ratings == []:
          p1Rating = 400 
        else:
          p1Rating = p1Ratings[0]["MaxRating"]
          p1Rating = p1Rating - random.randint(1,800)
          while(p1Rating <= 0):
            p1Rating = p1Ratings[0]["MaxRating"] - random.randint(1,800)

            
        p2FormatsCl = classified[p2["userId"] - 1]
        p2Ratings = [cl for cl in p2FormatsCl if cl["FormatID"] == formatID ]
        if p2Ratings == []:
          p2Rating = 400 
        else:
          p2Rating = p2Ratings[0]["MaxRating"]
          p2Rating = p2Rating - random.randint(1,800)
          while(p2Rating <= 0):
            p2Rating = p2Ratings[0]["MaxRating"] - random.randint(1,800)
        
        [rJson, rSql] = createRankedRecord(p1["username"], p1Rating, p2["username"], p2Rating, i+1)
        
    else:
      tournament = tournaments[tournamentID - 1]
      gameType = type
      #Choose players and create game records
      #bug
      p1 = random.choice(users)
      while(p1["registationDate"] < gameDate):
        p1 = random.choice(users)
      
      p2 = random.choice(users)
      while(p2["registationDate"] < gameDate):
        p2 = random.choice(users)

      if(gameType == "casual"):
        [cJson, cSql] = createCasualRecord(p1["username"], p2["username"], i+1)
      
      else:
        p1FormatsCl = classified[p1["userId"] - 1]
        p1Ratings = [cl for cl in p1FormatsCl if cl["FormatID"] == formatID ]
        flag = False
        x = 0
        while(not flag):
          if p1Ratings == []:
            p1Rating = 400
          else:
            p1Rating = p1Ratings[0]["MaxRating"]
            p1Rating = p1Rating - random.randint(1,800)
            while(p1Rating <= 0):
              p1Rating = p1Ratings[0]["MaxRating"] - random.randint(1,800)

          if(tournament["MaxRating"] != "NULL" and tournament["MaxRating"] < p1Rating) or (tournament["MinRating"] != "NULL" and tournament["MinRating"] > p1Rating):
            
            #Choose another player
            p1 = random.choice(users)
            while(p1["registationDate"] < gameDate):
              p1 = random.choice(users)
            p1FormatsCl = classified[p1["userId"] - 1]
            p1Ratings = [cl for cl in p1FormatsCl if cl["FormatID"] == formatID ]
          else:
            flag = True
          print("Creating tournaments games: " + str(x))
          x += 1
        p2FormatsCl = classified[p2["userId"] - 1]
        p2Ratings = [cl for cl in p2FormatsCl if cl["FormatID"] == formatID ]

        flag = False
        x = 0
        while(not flag):

          if p2Ratings == []:
            p2Rating = 400 
          else:
            p2Rating = p2Ratings[0]["MaxRating"]
            p2Rating = p2Rating - random.randint(1,800)
            while(p2Rating <= 0):
              p2Rating = p2Ratings[0]["MaxRating"] - random.randint(1,800)

          if(tournament["MaxRating"] != "NULL" and tournament["MaxRating"] < p2Rating) or (tournament["MinRating"] != "NULL" and tournament["MinRating"] > p2Rating):
            #Choose another player
            p2 = random.choice(users)
            while(p2["registationDate"] < gameDate):
              p2 = random.choice(users)
            P2FormatsCl = classified[p2["userId"] - 1]
            p2Ratings = [cl for cl in P2FormatsCl if cl["FormatID"] == formatID ]
          else:
            flag = True
          print("Creating tournaments games: " + str(x))
          x += 1
        [rJson, rSql] = createRankedRecord(p1["username"], p1Rating, p2["username"], p2Rating, i+1)

    return [gameJson, gameSql, rJson, rSql, cJson, cSql]
  
  
  games = open("games", "r")
  tournamentGames = open("gamesTournament", "r")
  gamesJson = []
  gamesSql = ""
  casualJson = [] 
  casualSql = ""
  rankedJson = []
  rankedSql = ""
  
  i = 0
  while i < nGames:
    [gameJson, gameSql, rJson, rSql, cJson, cSql] = readGame(i, games)
    games.readline()

    gamesJson.append(gameJson)
    gamesSql += gameSql
    if(rJson != None):
      rankedJson.append(rJson)
      rankedSql += rSql
    if(cJson != None):
      casualJson.append(cJson)
      casualSql += cSql
    i += 1

  
  listNGames = []
  for n in range(0, nTournaments):
    listNGames.append(random.randint(30, 50))
  
  nTournamentGames = functools.reduce(lambda a, b: a + b, listNGames)

  for t in range(0, nTournaments):
    tournamentDate = tournaments[t]["Date"]
    tournamentType = "casual" if tournaments[t]["MaxRating"] == "NULL" else "ranked"
    tournamentFormat = tournaments[t]["Format"]
    for n in range(0, listNGames[t]):
      [gameJson, gameSql, rJson, rSql, cJson, cSql] = readGame(i, tournamentGames, t + 1, tournamentDate, tournamentType, tournamentFormat)
      tournamentGames.readline()
      gamesJson.append(gameJson)
      gamesSql += gameSql
      if(rJson != None):
        rankedJson.append(rJson)
        rankedSql += rSql
      if(cJson != None):
        casualJson.append(cJson)
        casualSql += cSql
      i += 1
    print("Tournament: "+ str(t) )
  print(i)
  file = open("JSON_games.json","w")
  file.write(json.dumps(gamesJson, indent=2))
  file.close()
  file = open("INSERT_games.sql","w")
  file.write(gamesSql)
  file.close()
  file = open("JSON_ranked.json","w")
  file.write(json.dumps(rankedJson, indent=2))
  file.close()
  file = open("INSERT_ranked.sql","w")
  file.write(rankedSql)
  file.close()
  file = open("JSON_casual.json","w")
  file.write(json.dumps(casualJson, indent=2))
  file.close()
  file = open("INSERT_casual.sql","w")
  file.write(casualSql)
  file.close()
  
  games.close()

def getFormats():
    
    formatSql = ""
    for format in formats:
        formatSql += f"INSERT INTO Chess_Format ([Name],ClockTime,ClockIncrement) VALUES (\'{format['name']}\', \'{format['time']}\', \'{format['increment']}\')\n"
    jsonFormats = json.dumps(formats,indent=2)
    file = open("JSON_formats.json", 'w')
    file.write(jsonFormats)
    file.close()
    file = open("INSERT_formats.sql", "w")
    file.write(formatSql)
    file.close()

def getOpenings():
    fileOpenings = open("ECO.json", "r")
    openings = json.loads(fileOpenings.read())
    fileOpenings.close()

    openingsSql = ""
    openingsJson = []
    i = 1
    for opening in openings:
        openingName = opening['name'].replace("'","''")
        openingsSql += f"INSERT INTO Chess_Opening (ECOCode,[Name],Pattern) VALUES (\'{opening['eco']}\', \'{openingName}\',\'{opening['moves']}\'  )\n"
        openingsJson.append({ "id": i,"ECOCode": opening['eco'], "Name": opening['name'],"Pattern": opening['moves'] })
        i += 1
    fileOpenings = open("INSERT_openings.sql", "w")
    fileOpenings.write(openingsSql)
    fileOpenings.close()
    fileOpenings = open("JSON_openings.json", "w")
    fileOpenings.write(json.dumps(openingsJson, indent=2))
    fileOpenings.close()

def getTournaments():

  tournamentJson = []
  tournamentSql = ""

  for i in range(0, nTournaments):
    tournament = random.choice(tournaments)
    name = tournament["name"]
    duration = tournament["duration"]
    format = random.choice([f for f in formats if (tournament["format"] == f["name"])])["id"]
    date = random_date_between_range(startTimeGame, endTimeGame).__str__()
    description = f"This is a {name}"

    max = "NULL"
    min = "NULL"
    if(random.randint(0,100) < 50):
      max = random.randint(maxRating/2,maxRating)
      min = max - random.choice([400, 500, 600, 800])
    
    tmpRating = f"\'{max}\',\'{min}\')\n" if max != "NULL" else "NULL,NULL)\n"
    tournamentSql += "INSERT INTO Chess_Tournament ([Name],[Date],Duration,[Description],FormatID,MaxRating,MinRating) " + \
                     f"VALUES (\'{name}\', \'{date}\',\'{duration}\',\'{description}\',\'{format}\'," + tmpRating
    tournamentJson.append({ "ID": i + 1, "Name": name, "Date": date, "Duration": duration, "Description": description,
                            "MaxRating": max , "MinRating": min ,
                            "Format": format  })
    
  fileOpenings = open("INSERT_tournaments.sql", "w")
  fileOpenings.write(tournamentSql)
  fileOpenings.close()
  fileOpenings = open("JSON_tournaments.json", "w")
  fileOpenings.write(json.dumps(tournamentJson, indent=2))
  fileOpenings.close()

"""
adaptar theme para ER novo
"""
def getPuzzles():
    puzzleJson = []
    puzzleSql = ""
    
    puzzleThemeJson = []
    puzzleThemeSql = ""

    themes = []
    themeJson = []
    themeSql = ""

    i = 0
    with open("lichess_db_puzzle.csv") as csvfile:
        reader = csv.reader(csvfile, delimiter=",")
        for row in reader:
            if i == nPuzzles:
              break
            puzzleThemes = row[7].split(" ")
            gameID = random.randint(1,nGames)
            #create themes
            for theme in puzzleThemes:
              if(theme not in themes):
                themes.append(theme)
                themeJson.append({'ID': themes.__len__(), 'Name': theme})
                themeSql += f"INSERT INTO Chess_Theme (Name) VALUES (\'{theme}\')\n"
              themeID = themes.index(theme) + 1
              puzzleThemeJson.append({'PuzzleID': i+1, 'ThemeID': themeID})
              puzzleThemeSql += f"INSERT INTO Chess_PuzzleTheme (PuzzleID, ThemeID) VALUES (\'{i}\', \'{themeID}\')\n"
            puzzleJson.append({'id': i + 1 ,'fen' : row[1], 'moves': row[2], 'rating': row[3], 'themes': themes, 'game': gameID})
            puzzleSql += f"INSERT INTO Chess_Puzzle (Rating, InicialPlay, solution, GameID) VALUES (\'{row[3]}\', \'{row[1]}\', \'{row[2]}\', \'{gameID}\')\n"
            
            i += 1

    file = open("JSON_puzzles.json", 'w')
    file.write(json.dumps(puzzleJson, indent=2))
    file.close()

    file = open("INSERT_puzzles.sql", 'w')
    file.write(puzzleSql)
    file.close()

    file = open("JSON_puzzleTheme.json", 'w')
    file.write(json.dumps(puzzleThemeJson, indent=2))
    file.close()

    file = open("INSERT_puzzleTheme.sql", 'w')
    file.write(puzzleThemeSql)
    file.close()

    file = open("JSON_theme.json", 'w')
    file.write(json.dumps(themeJson, indent=2))
    file.close()

    file = open("INSERT_theme.sql", 'w')
    file.write(themeSql)
    file.close()


def random_date_between_range(start_date, end_date):
    time_between_dates = end_date - start_date
    days_between_dates = time_between_dates.days
    random_number_of_days = random.randrange(days_between_dates)
    return start_date + datetime.timedelta(days=random_number_of_days)

def random_string_generator(size=10, chars=string.ascii_uppercase + string.digits):
   return ''.join(random.choice(chars) for _ in range(size))        

main()
