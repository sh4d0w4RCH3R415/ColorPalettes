using System.Drawing;

public struct ColorPalette
{
	public struct FlatPalette : IPalette
	{
		public Color Color1Lt => Color.FromArgb(26, 188, 156);
		public Color Color1Dk => Color.FromArgb(22, 160, 133);

		public Color Color2Lt => Color.FromArgb(46, 204, 113);
		public Color Color2Dk => Color.FromArgb(39, 174, 96);

		public Color Color3Lt => Color.FromArgb(52, 152, 219);
		public Color Color3Dk => Color.FromArgb(41, 128, 185);

		public Color Color4Lt => Color.FromArgb(155, 89, 182);
		public Color Color4Dk => Color.FromArgb(142, 68, 173);

		public Color Color5Lt => Color.FromArgb(52, 73, 94);
		public Color Color5Dk => Color.FromArgb(44, 62, 80);

		public Color Color6Lt => Color.FromArgb(241, 196, 15);
		public Color Color6Dk => Color.FromArgb(243, 156, 18);

		public Color Color7Lt => Color.FromArgb(230, 126, 34);
		public Color Color7Dk => Color.FromArgb(211, 84, 0);

		public Color Color8Lt => Color.FromArgb(231, 76, 60);
		public Color Color8Dk => Color.FromArgb(192, 57, 43);

		public Color Color9Lt => Color.FromArgb(236, 240, 241);
		public Color Color9Dk => Color.FromArgb(189, 195, 199);

		public Color Color10Lt => Color.FromArgb(149, 165, 166);
		public Color Color10Dk => Color.FromArgb(127, 140, 141);
	}
	public struct AmericanPalette : IPalette
	{
		public Color Color1Lt => Color.FromArgb(85, 239, 196);
		public Color Color1Dk => Color.FromArgb(0, 184, 148);

		public Color Color2Lt => Color.FromArgb(129, 236, 236);
		public Color Color2Dk => Color.FromArgb(0, 206, 201);

		public Color Color3Lt => Color.FromArgb(116, 185, 255);
		public Color Color3Dk => Color.FromArgb(9, 132, 227);

		public Color Color4Lt => Color.FromArgb(162, 155, 254);
		public Color Color4Dk => Color.FromArgb(108, 92, 231);

		public Color Color5Lt => Color.FromArgb(223, 230, 233);
		public Color Color5Dk => Color.FromArgb(178, 190, 195);

		public Color Color6Lt => Color.FromArgb(255, 234, 167);
		public Color Color6Dk => Color.FromArgb(253, 203, 110);

		public Color Color7Lt => Color.FromArgb(250, 177, 160);
		public Color Color7Dk => Color.FromArgb(225, 112, 85);

		public Color Color8Lt => Color.FromArgb(255, 118, 117);
		public Color Color8Dk => Color.FromArgb(214, 48, 49);

		public Color Color9Lt => Color.FromArgb(253, 121, 168);
		public Color Color9Dk => Color.FromArgb(232, 67, 147);

		public Color Color10Lt => Color.FromArgb(99, 110, 114);
		public Color Color10Dk => Color.FromArgb(45, 52, 54);
	}
	public struct AussiaPalette : IPalette
	{
		public Color Color1Lt => Color.FromArgb(246, 229, 141);
		public Color Color1Dk => Color.FromArgb(249, 202, 36);

		public Color Color2Lt => Color.FromArgb(255, 190, 118);
		public Color Color2Dk => Color.FromArgb(240, 147, 43);

		public Color Color3Lt => Color.FromArgb(255, 121, 121);
		public Color Color3Dk => Color.FromArgb(235, 77, 75);

		public Color Color4Lt => Color.FromArgb(186, 220, 88);
		public Color Color4Dk => Color.FromArgb(106, 176, 76);

		public Color Color5Lt => Color.FromArgb(223, 249, 251);
		public Color Color5Dk => Color.FromArgb(199, 236, 238);

		public Color Color6Lt => Color.FromArgb(126, 214, 223);
		public Color Color6Dk => Color.FromArgb(34, 166, 179);

		public Color Color7Lt => Color.FromArgb(224, 86, 253);
		public Color Color7Dk => Color.FromArgb(190, 46, 221);

