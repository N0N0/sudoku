/*
 * Erstellt mit SharpDevelop.
 * Benutzer: addi
 * Datum: 15.12.2013
 * Zeit: 17:58
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Drawing;

namespace Sudoku
{
	/// <summary>
	/// Description of Constants.
	/// </summary>
	public static class Constants {

		public static Font GAME_DEFAULT_FONT = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

		public static Color FIELD_COLOR_UNCHECKED = System.Drawing.Color.Black;
		public static Color FIELD_COLOR_CHECKED= System.Drawing.Color.Green;
		public static Color FIELD_COLOR_DOUBLE = System.Drawing.Color.Red;
	}
}
