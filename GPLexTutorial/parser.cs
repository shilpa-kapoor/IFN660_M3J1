// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  DESKTOP-IRIVFD3
// DateTime: 25/03/2017 5:30:10 PM
// UserName: Samarth
// Input file <parser.y - 25/03/2017 5:30:06 PM>

// options: lines gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace GPLexTutorial
{
public enum Tokens {
    error=127,EOF=128,NUMBER=129,IDENT=130,FLOATLITERAL=131,STRINGLITERAL=132,
    BOOL=133,ABSTRACT=134,ASSERT=135,BOOLEAN=136,BREAK=137,BYTE=138,
    CASE=139,CATCH=140,CHAR=141,CLASS=142,CONST=143,CONTINUE=144,
    DEFAULT=145,DO=146,DOUBLE=147,ELSE=148,ENUM=149,EXTENDS=150,
    FINAL=151,FINALLY=152,FLOAT=153,FOR=154,IF=155,GOTO=156,
    IMPLEMENTS=157,IMPORT=158,INSTANCEOF=159,INT=160,INTERFACE=161,LONG=162,
    NATIVE=163,NEW=164,PACKAGE=165,PRIVATE=166,PROTECTED=167,PUBLIC=168,
    RETURN=169,SHORT=170,STATIC=171,STRICTFP=172,SUPER=173,SWITCH=174,
    SYNCHRONIZED=175,THIS=176,THROW=177,THROWS=178,TRANSIENT=179,TRY=180,
    VOID=181,VOLATILE=182,WHILE=183,IntegerLiteral=184,CharacterLiteral=185,NULL=186,
    OPERATOR=187,TRUE=188,FALSE=189,EndOfLineComment=190,TraditionalComment=191};

public struct ValueType
#line 4 "parser.y"
{
    public int num;
    public string name;
    public float floatValue;
    public string stringValue;
    public bool boolValue;
}
#line default
// Abstract base class for GPLEX scanners
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class ScanObj {
  public int token;
  public ValueType yylval;
  public LexLocation yylloc;
  public ScanObj( int t, ValueType val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[128];
  private static State[] states = new State[163];
  private static string[] nonTerms = new string[] {
      "CompilationUnit", "$accept", "PackageDeclarations", "ImportDeclarations", 
      "TypeDeclarations", "PackageDeclaration", "PackageModifiers", "ColonSeparatedIdents", 
      "PackageModifier", "Annotation", "Annotations", "NormalAnnotation", "MarkerAnnotation", 
      "SingleElementAnnotation", "ImportDeclaration", "SingleTypeImportDeclaration", 
      "TypeImportOnDemandDeclaration", "SingleStaticImportDeclaration", "StaticImportOnDemandDeclaration", 
      "TypeDeclaration", "ClassDeclaration", "InterfaceDeclaration", "NormalClassDeclaration", 
      "EnumDeclaration", "ClassModifiers", "TypeParameters", "Superclasses", 
      "Superinterfaces", "ClassBody", "Superclass", "ClassType", "TypeArguments", 
      "ClassOrInterfaceType", "InterfaceType", "InterfaceTypeList", "ComaSeparatedInterfaceTypeList", 
      "ClassModifier", "ClassBodyDeclarations", "ClassBodyDeclaration", "ClassMemberDeclaration", 
      "MethodDeclaration", "MethodModifiers", "MethodHeader", "MethodBody", "Block", 
      "BlockStatements", "BlockStatement", "LocalVariableDeclarationStatement", 
      "LocalVariableDeclaration", "VariableModifiers", "UnannType", "VariableDeclaratorList", 
      "UnannPrimitiveType", "NumericType", "IntegralType", "VariableDeclarator", 
      "VariableDeclarators", "VariableDeclaratorId", "VariableInitializer", "Identifier", 
      "Dims", "EnumBody", "NormalInterfaceDeclaration", "AnnotationTypeDeclaration", 
      "InterfaceModifiers", "ExtendsInterfaces", "InterfaceBody", "AnnotationTypeBody", 
      "InterfaceModifier", "TypeName", "PackageOrTypeName", };

  static Parser() {
    states[0] = new State(new int[]{165,-9,158,-5,168,-5,167,-5,166,-5,134,-5,171,-5,151,-5,142,-5,149,-5,161,-5,64,-5,128,-5},new int[]{-1,1,-3,3,-6,150,-7,152,-9,160,-10,162,-12,69,-13,70,-14,71});
    states[1] = new State(new int[]{128,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{158,131,168,-25,167,-25,166,-25,134,-25,171,-25,151,-25,142,-25,149,-25,161,-25,64,-25,128,-25},new int[]{-4,4,-15,128,-16,130,-17,147,-18,148,-19,149});
    states[4] = new State(new int[]{168,96,167,97,166,98,134,99,171,100,151,95,142,-56,149,-56,161,-114,64,-114,128,-32},new int[]{-5,5,-20,6,-21,8,-23,9,-25,10,-37,88,-24,101,-22,102,-63,103,-65,104,-69,120,-64,127});
    states[5] = new State(-2);
    states[6] = new State(new int[]{168,96,167,97,166,98,134,99,171,100,151,95,128,-30,142,-56,149,-56,161,-114,64,-114},new int[]{-5,7,-20,6,-21,8,-23,9,-25,10,-37,88,-24,101,-22,102,-63,103,-65,104,-69,120,-64,127});
    states[7] = new State(-31);
    states[8] = new State(-33);
    states[9] = new State(-35);
    states[10] = new State(new int[]{142,11,149,82});
    states[11] = new State(new int[]{130,12});
    states[12] = new State(-109,new int[]{-26,13});
    states[13] = new State(new int[]{150,79,157,-40,123,-40},new int[]{-27,14,-30,77});
    states[14] = new State(new int[]{157,56,123,-48},new int[]{-28,15});
    states[15] = new State(new int[]{123,16});
    states[16] = new State(new int[]{123,19,125,-64},new int[]{-29,17});
    states[17] = new State(new int[]{125,18});
    states[18] = new State(-37);
    states[19] = new State(new int[]{123,-73,138,-73,170,-73,160,-73,162,-73,141,-73,125,-66},new int[]{-38,20,-39,22,-40,23,-41,24,-42,25});
    states[20] = new State(new int[]{125,21});
    states[21] = new State(-63);
    states[22] = new State(-65);
    states[23] = new State(-67);
    states[24] = new State(-69);
    states[25] = new State(-74,new int[]{-43,26});
    states[26] = new State(new int[]{123,29,138,-83,170,-83,160,-83,162,-83,141,-83,125,-76},new int[]{-44,27,-45,28,-47,32,-48,34,-49,35,-50,37});
    states[27] = new State(-71);
    states[28] = new State(-75);
    states[29] = new State(-79,new int[]{-46,30});
    states[30] = new State(new int[]{125,31});
    states[31] = new State(-77);
    states[32] = new State(-79,new int[]{-46,33});
    states[33] = new State(-78);
    states[34] = new State(-80);
    states[35] = new State(new int[]{59,36});
    states[36] = new State(-81);
    states[37] = new State(new int[]{138,51,170,52,160,53,162,54,141,55},new int[]{-51,38,-53,48,-54,49,-55,50});
    states[38] = new State(new int[]{130,47},new int[]{-52,39,-56,40,-58,42,-60,45});
    states[39] = new State(-82);
    states[40] = new State(-92,new int[]{-57,41});
    states[41] = new State(-93);
    states[42] = new State(new int[]{61,43,59,-95});
    states[43] = new State(-101,new int[]{-59,44});
    states[44] = new State(-96);
    states[45] = new State(-97,new int[]{-61,46});
    states[46] = new State(-98);
    states[47] = new State(-99);
    states[48] = new State(-84);
    states[49] = new State(-85);
    states[50] = new State(-86);
    states[51] = new State(-87);
    states[52] = new State(-88);
    states[53] = new State(-89);
    states[54] = new State(-90);
    states[55] = new State(-91);
    states[56] = new State(-13,new int[]{-35,57,-34,58,-31,63,-11,64,-10,67,-12,69,-13,70,-14,71,-33,72});
    states[57] = new State(-47);
    states[58] = new State(new int[]{44,60,46,-45,123,-52},new int[]{-36,59});
    states[59] = new State(-49);
    states[60] = new State(-13,new int[]{-34,61,-31,63,-11,64,-10,67,-12,69,-13,70,-14,71,-33,72});
    states[61] = new State(new int[]{44,60,123,-50,46,-45},new int[]{-36,62});
    states[62] = new State(-51);
    states[63] = new State(new int[]{44,-53,123,-53,46,-44});
    states[64] = new State(new int[]{130,65});
    states[65] = new State(-46,new int[]{-32,66});
    states[66] = new State(-42);
    states[67] = new State(-11,new int[]{-11,68,-10,67,-12,69,-13,70,-14,71});
    states[68] = new State(-12);
    states[69] = new State(-14);
    states[70] = new State(-15);
    states[71] = new State(-16);
    states[72] = new State(new int[]{46,73});
    states[73] = new State(-13,new int[]{-11,74,-10,67,-12,69,-13,70,-14,71});
    states[74] = new State(new int[]{130,75});
    states[75] = new State(-46,new int[]{-32,76});
    states[76] = new State(-43);
    states[77] = new State(new int[]{150,79,157,-38,123,-38},new int[]{-27,78,-30,77});
    states[78] = new State(-39);
    states[79] = new State(-13,new int[]{-31,80,-11,64,-10,67,-12,69,-13,70,-14,71,-33,72,-34,81});
    states[80] = new State(new int[]{150,-41,157,-41,123,-41,46,-44});
    states[81] = new State(-45);
    states[82] = new State(new int[]{130,83});
    states[83] = new State(new int[]{157,56,123,-48},new int[]{-28,84});
    states[84] = new State(new int[]{123,86},new int[]{-62,85});
    states[85] = new State(-102);
    states[86] = new State(new int[]{125,87});
    states[87] = new State(-103);
    states[88] = new State(new int[]{168,90,167,91,166,92,134,93,171,94,151,95,142,-54,149,-54},new int[]{-25,89,-37,88});
    states[89] = new State(-55);
    states[90] = new State(-57);
    states[91] = new State(-58);
    states[92] = new State(-59);
    states[93] = new State(-60);
    states[94] = new State(-61);
    states[95] = new State(-62);
    states[96] = new State(new int[]{168,-57,167,-57,166,-57,134,-57,171,-57,151,-57,142,-57,149,-57,161,-115,64,-115});
    states[97] = new State(new int[]{168,-58,167,-58,166,-58,134,-58,171,-58,151,-58,142,-58,149,-58,161,-116,64,-116});
    states[98] = new State(new int[]{168,-59,167,-59,166,-59,134,-59,171,-59,151,-59,142,-59,149,-59,161,-117,64,-117});
    states[99] = new State(new int[]{168,-60,167,-60,166,-60,134,-60,171,-60,151,-60,142,-60,149,-60,161,-118,64,-118});
    states[100] = new State(new int[]{168,-61,167,-61,166,-61,134,-61,171,-61,151,-61,142,-61,149,-61,161,-119,64,-119});
    states[101] = new State(-36);
    states[102] = new State(-34);
    states[103] = new State(-104);
    states[104] = new State(new int[]{161,105,64,114});
    states[105] = new State(new int[]{130,106});
    states[106] = new State(-109,new int[]{-26,107});
    states[107] = new State(new int[]{150,112},new int[]{-66,108});
    states[108] = new State(new int[]{123,110},new int[]{-67,109});
    states[109] = new State(-106);
    states[110] = new State(new int[]{125,111});
    states[111] = new State(-111);
    states[112] = new State(-13,new int[]{-35,113,-34,58,-31,63,-11,64,-10,67,-12,69,-13,70,-14,71,-33,72});
    states[113] = new State(-110);
    states[114] = new State(new int[]{161,115});
    states[115] = new State(new int[]{130,116});
    states[116] = new State(new int[]{123,118},new int[]{-68,117});
    states[117] = new State(-107);
    states[118] = new State(new int[]{125,119});
    states[119] = new State(-108);
    states[120] = new State(new int[]{168,122,167,123,166,124,134,125,171,126,161,-112,64,-112},new int[]{-65,121,-69,120});
    states[121] = new State(-113);
    states[122] = new State(-115);
    states[123] = new State(-116);
    states[124] = new State(-117);
    states[125] = new State(-118);
    states[126] = new State(-119);
    states[127] = new State(-105);
    states[128] = new State(new int[]{158,131,168,-23,167,-23,166,-23,134,-23,171,-23,151,-23,142,-23,149,-23,161,-23,64,-23,128,-23},new int[]{-4,129,-15,128,-16,130,-17,147,-18,148,-19,149});
    states[129] = new State(-24);
    states[130] = new State(-26);
    states[131] = new State(new int[]{171,139,130,146},new int[]{-70,132,-71,134});
    states[132] = new State(new int[]{59,133});
    states[133] = new State(-120);
    states[134] = new State(new int[]{46,135});
    states[135] = new State(new int[]{42,136,130,138});
    states[136] = new State(new int[]{59,137});
    states[137] = new State(-121);
    states[138] = new State(new int[]{59,-125,46,-127});
    states[139] = new State(new int[]{130,146},new int[]{-70,140,-71,142});
    states[140] = new State(new int[]{59,141});
    states[141] = new State(-122);
    states[142] = new State(new int[]{46,143});
    states[143] = new State(new int[]{42,144,130,138});
    states[144] = new State(new int[]{59,145});
    states[145] = new State(-123);
    states[146] = new State(new int[]{59,-124,46,-126});
    states[147] = new State(-27);
    states[148] = new State(-28);
    states[149] = new State(-29);
    states[150] = new State(new int[]{158,-3,168,-3,167,-3,166,-3,134,-3,171,-3,151,-3,142,-3,149,-3,161,-3,64,-3,128,-3,165,-9},new int[]{-3,151,-6,150,-7,152,-9,160,-10,162,-12,69,-13,70,-14,71});
    states[151] = new State(-4);
    states[152] = new State(new int[]{165,153});
    states[153] = new State(new int[]{130,154});
    states[154] = new State(new int[]{46,157,59,-19},new int[]{-8,155});
    states[155] = new State(new int[]{59,156});
    states[156] = new State(-6);
    states[157] = new State(new int[]{130,158});
    states[158] = new State(new int[]{46,157,59,-17},new int[]{-8,159});
    states[159] = new State(-18);
    states[160] = new State(-7,new int[]{-7,161,-9,160,-10,162,-12,69,-13,70,-14,71});
    states[161] = new State(-8);
    states[162] = new State(-10);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-2, new int[]{-1,128});
    rules[2] = new Rule(-1, new int[]{-3,-4,-5});
    rules[3] = new Rule(-3, new int[]{-6});
    rules[4] = new Rule(-3, new int[]{-6,-3});
    rules[5] = new Rule(-3, new int[]{});
    rules[6] = new Rule(-6, new int[]{-7,165,130,-8,59});
    rules[7] = new Rule(-7, new int[]{-9});
    rules[8] = new Rule(-7, new int[]{-9,-7});
    rules[9] = new Rule(-7, new int[]{});
    rules[10] = new Rule(-9, new int[]{-10});
    rules[11] = new Rule(-11, new int[]{-10});
    rules[12] = new Rule(-11, new int[]{-10,-11});
    rules[13] = new Rule(-11, new int[]{});
    rules[14] = new Rule(-10, new int[]{-12});
    rules[15] = new Rule(-10, new int[]{-13});
    rules[16] = new Rule(-10, new int[]{-14});
    rules[17] = new Rule(-8, new int[]{46,130});
    rules[18] = new Rule(-8, new int[]{46,130,-8});
    rules[19] = new Rule(-8, new int[]{});
    rules[20] = new Rule(-12, new int[]{});
    rules[21] = new Rule(-13, new int[]{});
    rules[22] = new Rule(-14, new int[]{});
    rules[23] = new Rule(-4, new int[]{-15});
    rules[24] = new Rule(-4, new int[]{-15,-4});
    rules[25] = new Rule(-4, new int[]{});
    rules[26] = new Rule(-15, new int[]{-16});
    rules[27] = new Rule(-15, new int[]{-17});
    rules[28] = new Rule(-15, new int[]{-18});
    rules[29] = new Rule(-15, new int[]{-19});
    rules[30] = new Rule(-5, new int[]{-20});
    rules[31] = new Rule(-5, new int[]{-20,-5});
    rules[32] = new Rule(-5, new int[]{});
    rules[33] = new Rule(-20, new int[]{-21});
    rules[34] = new Rule(-20, new int[]{-22});
    rules[35] = new Rule(-21, new int[]{-23});
    rules[36] = new Rule(-21, new int[]{-24});
    rules[37] = new Rule(-23, new int[]{-25,142,130,-26,-27,-28,123,-29,125});
    rules[38] = new Rule(-27, new int[]{-30});
    rules[39] = new Rule(-27, new int[]{-30,-27});
    rules[40] = new Rule(-27, new int[]{});
    rules[41] = new Rule(-30, new int[]{150,-31});
    rules[42] = new Rule(-31, new int[]{-11,130,-32});
    rules[43] = new Rule(-31, new int[]{-33,46,-11,130,-32});
    rules[44] = new Rule(-33, new int[]{-31});
    rules[45] = new Rule(-33, new int[]{-34});
    rules[46] = new Rule(-32, new int[]{});
    rules[47] = new Rule(-28, new int[]{157,-35});
    rules[48] = new Rule(-28, new int[]{});
    rules[49] = new Rule(-35, new int[]{-34,-36});
    rules[50] = new Rule(-36, new int[]{44,-34});
    rules[51] = new Rule(-36, new int[]{44,-34,-36});
    rules[52] = new Rule(-36, new int[]{});
    rules[53] = new Rule(-34, new int[]{-31});
    rules[54] = new Rule(-25, new int[]{-37});
    rules[55] = new Rule(-25, new int[]{-37,-25});
    rules[56] = new Rule(-25, new int[]{});
    rules[57] = new Rule(-37, new int[]{168});
    rules[58] = new Rule(-37, new int[]{167});
    rules[59] = new Rule(-37, new int[]{166});
    rules[60] = new Rule(-37, new int[]{134});
    rules[61] = new Rule(-37, new int[]{171});
    rules[62] = new Rule(-37, new int[]{151});
    rules[63] = new Rule(-29, new int[]{123,-38,125});
    rules[64] = new Rule(-29, new int[]{});
    rules[65] = new Rule(-38, new int[]{-39});
    rules[66] = new Rule(-38, new int[]{});
    rules[67] = new Rule(-39, new int[]{-40});
    rules[68] = new Rule(-39, new int[]{});
    rules[69] = new Rule(-40, new int[]{-41});
    rules[70] = new Rule(-40, new int[]{});
    rules[71] = new Rule(-41, new int[]{-42,-43,-44});
    rules[72] = new Rule(-41, new int[]{});
    rules[73] = new Rule(-42, new int[]{});
    rules[74] = new Rule(-43, new int[]{});
    rules[75] = new Rule(-44, new int[]{-45});
    rules[76] = new Rule(-44, new int[]{});
    rules[77] = new Rule(-45, new int[]{123,-46,125});
    rules[78] = new Rule(-45, new int[]{-47,-46});
    rules[79] = new Rule(-46, new int[]{});
    rules[80] = new Rule(-47, new int[]{-48});
    rules[81] = new Rule(-48, new int[]{-49,59});
    rules[82] = new Rule(-49, new int[]{-50,-51,-52});
    rules[83] = new Rule(-50, new int[]{});
    rules[84] = new Rule(-51, new int[]{-53});
    rules[85] = new Rule(-53, new int[]{-54});
    rules[86] = new Rule(-54, new int[]{-55});
    rules[87] = new Rule(-55, new int[]{138});
    rules[88] = new Rule(-55, new int[]{170});
    rules[89] = new Rule(-55, new int[]{160});
    rules[90] = new Rule(-55, new int[]{162});
    rules[91] = new Rule(-55, new int[]{141});
    rules[92] = new Rule(-52, new int[]{-56});
    rules[93] = new Rule(-52, new int[]{-56,-57});
    rules[94] = new Rule(-57, new int[]{});
    rules[95] = new Rule(-56, new int[]{-58});
    rules[96] = new Rule(-56, new int[]{-58,61,-59});
    rules[97] = new Rule(-58, new int[]{-60});
    rules[98] = new Rule(-58, new int[]{-60,-61});
    rules[99] = new Rule(-60, new int[]{130});
    rules[100] = new Rule(-61, new int[]{});
    rules[101] = new Rule(-59, new int[]{});
    rules[102] = new Rule(-24, new int[]{-25,149,130,-28,-62});
    rules[103] = new Rule(-62, new int[]{123,125});
    rules[104] = new Rule(-22, new int[]{-63});
    rules[105] = new Rule(-22, new int[]{-64});
    rules[106] = new Rule(-63, new int[]{-65,161,130,-26,-66,-67});
    rules[107] = new Rule(-64, new int[]{-65,64,161,130,-68});
    rules[108] = new Rule(-68, new int[]{123,125});
    rules[109] = new Rule(-26, new int[]{});
    rules[110] = new Rule(-66, new int[]{150,-35});
    rules[111] = new Rule(-67, new int[]{123,125});
    rules[112] = new Rule(-65, new int[]{-69});
    rules[113] = new Rule(-65, new int[]{-69,-65});
    rules[114] = new Rule(-65, new int[]{});
    rules[115] = new Rule(-69, new int[]{168});
    rules[116] = new Rule(-69, new int[]{167});
    rules[117] = new Rule(-69, new int[]{166});
    rules[118] = new Rule(-69, new int[]{134});
    rules[119] = new Rule(-69, new int[]{171});
    rules[120] = new Rule(-16, new int[]{158,-70,59});
    rules[121] = new Rule(-17, new int[]{158,-71,46,42,59});
    rules[122] = new Rule(-18, new int[]{158,171,-70,59});
    rules[123] = new Rule(-19, new int[]{158,171,-71,46,42,59});
    rules[124] = new Rule(-70, new int[]{130});
    rules[125] = new Rule(-70, new int[]{-71,46,130});
    rules[126] = new Rule(-71, new int[]{130});
    rules[127] = new Rule(-71, new int[]{-71,46,130});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

#line 296 "parser.y"

public Parser(Scanner scanner) : base(scanner)
{
}
#line default
}
}