		public Color Color8Lt => Color.FromArgb(104, 109, 224);
		public Color Color8Dk => Color.FromArgb(72, 52, 212);

		public Color Color9Lt => Color.FromArgb(48, 51, 107);
		public Color Color9Dk => Color.FromArgb(19, 15, 64);

		public Color Color10Lt => Color.FromArgb(149, 175, 192);
		public Color Color10Dk => Color.FromArgb(83, 92, 104);
	}
	public struct BritishPalette : IPalette
	{
		public Color Color1Lt => Color.FromArgb(0, 168, 255);
		public Color Color1Dk => Color.FromArgb(0, 151, 230);

		public Color Color2Lt => Color.FromArgb(156, 136, 255);
		public Color Color2Dk => Color.FromArgb(140, 122, 230);

		public Color Color3Lt => Color.FromArgb(251, 197, 49);
		public Color Color3Dk => Color.FromArgb(225, 177, 44);

		public Color Color4Lt => Color.FromArgb(76, 209, 55);
		public Color Color4Dk => Color.FromArgb(68, 189, 50);

		public Color Color5Lt => Color.FromArgb(72, 126, 176);
		public Color Color5Dk => Color.FromArgb(64, 115, 158);

		public Color Color6Lt => Color.FromArgb(232, 65, 24);
		public Color Color6Dk => Color.FromArgb(194, 54, 22);

		public Color Color7Lt => Color.FromArgb(245, 246, 250);
		public Color Color7Dk => Color.FromArgb(220, 221, 225);

		public Color Color8Lt => Color.FromArgb(127, 143, 166);
		public Color Color8Dk => Color.FromArgb(113, 128, 147);

		public Color Color9Lt => Color.FromArgb(39, 60, 117);
		public Color Color9Dk => Color.FromArgb(25, 42, 86);

		public Color Color10Lt => Color.FromArgb(53, 59, 72);
		public Color Color10Dk => Color.FromArgb(47, 54, 64);
	}
	public struct CanadianPalette : IPalette
	{
		public Color Color1Lt => Color.FromArgb(255, 159, 243);
		public Color Color1Dk => Color.FromArgb(243, 104, 224);

		public Color Color2Lt => Color.FromArgb(254, 202, 87);
		public Color Color2Dk => Color.FromArgb(255, 159, 67);

		public Color Color3Lt => Color.FromArgb(255, 107, 107);
		public Color Color3Dk => Color.FromArgb(238, 82, 83);

		public Color Color4Lt => Color.FromArgb(72, 219, 251);
		public Color Color4Dk => Color.FromArgb(10, 189, 227);

		public Color Color5Lt => Color.FromArgb(29, 209, 161);
		public Color Color5Dk => Color.FromArgb(16, 172, 132);

		public Color Color6Lt => Color.FromArgb(0, 210, 211);
		public Color Color6Dk => Color.FromArgb(1, 163, 164);

		public Color Color7Lt => Color.FromArgb(84, 160, 255);
		public Color Color7Dk => Color.FromArgb(46, 134, 222);

		public Color Color8Lt => Color.FromArgb(95, 39, 205);
		public Color Color8Dk => Color.FromArgb(52, 31, 151);

		public Color Color9Lt => Color.FromArgb(200, 214, 229);
		public Color Color9Dk => Color.FromArgb(131, 149, 167);

		public Color Color10Lt => Color.FromArgb(87, 101, 116);
		public Color Color10Dk => Color.FromArgb(34, 47, 62);
	}
	public struct ChinesePalette : IPalette
	{
		public Color Color1Lt => Color.FromArgb(236, 204, 104);
		public Color Color1Dk => Color.FromArgb(255, 165, 2);

		public Color Color2Lt => Color.FromArgb(255, 127, 80);
		public Color Color2Dk => Color.FromArgb(255, 99, 72);

		public Color Color3Lt => Color.FromArgb(255, 107, 129);
		public Color Color3Dk => Color.FromArgb(255, 71, 87);

		public Color Color4Lt => Color.FromArgb(164, 176, 190);
		public Color Color4Dk => Color.FromArgb(116, 125, 140);

		public Color Color5Lt => Color.FromArgb(87, 96, 111);
		public Color Color5Dk => Color.FromArgb(47, 53, 66);

