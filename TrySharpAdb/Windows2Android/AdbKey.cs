using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows2Android
{
    public class AdbKeyCode
    {
        /** Key code constant: Unknown key code. */
        public const int UNKNOWN = 0;
        /** Key code constant: Soft Left key.
         * Usually situated below the display on phones and used as a multi-function
         * feature key for selecting a software defined function shown on the bottom left
         * of the display. */
        public const int SOFT_LEFT = 1;
        /** Key code constant: Soft Right key.
         * Usually situated below the display on phones and used as a multi-function
         * feature key for selecting a software defined function shown on the bottom right
         * of the display. */
        public const int SOFT_RIGHT = 2;
        /** Key code constant: Home key.
         * This key is handled by the framework and is never delivered to applications. */
        public const int HOME = 3;
        /** Key code constant: Back key. */
        public const int BACK = 4;
        /** Key code constant: Call key. */
        public const int CALL = 5;
        /** Key code constant: End Call key. */
        public const int ENDCALL = 6;
        /** Key code constant: '0' key. */
        public const int _0 = 7;
        /** Key code constant: '1' key. */
        public const int _1 = 8;
        /** Key code constant: '2' key. */
        public const int _2 = 9;
        /** Key code constant: '3' key. */
        public const int _3 = 10;
        /** Key code constant: '4' key. */
        public const int _4 = 11;
        /** Key code constant: '5' key. */
        public const int _5 = 12;
        /** Key code constant: '6' key. */
        public const int _6 = 13;
        /** Key code constant: '7' key. */
        public const int _7 = 14;
        /** Key code constant: '8' key. */
        public const int _8 = 15;
        /** Key code constant: '9' key. */
        public const int _9 = 16;
        /** Key code constant: '*' key. */
        public const int STAR = 17;
        /** Key code constant: '#' key. */
        public const int POUND = 18;
        /** Key code constant: Directional Pad Up key.
         * May also be synthesized from trackball motions. */
        public const int DPAD_UP = 19;
        /** Key code constant: Directional Pad Down key.
         * May also be synthesized from trackball motions. */
        public const int DPAD_DOWN = 20;
        /** Key code constant: Directional Pad Left key.
         * May also be synthesized from trackball motions. */
        public const int DPAD_LEFT = 21;
        /** Key code constant: Directional Pad Right key.
         * May also be synthesized from trackball motions. */
        public const int DPAD_RIGHT = 22;
        /** Key code constant: Directional Pad Center key.
         * May also be synthesized from trackball motions. */
        public const int DPAD_CENTER = 23;
        /** Key code constant: Volume Up key.
         * Adjusts the speaker volume up. */
        public const int VOLUME_UP = 24;
        /** Key code constant: Volume Down key.
         * Adjusts the speaker volume down. */
        public const int VOLUME_DOWN = 25;
        /** Key code constant: Power key. */
        public const int POWER = 26;
        /** Key code constant: Camera key.
         * Used to launch a camera application or take pictures. */
        public const int CAMERA = 27;
        /** Key code constant: Clear key. */
        public const int CLEAR = 28;
        /** Key code constant: 'A' key. */
        public const int A = 29;
        /** Key code constant: 'B' key. */
        public const int B = 30;
        /** Key code constant: 'C' key. */
        public const int C = 31;
        /** Key code constant: 'D' key. */
        public const int D = 32;
        /** Key code constant: 'E' key. */
        public const int E = 33;
        /** Key code constant: 'F' key. */
        public const int F = 34;
        /** Key code constant: 'G' key. */
        public const int G = 35;
        /** Key code constant: 'H' key. */
        public const int H = 36;
        /** Key code constant: 'I' key. */
        public const int I = 37;
        /** Key code constant: 'J' key. */
        public const int J = 38;
        /** Key code constant: 'K' key. */
        public const int K = 39;
        /** Key code constant: 'L' key. */
        public const int L = 40;
        /** Key code constant: 'M' key. */
        public const int M = 41;
        /** Key code constant: 'N' key. */
        public const int N = 42;
        /** Key code constant: 'O' key. */
        public const int O = 43;
        /** Key code constant: 'P' key. */
        public const int P = 44;
        /** Key code constant: 'Q' key. */
        public const int Q = 45;
        /** Key code constant: 'R' key. */
        public const int R = 46;
        /** Key code constant: 'S' key. */
        public const int S = 47;
        /** Key code constant: 'T' key. */
        public const int T = 48;
        /** Key code constant: 'U' key. */
        public const int U = 49;
        /** Key code constant: 'V' key. */
        public const int V = 50;
        /** Key code constant: 'W' key. */
        public const int W = 51;
        /** Key code constant: 'X' key. */
        public const int X = 52;
        /** Key code constant: 'Y' key. */
        public const int Y = 53;
        /** Key code constant: 'Z' key. */
        public const int Z = 54;
        /** Key code constant: ',' key. */
        public const int COMMA = 55;
        /** Key code constant: '.' key. */
        public const int PERIOD = 56;
        /** Key code constant: Left Alt modifier key. */
        public const int ALT_LEFT = 57;
        /** Key code constant: Right Alt modifier key. */
        public const int ALT_RIGHT = 58;
        /** Key code constant: Left Shift modifier key. */
        public const int SHIFT_LEFT = 59;
        /** Key code constant: Right Shift modifier key. */
        public const int SHIFT_RIGHT = 60;
        /** Key code constant: Tab key. */
        public const int TAB = 61;
        /** Key code constant: Space key. */
        public const int SPACE = 62;
        /** Key code constant: Symbol modifier key.
         * Used to enter alternate symbols. */
        public const int SYM = 63;
        /** Key code constant: Explorer special function key.
         * Used to launch a browser application. */
        public const int EXPLORER = 64;
        /** Key code constant: Envelope special function key.
         * Used to launch a mail application. */
        public const int ENVELOPE = 65;
        /** Key code constant: Enter key. */
        public const int ENTER = 66;
        /** Key code constant: Backspace key.
         * Deletes characters before the insertion point, unlike {@link #FORWARD_DEL}. */
        public const int DEL = 67;
        /** Key code constant: '`' (backtick) key. */
        public const int GRAVE = 68;
        /** Key code constant: '-'. */
        public const int MINUS = 69;
        /** Key code constant: '=' key. */
        public const int EQUALS = 70;
        /** Key code constant: '[' key. */
        public const int LEFT_BRACKET = 71;
        /** Key code constant: ']' key. */
        public const int RIGHT_BRACKET = 72;
        /** Key code constant: '\' key. */
        public const int BACKSLASH = 73;
        /** Key code constant: ';' key. */
        public const int SEMICOLON = 74;
        /** Key code constant: ''' (apostrophe) key. */
        public const int APOSTROPHE = 75;
        /** Key code constant: '/' key. */
        public const int SLASH = 76;
        /** Key code constant: '@' key. */
        public const int AT = 77;
        /** Key code constant: Number modifier key.
         * Used to enter numeric symbols.
         * This key is not Num Lock; it is more like {@link #ALT_LEFT} and is
         * interpreted as an ALT key by {@link android.text.method.MetaKeyKeyListener}. */
        public const int NUM = 78;
        /** Key code constant: Headset Hook key.
         * Used to hang up calls and stop media. */
        public const int HEADSETHOOK = 79;
        /** Key code constant: Camera Focus key.
         * Used to focus the camera. */
        public const int FOCUS = 80;   // *Camera* focus
                                               /** Key code constant: '+' key. */
        public const int PLUS = 81;
        /** Key code constant: Menu key. */
        public const int MENU = 82;
        /** Key code constant: Notification key. */
        public const int NOTIFICATION = 83;
        /** Key code constant: Search key. */
        public const int SEARCH = 84;
        /** Key code constant: Play/Pause media key. */
        public const int MEDIA_PLAY_PAUSE = 85;
        /** Key code constant: Stop media key. */
        public const int MEDIA_STOP = 86;
        /** Key code constant: Play Next media key. */
        public const int MEDIA_NEXT = 87;
        /** Key code constant: Play Previous media key. */
        public const int MEDIA_PREVIOUS = 88;
        /** Key code constant: Rewind media key. */
        public const int MEDIA_REWIND = 89;
        /** Key code constant: Fast Forward media key. */
        public const int MEDIA_FAST_FORWARD = 90;
        /** Key code constant: Mute key.
         * Mutes the microphone, unlike {@link #VOLUME_MUTE}. */
        public const int MUTE = 91;
        /** Key code constant: Page Up key. */
        public const int PAGE_UP = 92;
        /** Key code constant: Page Down key. */
        public const int PAGE_DOWN = 93;
        /** Key code constant: Picture Symbols modifier key.
         * Used to switch symbol sets (Emoji, Kao-moji). */
        public const int PICTSYMBOLS = 94;   // switch symbol-sets (Emoji,Kao-moji)
                                                     /** Key code constant: Switch Charset modifier key.
                                                      * Used to switch character sets (Kanji, Katakana). */
        public const int SWITCH_CHARSET = 95;   // switch char-sets (Kanji,Katakana)
                                                        /** Key code constant: A Button key.
                                                         * On a game controller, the A button should be either the button labeled A
                                                         * or the first button on the upper row of controller buttons. */
        public const int BUTTON_A = 96;
        /** Key code constant: B Button key.
         * On a game controller, the B button should be either the button labeled B
         * or the second button on the upper row of controller buttons. */
        public const int BUTTON_B = 97;
        /** Key code constant: C Button key.
         * On a game controller, the C button should be either the button labeled C
         * or the third button on the upper row of controller buttons. */
        public const int BUTTON_C = 98;
        /** Key code constant: X Button key.
         * On a game controller, the X button should be either the button labeled X
         * or the first button on the lower row of controller buttons. */
        public const int BUTTON_X = 99;
        /** Key code constant: Y Button key.
         * On a game controller, the Y button should be either the button labeled Y
         * or the second button on the lower row of controller buttons. */
        public const int BUTTON_Y = 100;
        /** Key code constant: Z Button key.
         * On a game controller, the Z button should be either the button labeled Z
         * or the third button on the lower row of controller buttons. */
        public const int BUTTON_Z = 101;
        /** Key code constant: L1 Button key.
         * On a game controller, the L1 button should be either the button labeled L1 (or L)
         * or the top left trigger button. */
        public const int BUTTON_L1 = 102;
        /** Key code constant: R1 Button key.
         * On a game controller, the R1 button should be either the button labeled R1 (or R)
         * or the top right trigger button. */
        public const int BUTTON_R1 = 103;
        /** Key code constant: L2 Button key.
         * On a game controller, the L2 button should be either the button labeled L2
         * or the bottom left trigger button. */
        public const int BUTTON_L2 = 104;
        /** Key code constant: R2 Button key.
         * On a game controller, the R2 button should be either the button labeled R2
         * or the bottom right trigger button. */
        public const int BUTTON_R2 = 105;
        /** Key code constant: Left Thumb Button key.
         * On a game controller, the left thumb button indicates that the left (or only)
         * joystick is pressed. */
        public const int BUTTON_THUMBL = 106;
        /** Key code constant: Right Thumb Button key.
         * On a game controller, the right thumb button indicates that the right
         * joystick is pressed. */
        public const int BUTTON_THUMBR = 107;
        /** Key code constant: Start Button key.
         * On a game controller, the button labeled Start. */
        public const int BUTTON_START = 108;
        /** Key code constant: Select Button key.
         * On a game controller, the button labeled Select. */
        public const int BUTTON_SELECT = 109;
        /** Key code constant: Mode Button key.
         * On a game controller, the button labeled Mode. */
        public const int BUTTON_MODE = 110;
        /** Key code constant: Escape key. */
        public const int ESCAPE = 111;
        /** Key code constant: Forward Delete key.
         * Deletes characters ahead of the insertion point, unlike {@link #DEL}. */
        public const int FORWARD_DEL = 112;
        /** Key code constant: Left Control modifier key. */
        public const int CTRL_LEFT = 113;
        /** Key code constant: Right Control modifier key. */
        public const int CTRL_RIGHT = 114;
        /** Key code constant: Caps Lock key. */
        public const int CAPS_LOCK = 115;
        /** Key code constant: Scroll Lock key. */
        public const int SCROLL_LOCK = 116;
        /** Key code constant: Left Meta modifier key. */
        public const int META_LEFT = 117;
        /** Key code constant: Right Meta modifier key. */
        public const int META_RIGHT = 118;
        /** Key code constant: Function modifier key. */
        public const int FUNCTION = 119;
        /** Key code constant: System Request / Print Screen key. */
        public const int SYSRQ = 120;
        /** Key code constant: Break / Pause key. */
        public const int BREAK = 121;
        /** Key code constant: Home Movement key.
         * Used for scrolling or moving the cursor around to the start of a line
         * or to the top of a list. */
        public const int MOVE_HOME = 122;
        /** Key code constant: End Movement key.
         * Used for scrolling or moving the cursor around to the end of a line
         * or to the bottom of a list. */
        public const int MOVE_END = 123;
        /** Key code constant: Insert key.
         * Toggles insert / overwrite edit mode. */
        public const int INSERT = 124;
        /** Key code constant: Forward key.
         * Navigates forward in the history stack.  Complement of {@link #BACK}. */
        public const int FORWARD = 125;
        /** Key code constant: Play media key. */
        public const int MEDIA_PLAY = 126;
        /** Key code constant: Pause media key. */
        public const int MEDIA_PAUSE = 127;
        /** Key code constant: Close media key.
         * May be used to close a CD tray, for example. */
        public const int MEDIA_CLOSE = 128;
        /** Key code constant: Eject media key.
         * May be used to eject a CD tray, for example. */
        public const int MEDIA_EJECT = 129;
        /** Key code constant: Record media key. */
        public const int MEDIA_RECORD = 130;
        /** Key code constant: F1 key. */
        public const int F1 = 131;
        /** Key code constant: F2 key. */
        public const int F2 = 132;
        /** Key code constant: F3 key. */
        public const int F3 = 133;
        /** Key code constant: F4 key. */
        public const int F4 = 134;
        /** Key code constant: F5 key. */
        public const int F5 = 135;
        /** Key code constant: F6 key. */
        public const int F6 = 136;
        /** Key code constant: F7 key. */
        public const int F7 = 137;
        /** Key code constant: F8 key. */
        public const int F8 = 138;
        /** Key code constant: F9 key. */
        public const int F9 = 139;
        /** Key code constant: F10 key. */
        public const int F10 = 140;
        /** Key code constant: F11 key. */
        public const int F11 = 141;
        /** Key code constant: F12 key. */
        public const int F12 = 142;
        /** Key code constant: Num Lock key.
         * This is the Num Lock key; it is different from {@link #NUM}.
         * This key alters the behavior of other keys on the numeric keypad. */
        public const int NUM_LOCK = 143;
        /** Key code constant: Numeric keypad '0' key. */
        public const int NUMPAD_0 = 144;
        /** Key code constant: Numeric keypad '1' key. */
        public const int NUMPAD_1 = 145;
        /** Key code constant: Numeric keypad '2' key. */
        public const int NUMPAD_2 = 146;
        /** Key code constant: Numeric keypad '3' key. */
        public const int NUMPAD_3 = 147;
        /** Key code constant: Numeric keypad '4' key. */
        public const int NUMPAD_4 = 148;
        /** Key code constant: Numeric keypad '5' key. */
        public const int NUMPAD_5 = 149;
        /** Key code constant: Numeric keypad '6' key. */
        public const int NUMPAD_6 = 150;
        /** Key code constant: Numeric keypad '7' key. */
        public const int NUMPAD_7 = 151;
        /** Key code constant: Numeric keypad '8' key. */
        public const int NUMPAD_8 = 152;
        /** Key code constant: Numeric keypad '9' key. */
        public const int NUMPAD_9 = 153;
        /** Key code constant: Numeric keypad '/' key (for division). */
        public const int NUMPAD_DIVIDE = 154;
        /** Key code constant: Numeric keypad '*' key (for multiplication). */
        public const int NUMPAD_MULTIPLY = 155;
        /** Key code constant: Numeric keypad '-' key (for subtraction). */
        public const int NUMPAD_SUBTRACT = 156;
        /** Key code constant: Numeric keypad '+' key (for addition). */
        public const int NUMPAD_ADD = 157;
        /** Key code constant: Numeric keypad '.' key (for decimals or digit grouping). */
        public const int NUMPAD_DOT = 158;
        /** Key code constant: Numeric keypad ',' key (for decimals or digit grouping). */
        public const int NUMPAD_COMMA = 159;
        /** Key code constant: Numeric keypad Enter key. */
        public const int NUMPAD_ENTER = 160;
        /** Key code constant: Numeric keypad '=' key. */
        public const int NUMPAD_EQUALS = 161;
        /** Key code constant: Numeric keypad '(' key. */
        public const int NUMPAD_LEFT_PAREN = 162;
        /** Key code constant: Numeric keypad ')' key. */
        public const int NUMPAD_RIGHT_PAREN = 163;
        /** Key code constant: Volume Mute key.
         * Mutes the speaker, unlike {@link #MUTE}.
         * This key should normally be implemented as a toggle such that the first press
         * mutes the speaker and the second press restores the original volume. */
        public const int VOLUME_MUTE = 164;
        /** Key code constant: Info key.
         * Common on TV remotes to show additional information related to what is
         * currently being viewed. */
        public const int INFO = 165;
        /** Key code constant: Channel up key.
         * On TV remotes, increments the television channel. */
        public const int CHANNEL_UP = 166;
        /** Key code constant: Channel down key.
         * On TV remotes, decrements the television channel. */
        public const int CHANNEL_DOWN = 167;
        /** Key code constant: Zoom in key. */
        public const int ZOOM_IN = 168;
        /** Key code constant: Zoom out key. */
        public const int ZOOM_OUT = 169;
        /** Key code constant: TV key.
         * On TV remotes, switches to viewing live TV. */
        public const int TV = 170;
        /** Key code constant: Window key.
         * On TV remotes, toggles picture-in-picture mode or other windowing functions. */
        public const int WINDOW = 171;
        /** Key code constant: Guide key.
         * On TV remotes, shows a programming guide. */
        public const int GUIDE = 172;
        /** Key code constant: DVR key.
         * On some TV remotes, switches to a DVR mode for recorded shows. */
        public const int DVR = 173;
        /** Key code constant: Bookmark key.
         * On some TV remotes, bookmarks content or web pages. */
        public const int BOOKMARK = 174;
        /** Key code constant: Toggle captions key.
         * Switches the mode for closed-captioning text, for example during television shows. */
        public const int CAPTIONS = 175;
        /** Key code constant: Settings key.
         * Starts the system settings activity. */
        public const int SETTINGS = 176;
        /** Key code constant: TV power key.
         * On TV remotes, toggles the power on a television screen. */
        public const int TV_POWER = 177;
        /** Key code constant: TV input key.
         * On TV remotes, switches the input on a television screen. */
        public const int TV_INPUT = 178;
        /** Key code constant: Set-top-box power key.
         * On TV remotes, toggles the power on an external Set-top-box. */
        public const int STB_POWER = 179;
        /** Key code constant: Set-top-box input key.
         * On TV remotes, switches the input mode on an external Set-top-box. */
        public const int STB_INPUT = 180;
        /** Key code constant: A/V Receiver power key.
         * On TV remotes, toggles the power on an external A/V Receiver. */
        public const int AVR_POWER = 181;
        /** Key code constant: A/V Receiver input key.
         * On TV remotes, switches the input mode on an external A/V Receiver. */
        public const int AVR_INPUT = 182;
        /** Key code constant: Red "programmable" key.
         * On TV remotes, acts as a contextual/programmable key. */
        public const int PROG_RED = 183;
        /** Key code constant: Green "programmable" key.
         * On TV remotes, actsas a contextual/programmable key. */
        public const int PROG_GREEN = 184;
        /** Key code constant: Yellow "programmable" key.
         * On TV remotes, acts as a contextual/programmable key. */
        public const int PROG_YELLOW = 185;
        /** Key code constant: Blue "programmable" key.
         * On TV remotes, acts as a contextual/programmable key. */
        public const int PROG_BLUE = 186;
        /** Key code constant: App switch key.
         * Should bring up the application switcher dialog. */
        public const int APP_SWITCH = 187;
        /** Key code constant: Generic Game Pad Button #1.*/
        public const int BUTTON_1 = 188;
        /** Key code constant: Generic Game Pad Button #2.*/
        public const int BUTTON_2 = 189;
        /** Key code constant: Generic Game Pad Button #3.*/
        public const int BUTTON_3 = 190;
        /** Key code constant: Generic Game Pad Button #4.*/
        public const int BUTTON_4 = 191;
        /** Key code constant: Generic Game Pad Button #5.*/
        public const int BUTTON_5 = 192;
        /** Key code constant: Generic Game Pad Button #6.*/
        public const int BUTTON_6 = 193;
        /** Key code constant: Generic Game Pad Button #7.*/
        public const int BUTTON_7 = 194;
        /** Key code constant: Generic Game Pad Button #8.*/
        public const int BUTTON_8 = 195;
        /** Key code constant: Generic Game Pad Button #9.*/
        public const int BUTTON_9 = 196;
        /** Key code constant: Generic Game Pad Button #10.*/
        public const int BUTTON_10 = 197;
        /** Key code constant: Generic Game Pad Button #11.*/
        public const int BUTTON_11 = 198;
        /** Key code constant: Generic Game Pad Button #12.*/
        public const int BUTTON_12 = 199;
        /** Key code constant: Generic Game Pad Button #13.*/
        public const int BUTTON_13 = 200;
        /** Key code constant: Generic Game Pad Button #14.*/
        public const int BUTTON_14 = 201;
        /** Key code constant: Generic Game Pad Button #15.*/
        public const int BUTTON_15 = 202;
        /** Key code constant: Generic Game Pad Button #16.*/
        public const int BUTTON_16 = 203;
        /** Key code constant: Language Switch key.
         * Toggles the current input language such as switching between English and Japanese on
         * a QWERTY keyboard.  On some devices, the same function may be performed by
         * pressing Shift+Spacebar. */
        public const int LANGUAGE_SWITCH = 204;
        /** Key code constant: Manner Mode key.
         * Toggles silent or vibrate mode on and off to make the device behave more politely
         * in certain settings such as on a crowded train.  On some devices, the key may only
         * operate when long-pressed. */
        public const int MANNER_MODE = 205;
        /** Key code constant: 3D Mode key.
         * Toggles the display between 2D and 3D mode. */
        public const int _3D_MODE = 206;
        /** Key code constant: Contacts special function key.
         * Used to launch an address book application. */
        public const int CONTACTS = 207;
        /** Key code constant: Calendar special function key.
         * Used to launch a calendar application. */
        public const int CALENDAR = 208;
        /** Key code constant: Music special function key.
         * Used to launch a music player application. */
        public const int MUSIC = 209;
        /** Key code constant: Calculator special function key.
         * Used to launch a calculator application. */
        public const int CALCULATOR = 210;
        /** Key code constant: Japanese full-width / half-width key. */
        public const int ZENKAKU_HANKAKU = 211;
        /** Key code constant: Japanese alphanumeric key. */
        public const int EISU = 212;
        /** Key code constant: Japanese non-conversion key. */
        public const int MUHENKAN = 213;
        /** Key code constant: Japanese conversion key. */
        public const int HENKAN = 214;
        /** Key code constant: Japanese katakana / hiragana key. */
        public const int KATAKANA_HIRAGANA = 215;
        /** Key code constant: Japanese Yen key. */
        public const int YEN = 216;
        /** Key code constant: Japanese Ro key. */
        public const int RO = 217;
        /** Key code constant: Japanese kana key. */
        public const int KANA = 218;
        /** Key code constant: Assist key.
         * Launches the global assist activity.  Not delivered to applications. */
        public const int ASSIST = 219;

        private const int LAST_KEYCODE = ASSIST;
    }
}
