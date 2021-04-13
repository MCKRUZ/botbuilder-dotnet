//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from LGFileLexer.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

#pragma warning disable 3021
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class LGFileLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		NEWLINE=1, OPTION=2, COMMENT=3, IMPORT=4, TEMPLATE_NAME_LINE=5, INLINE_MULTILINE=6, 
		MULTILINE_PREFIX=7, TEMPLATE_BODY=8, INVALID_LINE=9, MULTILINE_SUFFIX=10, 
		ESCAPE_CHARACTER=11, MULTILINE_TEXT=12;
	public const int
		MULTILINE_MODE=1;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE", "MULTILINE_MODE"
	};

	public static readonly string[] ruleNames = {
		"WHITESPACE", "NEWLINE", "OPTION", "COMMENT", "IMPORT", "TEMPLATE_NAME_LINE", 
		"INLINE_MULTILINE", "MULTILINE_PREFIX", "TEMPLATE_BODY", "INVALID_LINE", 
		"MULTILINE_SUFFIX", "ESCAPE_CHARACTER", "MULTILINE_TEXT"
	};


	  bool startTemplate = false;


	public LGFileLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public LGFileLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, null, null, null, "'```'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "NEWLINE", "OPTION", "COMMENT", "IMPORT", "TEMPLATE_NAME_LINE", 
		"INLINE_MULTILINE", "MULTILINE_PREFIX", "TEMPLATE_BODY", "INVALID_LINE", 
		"MULTILINE_SUFFIX", "ESCAPE_CHARACTER", "MULTILINE_TEXT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "LGFileLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static LGFileLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	public override void Action(RuleContext _localctx, int ruleIndex, int actionIndex) {
		switch (ruleIndex) {
		case 5 : TEMPLATE_NAME_LINE_action(_localctx, actionIndex); break;
		}
	}
	private void TEMPLATE_NAME_LINE_action(RuleContext _localctx, int actionIndex) {
		switch (actionIndex) {
		case 0:  startTemplate = true;  break;
		}
	}
	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 2 : return OPTION_sempred(_localctx, predIndex);
		case 3 : return COMMENT_sempred(_localctx, predIndex);
		case 4 : return IMPORT_sempred(_localctx, predIndex);
		case 5 : return TEMPLATE_NAME_LINE_sempred(_localctx, predIndex);
		case 6 : return INLINE_MULTILINE_sempred(_localctx, predIndex);
		case 7 : return MULTILINE_PREFIX_sempred(_localctx, predIndex);
		case 8 : return TEMPLATE_BODY_sempred(_localctx, predIndex);
		case 9 : return INVALID_LINE_sempred(_localctx, predIndex);
		}
		return true;
	}
	private bool OPTION_sempred(RuleContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return  !startTemplate ;
		}
		return true;
	}
	private bool COMMENT_sempred(RuleContext _localctx, int predIndex) {
		switch (predIndex) {
		case 1: return  !startTemplate ;
		}
		return true;
	}
	private bool IMPORT_sempred(RuleContext _localctx, int predIndex) {
		switch (predIndex) {
		case 2: return  !startTemplate ;
		}
		return true;
	}
	private bool TEMPLATE_NAME_LINE_sempred(RuleContext _localctx, int predIndex) {
		switch (predIndex) {
		case 3: return  TokenStartColumn == 0;
		}
		return true;
	}
	private bool INLINE_MULTILINE_sempred(RuleContext _localctx, int predIndex) {
		switch (predIndex) {
		case 4: return  startTemplate && TokenStartColumn == 0 ;
		}
		return true;
	}
	private bool MULTILINE_PREFIX_sempred(RuleContext _localctx, int predIndex) {
		switch (predIndex) {
		case 5: return  startTemplate && TokenStartColumn == 0 ;
		}
		return true;
	}
	private bool TEMPLATE_BODY_sempred(RuleContext _localctx, int predIndex) {
		switch (predIndex) {
		case 6: return  startTemplate ;
		}
		return true;
	}
	private bool INVALID_LINE_sempred(RuleContext _localctx, int predIndex) {
		switch (predIndex) {
		case 7: return  !startTemplate ;
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\xE', '\xD4', '\b', '\x1', '\b', '\x1', '\x4', '\x2', 
		'\t', '\x2', '\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', 
		'\x5', '\t', '\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', 
		'\x4', '\b', '\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', 
		'\x4', '\v', '\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', 
		'\x4', '\xE', '\t', '\xE', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x5', 
		'\x3', '\"', '\n', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\a', 
		'\x4', '\'', '\n', '\x4', '\f', '\x4', '\xE', '\x4', '*', '\v', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\a', '\x4', '.', '\n', '\x4', '\f', '\x4', 
		'\xE', '\x4', '\x31', '\v', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x6', '\x4', '\x37', '\n', '\x4', '\r', '\x4', '\xE', 
		'\x4', '\x38', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\a', '\x5', 
		'>', '\n', '\x5', '\f', '\x5', '\xE', '\x5', '\x41', '\v', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\a', '\x5', '\x45', '\n', '\x5', '\f', '\x5', '\xE', 
		'\x5', 'H', '\v', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\a', 
		'\x6', 'M', '\n', '\x6', '\f', '\x6', '\xE', '\x6', 'P', '\v', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\a', '\x6', 'T', '\n', '\x6', '\f', '\x6', 
		'\xE', '\x6', 'W', '\v', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\a', '\x6', '\\', '\n', '\x6', '\f', '\x6', '\xE', '\x6', '_', '\v', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\a', '\x6', '\x63', '\n', '\x6', '\f', 
		'\x6', '\xE', '\x6', '\x66', '\v', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\a', '\a', '\a', 'k', '\n', '\a', '\f', '\a', '\xE', '\a', 'n', 
		'\v', '\a', '\x3', '\a', '\x3', '\a', '\a', '\a', 'r', '\n', '\a', '\f', 
		'\a', '\xE', '\a', 'u', '\v', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\b', '\a', '\b', '{', '\n', '\b', '\f', '\b', '\xE', '\b', '~', 
		'\v', '\b', '\x3', '\b', '\x3', '\b', '\a', '\b', '\x82', '\n', '\b', 
		'\f', '\b', '\xE', '\b', '\x85', '\v', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\a', '\b', '\x8C', '\n', '\b', 
		'\f', '\b', '\xE', '\b', '\x8F', '\v', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\a', '\b', '\x96', '\n', '\b', 
		'\f', '\b', '\xE', '\b', '\x99', '\v', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\t', '\a', '\t', '\x9E', '\n', '\t', '\f', '\t', '\xE', '\t', 
		'\xA1', '\v', '\t', '\x3', '\t', '\x3', '\t', '\a', '\t', '\xA5', '\n', 
		'\t', '\f', '\t', '\xE', '\t', '\xA8', '\v', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\a', '\t', '\xAF', '\n', 
		'\t', '\f', '\t', '\xE', '\t', '\xB2', '\v', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x6', '\n', '\xB9', '\n', 
		'\n', '\r', '\n', '\xE', '\n', '\xBA', '\x3', '\n', '\x3', '\n', '\x3', 
		'\v', '\x6', '\v', '\xC0', '\n', '\v', '\r', '\v', '\xE', '\v', '\xC1', 
		'\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x5', '\r', 
		'\xCE', '\n', '\r', '\x3', '\xE', '\x6', '\xE', '\xD1', '\n', '\xE', '\r', 
		'\xE', '\xE', '\xE', '\xD2', '\x5', 'U', ']', '\xD2', '\x2', '\xF', '\x4', 
		'\x2', '\x6', '\x3', '\b', '\x4', '\n', '\x5', '\f', '\x6', '\xE', '\a', 
		'\x10', '\b', '\x12', '\t', '\x14', '\n', '\x16', '\v', '\x18', '\f', 
		'\x1A', '\r', '\x1C', '\xE', '\x4', '\x2', '\x3', '\x6', '\x6', '\x2', 
		'\v', '\v', '\"', '\"', '\xA2', '\xA2', '\xFF01', '\xFF01', '\x4', '\x2', 
		'\f', '\f', '\xF', '\xF', '\x6', '\x2', '\f', '\f', '\xF', '\xF', ']', 
		']', '_', '_', '\x5', '\x2', '\f', '\f', '\xF', '\xF', '*', '+', '\x2', 
		'\xE8', '\x2', '\x6', '\x3', '\x2', '\x2', '\x2', '\x2', '\b', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\n', '\x3', '\x2', '\x2', '\x2', '\x2', '\f', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\xE', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x10', '\x3', '\x2', '\x2', '\x2', '\x2', '\x12', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x14', '\x3', '\x2', '\x2', '\x2', '\x2', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\x3', '\x18', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x3', '\x1C', '\x3', '\x2', 
		'\x2', '\x2', '\x4', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x6', '!', '\x3', 
		'\x2', '\x2', '\x2', '\b', '(', '\x3', '\x2', '\x2', '\x2', '\n', '?', 
		'\x3', '\x2', '\x2', '\x2', '\f', 'N', '\x3', '\x2', '\x2', '\x2', '\xE', 
		'l', '\x3', '\x2', '\x2', '\x2', '\x10', '|', '\x3', '\x2', '\x2', '\x2', 
		'\x12', '\x9F', '\x3', '\x2', '\x2', '\x2', '\x14', '\xB8', '\x3', '\x2', 
		'\x2', '\x2', '\x16', '\xBF', '\x3', '\x2', '\x2', '\x2', '\x18', '\xC5', 
		'\x3', '\x2', '\x2', '\x2', '\x1A', '\xCB', '\x3', '\x2', '\x2', '\x2', 
		'\x1C', '\xD0', '\x3', '\x2', '\x2', '\x2', '\x1E', '\x1F', '\t', '\x2', 
		'\x2', '\x2', '\x1F', '\x5', '\x3', '\x2', '\x2', '\x2', ' ', '\"', '\a', 
		'\xF', '\x2', '\x2', '!', ' ', '\x3', '\x2', '\x2', '\x2', '!', '\"', 
		'\x3', '\x2', '\x2', '\x2', '\"', '#', '\x3', '\x2', '\x2', '\x2', '#', 
		'$', '\a', '\f', '\x2', '\x2', '$', '\a', '\x3', '\x2', '\x2', '\x2', 
		'%', '\'', '\x5', '\x4', '\x2', '\x2', '&', '%', '\x3', '\x2', '\x2', 
		'\x2', '\'', '*', '\x3', '\x2', '\x2', '\x2', '(', '&', '\x3', '\x2', 
		'\x2', '\x2', '(', ')', '\x3', '\x2', '\x2', '\x2', ')', '+', '\x3', '\x2', 
		'\x2', '\x2', '*', '(', '\x3', '\x2', '\x2', '\x2', '+', '/', '\a', '@', 
		'\x2', '\x2', ',', '.', '\x5', '\x4', '\x2', '\x2', '-', ',', '\x3', '\x2', 
		'\x2', '\x2', '.', '\x31', '\x3', '\x2', '\x2', '\x2', '/', '-', '\x3', 
		'\x2', '\x2', '\x2', '/', '\x30', '\x3', '\x2', '\x2', '\x2', '\x30', 
		'\x32', '\x3', '\x2', '\x2', '\x2', '\x31', '/', '\x3', '\x2', '\x2', 
		'\x2', '\x32', '\x33', '\a', '#', '\x2', '\x2', '\x33', '\x34', '\a', 
		'%', '\x2', '\x2', '\x34', '\x36', '\x3', '\x2', '\x2', '\x2', '\x35', 
		'\x37', '\n', '\x3', '\x2', '\x2', '\x36', '\x35', '\x3', '\x2', '\x2', 
		'\x2', '\x37', '\x38', '\x3', '\x2', '\x2', '\x2', '\x38', '\x36', '\x3', 
		'\x2', '\x2', '\x2', '\x38', '\x39', '\x3', '\x2', '\x2', '\x2', '\x39', 
		':', '\x3', '\x2', '\x2', '\x2', ':', ';', '\x6', '\x4', '\x2', '\x2', 
		';', '\t', '\x3', '\x2', '\x2', '\x2', '<', '>', '\x5', '\x4', '\x2', 
		'\x2', '=', '<', '\x3', '\x2', '\x2', '\x2', '>', '\x41', '\x3', '\x2', 
		'\x2', '\x2', '?', '=', '\x3', '\x2', '\x2', '\x2', '?', '@', '\x3', '\x2', 
		'\x2', '\x2', '@', '\x42', '\x3', '\x2', '\x2', '\x2', '\x41', '?', '\x3', 
		'\x2', '\x2', '\x2', '\x42', '\x46', '\a', '@', '\x2', '\x2', '\x43', 
		'\x45', '\n', '\x3', '\x2', '\x2', '\x44', '\x43', '\x3', '\x2', '\x2', 
		'\x2', '\x45', 'H', '\x3', '\x2', '\x2', '\x2', '\x46', '\x44', '\x3', 
		'\x2', '\x2', '\x2', '\x46', 'G', '\x3', '\x2', '\x2', '\x2', 'G', 'I', 
		'\x3', '\x2', '\x2', '\x2', 'H', '\x46', '\x3', '\x2', '\x2', '\x2', 'I', 
		'J', '\x6', '\x5', '\x3', '\x2', 'J', '\v', '\x3', '\x2', '\x2', '\x2', 
		'K', 'M', '\x5', '\x4', '\x2', '\x2', 'L', 'K', '\x3', '\x2', '\x2', '\x2', 
		'M', 'P', '\x3', '\x2', '\x2', '\x2', 'N', 'L', '\x3', '\x2', '\x2', '\x2', 
		'N', 'O', '\x3', '\x2', '\x2', '\x2', 'O', 'Q', '\x3', '\x2', '\x2', '\x2', 
		'P', 'N', '\x3', '\x2', '\x2', '\x2', 'Q', 'U', '\a', ']', '\x2', '\x2', 
		'R', 'T', '\n', '\x4', '\x2', '\x2', 'S', 'R', '\x3', '\x2', '\x2', '\x2', 
		'T', 'W', '\x3', '\x2', '\x2', '\x2', 'U', 'V', '\x3', '\x2', '\x2', '\x2', 
		'U', 'S', '\x3', '\x2', '\x2', '\x2', 'V', 'X', '\x3', '\x2', '\x2', '\x2', 
		'W', 'U', '\x3', '\x2', '\x2', '\x2', 'X', 'Y', '\a', '_', '\x2', '\x2', 
		'Y', ']', '\a', '*', '\x2', '\x2', 'Z', '\\', '\n', '\x5', '\x2', '\x2', 
		'[', 'Z', '\x3', '\x2', '\x2', '\x2', '\\', '_', '\x3', '\x2', '\x2', 
		'\x2', ']', '^', '\x3', '\x2', '\x2', '\x2', ']', '[', '\x3', '\x2', '\x2', 
		'\x2', '^', '`', '\x3', '\x2', '\x2', '\x2', '_', ']', '\x3', '\x2', '\x2', 
		'\x2', '`', '\x64', '\a', '+', '\x2', '\x2', '\x61', '\x63', '\n', '\x3', 
		'\x2', '\x2', '\x62', '\x61', '\x3', '\x2', '\x2', '\x2', '\x63', '\x66', 
		'\x3', '\x2', '\x2', '\x2', '\x64', '\x62', '\x3', '\x2', '\x2', '\x2', 
		'\x64', '\x65', '\x3', '\x2', '\x2', '\x2', '\x65', 'g', '\x3', '\x2', 
		'\x2', '\x2', '\x66', '\x64', '\x3', '\x2', '\x2', '\x2', 'g', 'h', '\x6', 
		'\x6', '\x4', '\x2', 'h', '\r', '\x3', '\x2', '\x2', '\x2', 'i', 'k', 
		'\x5', '\x4', '\x2', '\x2', 'j', 'i', '\x3', '\x2', '\x2', '\x2', 'k', 
		'n', '\x3', '\x2', '\x2', '\x2', 'l', 'j', '\x3', '\x2', '\x2', '\x2', 
		'l', 'm', '\x3', '\x2', '\x2', '\x2', 'm', 'o', '\x3', '\x2', '\x2', '\x2', 
		'n', 'l', '\x3', '\x2', '\x2', '\x2', 'o', 's', '\a', '%', '\x2', '\x2', 
		'p', 'r', '\n', '\x3', '\x2', '\x2', 'q', 'p', '\x3', '\x2', '\x2', '\x2', 
		'r', 'u', '\x3', '\x2', '\x2', '\x2', 's', 'q', '\x3', '\x2', '\x2', '\x2', 
		's', 't', '\x3', '\x2', '\x2', '\x2', 't', 'v', '\x3', '\x2', '\x2', '\x2', 
		'u', 's', '\x3', '\x2', '\x2', '\x2', 'v', 'w', '\x6', '\a', '\x5', '\x2', 
		'w', 'x', '\b', '\a', '\x2', '\x2', 'x', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'y', '{', '\x5', '\x4', '\x2', '\x2', 'z', 'y', '\x3', '\x2', '\x2', '\x2', 
		'{', '~', '\x3', '\x2', '\x2', '\x2', '|', 'z', '\x3', '\x2', '\x2', '\x2', 
		'|', '}', '\x3', '\x2', '\x2', '\x2', '}', '\x7F', '\x3', '\x2', '\x2', 
		'\x2', '~', '|', '\x3', '\x2', '\x2', '\x2', '\x7F', '\x83', '\a', '/', 
		'\x2', '\x2', '\x80', '\x82', '\x5', '\x4', '\x2', '\x2', '\x81', '\x80', 
		'\x3', '\x2', '\x2', '\x2', '\x82', '\x85', '\x3', '\x2', '\x2', '\x2', 
		'\x83', '\x81', '\x3', '\x2', '\x2', '\x2', '\x83', '\x84', '\x3', '\x2', 
		'\x2', '\x2', '\x84', '\x86', '\x3', '\x2', '\x2', '\x2', '\x85', '\x83', 
		'\x3', '\x2', '\x2', '\x2', '\x86', '\x87', '\a', '\x62', '\x2', '\x2', 
		'\x87', '\x88', '\a', '\x62', '\x2', '\x2', '\x88', '\x89', '\a', '\x62', 
		'\x2', '\x2', '\x89', '\x8D', '\x3', '\x2', '\x2', '\x2', '\x8A', '\x8C', 
		'\n', '\x3', '\x2', '\x2', '\x8B', '\x8A', '\x3', '\x2', '\x2', '\x2', 
		'\x8C', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x8D', '\x8B', '\x3', '\x2', 
		'\x2', '\x2', '\x8D', '\x8E', '\x3', '\x2', '\x2', '\x2', '\x8E', '\x90', 
		'\x3', '\x2', '\x2', '\x2', '\x8F', '\x8D', '\x3', '\x2', '\x2', '\x2', 
		'\x90', '\x91', '\a', '\x62', '\x2', '\x2', '\x91', '\x92', '\a', '\x62', 
		'\x2', '\x2', '\x92', '\x93', '\a', '\x62', '\x2', '\x2', '\x93', '\x97', 
		'\x3', '\x2', '\x2', '\x2', '\x94', '\x96', '\x5', '\x4', '\x2', '\x2', 
		'\x95', '\x94', '\x3', '\x2', '\x2', '\x2', '\x96', '\x99', '\x3', '\x2', 
		'\x2', '\x2', '\x97', '\x95', '\x3', '\x2', '\x2', '\x2', '\x97', '\x98', 
		'\x3', '\x2', '\x2', '\x2', '\x98', '\x9A', '\x3', '\x2', '\x2', '\x2', 
		'\x99', '\x97', '\x3', '\x2', '\x2', '\x2', '\x9A', '\x9B', '\x6', '\b', 
		'\x6', '\x2', '\x9B', '\x11', '\x3', '\x2', '\x2', '\x2', '\x9C', '\x9E', 
		'\x5', '\x4', '\x2', '\x2', '\x9D', '\x9C', '\x3', '\x2', '\x2', '\x2', 
		'\x9E', '\xA1', '\x3', '\x2', '\x2', '\x2', '\x9F', '\x9D', '\x3', '\x2', 
		'\x2', '\x2', '\x9F', '\xA0', '\x3', '\x2', '\x2', '\x2', '\xA0', '\xA2', 
		'\x3', '\x2', '\x2', '\x2', '\xA1', '\x9F', '\x3', '\x2', '\x2', '\x2', 
		'\xA2', '\xA6', '\a', '/', '\x2', '\x2', '\xA3', '\xA5', '\x5', '\x4', 
		'\x2', '\x2', '\xA4', '\xA3', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA8', 
		'\x3', '\x2', '\x2', '\x2', '\xA6', '\xA4', '\x3', '\x2', '\x2', '\x2', 
		'\xA6', '\xA7', '\x3', '\x2', '\x2', '\x2', '\xA7', '\xA9', '\x3', '\x2', 
		'\x2', '\x2', '\xA8', '\xA6', '\x3', '\x2', '\x2', '\x2', '\xA9', '\xAA', 
		'\a', '\x62', '\x2', '\x2', '\xAA', '\xAB', '\a', '\x62', '\x2', '\x2', 
		'\xAB', '\xAC', '\a', '\x62', '\x2', '\x2', '\xAC', '\xB0', '\x3', '\x2', 
		'\x2', '\x2', '\xAD', '\xAF', '\n', '\x3', '\x2', '\x2', '\xAE', '\xAD', 
		'\x3', '\x2', '\x2', '\x2', '\xAF', '\xB2', '\x3', '\x2', '\x2', '\x2', 
		'\xB0', '\xAE', '\x3', '\x2', '\x2', '\x2', '\xB0', '\xB1', '\x3', '\x2', 
		'\x2', '\x2', '\xB1', '\xB3', '\x3', '\x2', '\x2', '\x2', '\xB2', '\xB0', 
		'\x3', '\x2', '\x2', '\x2', '\xB3', '\xB4', '\x6', '\t', '\a', '\x2', 
		'\xB4', '\xB5', '\x3', '\x2', '\x2', '\x2', '\xB5', '\xB6', '\b', '\t', 
		'\x3', '\x2', '\xB6', '\x13', '\x3', '\x2', '\x2', '\x2', '\xB7', '\xB9', 
		'\n', '\x3', '\x2', '\x2', '\xB8', '\xB7', '\x3', '\x2', '\x2', '\x2', 
		'\xB9', '\xBA', '\x3', '\x2', '\x2', '\x2', '\xBA', '\xB8', '\x3', '\x2', 
		'\x2', '\x2', '\xBA', '\xBB', '\x3', '\x2', '\x2', '\x2', '\xBB', '\xBC', 
		'\x3', '\x2', '\x2', '\x2', '\xBC', '\xBD', '\x6', '\n', '\b', '\x2', 
		'\xBD', '\x15', '\x3', '\x2', '\x2', '\x2', '\xBE', '\xC0', '\n', '\x3', 
		'\x2', '\x2', '\xBF', '\xBE', '\x3', '\x2', '\x2', '\x2', '\xC0', '\xC1', 
		'\x3', '\x2', '\x2', '\x2', '\xC1', '\xBF', '\x3', '\x2', '\x2', '\x2', 
		'\xC1', '\xC2', '\x3', '\x2', '\x2', '\x2', '\xC2', '\xC3', '\x3', '\x2', 
		'\x2', '\x2', '\xC3', '\xC4', '\x6', '\v', '\t', '\x2', '\xC4', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\xC5', '\xC6', '\a', '\x62', '\x2', '\x2', 
		'\xC6', '\xC7', '\a', '\x62', '\x2', '\x2', '\xC7', '\xC8', '\a', '\x62', 
		'\x2', '\x2', '\xC8', '\xC9', '\x3', '\x2', '\x2', '\x2', '\xC9', '\xCA', 
		'\b', '\f', '\x4', '\x2', '\xCA', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\xCB', '\xCD', '\a', '^', '\x2', '\x2', '\xCC', '\xCE', '\n', '\x3', 
		'\x2', '\x2', '\xCD', '\xCC', '\x3', '\x2', '\x2', '\x2', '\xCD', '\xCE', 
		'\x3', '\x2', '\x2', '\x2', '\xCE', '\x1B', '\x3', '\x2', '\x2', '\x2', 
		'\xCF', '\xD1', '\v', '\x2', '\x2', '\x2', '\xD0', '\xCF', '\x3', '\x2', 
		'\x2', '\x2', '\xD1', '\xD2', '\x3', '\x2', '\x2', '\x2', '\xD2', '\xD3', 
		'\x3', '\x2', '\x2', '\x2', '\xD2', '\xD0', '\x3', '\x2', '\x2', '\x2', 
		'\xD3', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x2', '\x3', '!', 
		'(', '/', '\x38', '?', '\x46', 'N', 'U', ']', '\x64', 'l', 's', '|', '\x83', 
		'\x8D', '\x97', '\x9F', '\xA6', '\xB0', '\xBA', '\xC1', '\xCD', '\xD2', 
		'\x5', '\x3', '\a', '\x2', '\a', '\x3', '\x2', '\x6', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