		public Color Color6Lt => Color.FromArgb(123, 237, 159);
		public Color Color6Dk => Color.FromArgb(46, 213, 115);

		public Color Color7Lt => Color.FromArgb(112, 161, 255);
		public Color Color7Dk => Color.FromArgb(30, 144, 255);

		public Color Color8Lt => Color.FromArgb(83, 82, 237);
		public Color Color8Dk => Color.FromArgb(55, 66, 250);

		public Color Color9Lt => Color.FromArgb(255, 255, 255);
		public Color Color9Dk => Color.FromArgb(241, 242, 246);

		public Color Color10Lt => Color.FromArgb(223, 228, 234);
		public Color Color10Dk => Color.FromArgb(206, 214, 224);
	}
	public struct DutchPalette : IPalette
	{
		public Color Color1Lt => Color.FromArgb(255, 195, 18);
		public Color Color1Dk => Color.FromArgb(247, 159, 31);

		public Color Color2Lt => Color.FromArgb(196, 229, 56);
		public Color Color2Dk => Color.FromArgb(163, 203, 56);

		public Color Color3Lt => Color.FromArgb(18, 203, 196);
		public Color Color3Dk => Color.FromArgb(18, 137, 167);

		public Color Color4Lt => Color.FromArgb(253, 167, 223);
		public Color Color4Dk => Color.FromArgb(217, 128, 250);

		public Color Color5Lt => Color.FromArgb(237, 76, 103);
		public Color Color5Dk => Color.FromArgb(181, 52, 113);

		public Color Color6Lt => Color.FromArgb(238, 90, 36);
		public Color Color6Dk => Color.FromArgb(234, 32, 39);

		public Color Color7Lt => Color.FromArgb(0, 148, 50);
		public Color Color7Dk => Color.FromArgb(0, 98, 102);

		public Color Color8Lt => Color.FromArgb(6, 82, 221);
		public Color Color8Dk => Color.FromArgb(27, 20, 100);

		public Color Color9Lt => Color.FromArgb(153, 128, 250);
		public Color Color9Dk => Color.FromArgb(87, 88, 187);

		public Color Color10Lt => Color.FromArgb(131, 52, 113);
		public Color Color10Dk => Color.FromArgb(111, 30, 81);
	}
	public struct FrenchPalette : IPalette
	{
		public Color Color1Lt => Color.FromArgb(250, 211, 144);
		public Color Color1Dk => Color.FromArgb(246, 185, 59);

		public Color Color2Lt => Color.FromArgb(248, 194, 145);
		public Color Color2Dk => Color.FromArgb(229, 80, 57);

		public Color Color3Lt => Color.FromArgb(106, 137, 204);
		public Color Color3Dk => Color.FromArgb(74, 105, 189);

		public Color Color4Lt => Color.FromArgb(130, 204, 221);
		public Color Color4Dk => Color.FromArgb(96, 163, 188);

		public Color Color5Lt => Color.FromArgb(184, 233, 148);
		public Color Color5Dk => Color.FromArgb(120, 224, 143);

		public Color Color6Lt => Color.FromArgb(250, 152, 58);
		public Color Color6Dk => Color.FromArgb(229, 142, 38);

		public Color Color7Lt => Color.FromArgb(235, 47, 6);
		public Color Color7Dk => Color.FromArgb(183, 21, 64);

		public Color Color8Lt => Color.FromArgb(30, 55, 153);
		public Color Color8Dk => Color.FromArgb(12, 36, 97);

		public Color Color9Lt => Color.FromArgb(60, 99, 130);
		public Color Color9Dk => Color.FromArgb(10, 61, 98);

		public Color Color10Lt => Color.FromArgb(56, 173, 169);
		public Color Color10Dk => Color.FromArgb(7, 153, 146);
	}
	public struct GermanPalette : IPalette
	{
		public Color Color1Lt => Color.FromArgb(252, 92, 101);
		public Color Color1Dk => Color.FromArgb(235, 59, 90);

		public Color Color2Lt => Color.FromArgb(253, 150, 68);
		public Color Color2Dk => Color.FromArgb(250, 130, 49);

		public Color Color3Lt => Color.FromArgb(254, 211, 48);
		public Color Color3Dk => Color.FromArgb(247, 183, 49);

		public Color Color4Lt => Color.FromArgb(38, 222, 129);
		public Color Color4Dk => Color.FromArgb(32, 191, 107);

		public Color Color5Lt => Color.FromArgb(43, 203, 186);
		public Color Color5Dk => Color.FromArgb(15, 185, 177);

		public Color Color6Lt => Color.FromArgb(69, 170, 242);
		public Color Color6Dk => Color.FromArgb(45, 152, 218);

		public Color Color7Lt => Color.FromArgb(75, 123, 236);
		public Color Color7Dk => Color.FromArgb(56, 103, 214);

		public Color Color8Lt => Color.FromArgb(165, 94, 234);
		public Color Color8Dk => Color.FromArgb(136, 84, 208);

		public Color Color9Lt => Color.FromArgb(209, 216, 224);
		public Color Color9Dk => Color.FromArgb(165, 177, 194);

		public Color Color10Lt => Color.FromArgb(119, 140, 163);
		public Color Color10Dk => Color.FromArgb(75, 101, 132);
	}
	public struct IndianPalette : IPalette
	{
		public Color Color1Lt => Color.FromArgb(254, 164, 127);
		public Color Color1Dk => Color.FromArgb(249, 127, 81);

		public Color Color2Lt => Color.FromArgb(37, 204, 247);
		public Color Color2Dk => Color.FromArgb(27, 156, 252);

		public Color Color3Lt => Color.FromArgb(234, 181, 67);
		public Color Color3Dk => Color.FromArgb(248, 239, 186);

		public Color Color4Lt => Color.FromArgb(85, 230, 193);
		public Color Color4Dk => Color.FromArgb(88, 177, 159);

		public Color Color5Lt => Color.FromArgb(202, 211, 200);
		public Color Color5Dk => Color.FromArgb(44, 58, 71);

		public Color Color6Lt => Color.FromArgb(179, 55, 113);
		public Color Color6Dk => Color.FromArgb(109, 33, 79);

		public Color Color7Lt => Color.FromArgb(59, 59, 152);
		public Color Color7Dk => Color.FromArgb(24, 44, 97);

		public Color Color8Lt => Color.FromArgb(253, 114, 114);
		public Color Color8Dk => Color.FromArgb(252, 66, 123);

		public Color Color9Lt => Color.FromArgb(154, 236, 219);
		public Color Color9Dk => Color.FromArgb(189, 197, 129);

		public Color Color10Lt => Color.FromArgb(214, 162, 232);
		public Color Color10Dk => Color.FromArgb(130, 88, 159);
	}
	public struct RussianPalette : IPalette
	{
		public Color Color1Lt => Color.FromArgb(243, 166, 131);
		public Color Color1Dk => Color.FromArgb(241, 144, 102);

		public Color Color2Lt => Color.FromArgb(247, 215, 148);
		public Color Color2Dk => Color.FromArgb(245, 205, 121);

		public Color Color3Lt => Color.FromArgb(119, 139, 235);
		public Color Color3Dk => Color.FromArgb(84, 109, 229);

		public Color Color4Lt => Color.FromArgb(231, 127, 103);
		public Color Color4Dk => Color.FromArgb(225, 95, 65);

		public Color Color5Lt => Color.FromArgb(207, 106, 135);
		public Color Color5Dk => Color.FromArgb(196, 69, 105);

		public Color Color6Lt => Color.FromArgb(120, 111, 166);
		public Color Color6Dk => Color.FromArgb(87, 75, 144);

		public Color Color7Lt => Color.FromArgb(248, 165, 194);
		public Color Color7Dk => Color.FromArgb(247, 143, 179);

		public Color Color8Lt => Color.FromArgb(99, 205, 218);
		public Color Color8Dk => Color.FromArgb(61, 193, 211);

		public Color Color9Lt => Color.FromArgb(234, 134, 133);
		public Color Color9Dk => Color.FromArgb(230, 103, 103);

		public Color Color10Lt => Color.FromArgb(89, 98, 117);
		public Color Color10Dk => Color.FromArgb(48, 57, 82);
	}
	public struct SpanishPalette : IPalette
	{
		public Color Color1Lt => Color.FromArgb(64, 64, 122);
		public Color Color1Dk => Color.FromArgb(44, 44, 84);

		public Color Color2Lt => Color.FromArgb(112, 111, 211);
		public Color Color2Dk => Color.FromArgb(71, 71, 135);

		public Color Color3Lt => Color.FromArgb(247, 241, 227);
		public Color Color3Dk => Color.FromArgb(170, 166, 157);

		public Color Color4Lt => Color.FromArgb(52, 172, 224);
		public Color Color4Dk => Color.FromArgb(34, 112, 147);

		public Color Color5Lt => Color.FromArgb(51, 217, 178);
		public Color Color5Dk => Color.FromArgb(33, 140, 116);

		public Color Color6Lt => Color.FromArgb(255, 82, 82);
		public Color Color6Dk => Color.FromArgb(179, 57, 57);

		public Color Color7Lt => Color.FromArgb(255, 121, 63);
		public Color Color7Dk => Color.FromArgb(205, 97, 51);

		public Color Color8Lt => Color.FromArgb(209, 204, 192);
		public Color Color8Dk => Color.FromArgb(132, 129, 122);

		public Color Color9Lt => Color.FromArgb(255, 177, 66);
		public Color Color9Dk => Color.FromArgb(204, 142, 53);

		public Color Color10Lt => Color.FromArgb(255, 218, 121);
		public Color Color10Dk => Color.FromArgb(204, 174, 98);
	}
	public struct SwedishPalette : IPalette
	{
		public Color Color1Lt => Color.FromArgb(239, 87, 119);
		public Color Color1Dk => Color.FromArgb(245, 59, 87);

		public Color Color2Lt => Color.FromArgb(87, 95, 207);
		public Color Color2Dk => Color.FromArgb(60, 64, 198);

		public Color Color3Lt => Color.FromArgb(75, 207, 250);
		public Color Color3Dk => Color.FromArgb(15, 188, 249);

		public Color Color4Lt => Color.FromArgb(52, 231, 228);
		public Color Color4Dk => Color.FromArgb(0, 216, 214);

		public Color Color5Lt => Color.FromArgb(11, 232, 129);
		public Color Color5Dk => Color.FromArgb(5, 196, 107);

		public Color Color6Lt => Color.FromArgb(255, 192, 72);
		public Color Color6Dk => Color.FromArgb(255, 168, 1);

		public Color Color7Lt => Color.FromArgb(255, 221, 89);
		public Color Color7Dk => Color.FromArgb(255, 211, 42);

		public Color Color8Lt => Color.FromArgb(255, 94, 87);
		public Color Color8Dk => Color.FromArgb(255, 63, 52);

		public Color Color9Lt => Color.FromArgb(210, 218, 226);
		public Color Color9Dk => Color.FromArgb(128, 142, 155);

		public Color Color10Lt => Color.FromArgb(72, 84, 96);
		public Color Color10Dk => Color.FromArgb(30, 39, 46);
	}
	public struct TurkishPalette : IPalette
	{
		public Color Color1Lt => Color.FromArgb(205, 132, 241);
		public Color Color1Dk => Color.FromArgb(197, 108, 240);

		public Color Color2Lt => Color.FromArgb(255, 204, 204);
		public Color Color2Dk => Color.FromArgb(255, 184, 184);

		public Color Color3Lt => Color.FromArgb(255, 77, 77);
		public Color Color3Dk => Color.FromArgb(255, 56, 56);

		public Color Color4Lt => Color.FromArgb(255, 175, 64);
		public Color Color4Dk => Color.FromArgb(255, 159, 26);

		public Color Color5Lt => Color.FromArgb(255, 250, 101);
		public Color Color5Dk => Color.FromArgb(255, 242, 0);

		public Color Color6Lt => Color.FromArgb(50, 255, 126);
		public Color Color6Dk => Color.FromArgb(58, 227, 116);

		public Color Color7Lt => Color.FromArgb(126, 255, 245);
		public Color Color7Dk => Color.FromArgb(103, 230, 220);

		public Color Color8Lt => Color.FromArgb(24, 220, 255);
		public Color Color8Dk => Color.FromArgb(23, 192, 235);

		public Color Color9Lt => Color.FromArgb(125, 95, 255);
		public Color Color9Dk => Color.FromArgb(113, 88, 226);

		public Color Color10Lt => Color.FromArgb(75, 75, 75);
		public Color Color10Dk => Color.FromArgb(61, 61, 61);
	}
}
