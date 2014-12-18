using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;

namespace Sudoku {

    public class Spiele {

        private List<int[,]> _spiel = new List<int[,]>();


        public List<int[,]> getSpiel() { return _spiel; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        public Spiele(){

            // Sudokutestdaten erzeugen
            erzeugeSpiel001();
            erzeugeSpiel002();
            erzeugeSpiel003();
        }

        private void erzeugeSpiel001(){
            int[,] beispieldaten = new int[9, 9];   // zeile, spalte
            beispieldaten[0, 1] = 2; beispieldaten[1, 0] = 6; beispieldaten[2, 2] = 8;
            beispieldaten[0, 4] = 5; beispieldaten[1, 1] = 7; beispieldaten[2, 3] = 2;
            beispieldaten[0, 6] = 6; beispieldaten[1, 3] = 8; beispieldaten[2, 5] = 6;
            beispieldaten[0, 7] = 8; beispieldaten[1, 4] = 3; beispieldaten[2, 8] = 1;
            beispieldaten[0, 8] = 7; beispieldaten[1, 8] = 4;

            beispieldaten[3, 0] = 5; beispieldaten[4, 0] = 4; beispieldaten[5, 1] = 6;
            beispieldaten[3, 1] = 1; beispieldaten[4, 3] = 7; beispieldaten[5, 2] = 3;
            beispieldaten[3, 4] = 2; beispieldaten[4, 6] = 5; beispieldaten[5, 4] = 1;
            beispieldaten[3, 6] = 8; beispieldaten[4, 7] = 1; beispieldaten[5, 6] = 2;
            beispieldaten[5, 7] = 7;
            beispieldaten[5, 8] = 9;

            beispieldaten[6, 0] = 1; beispieldaten[7, 0] = 7; beispieldaten[8, 1] = 3;
            beispieldaten[6, 1] = 8; beispieldaten[7, 1] = 5; beispieldaten[8, 2] = 4;
            beispieldaten[6, 3] = 5; beispieldaten[7, 6] = 1; beispieldaten[8, 3] = 1;
            beispieldaten[6, 4] = 9; beispieldaten[8, 5] = 8;
            beispieldaten[6, 5] = 7;
            beispieldaten[6, 7] = 3;

            _spiel.Add(beispieldaten);
        }
        private void erzeugeSpiel002(){
            int[,] beispieldaten = new int[9, 9];   // zeile, spalte
            beispieldaten[0, 3] = 5; beispieldaten[1, 0] = 5; beispieldaten[2, 0] = 8;
            beispieldaten[0, 4] = 8; beispieldaten[1, 4] = 2; beispieldaten[2, 2] = 7;
            beispieldaten[0, 8] = 7; beispieldaten[1, 7] = 6;

            beispieldaten[3, 3] = 4; beispieldaten[4, 0] = 3; beispieldaten[5, 0] = 4;
            beispieldaten[3, 7] = 9; beispieldaten[4, 4] = 5; beispieldaten[5, 2] = 1;
            beispieldaten[3, 8] = 6; beispieldaten[4, 7] = 8; beispieldaten[5, 4] = 9;
                                                              beispieldaten[5, 5] = 6;

            beispieldaten[6, 1] = 8; beispieldaten[7, 2] = 5; beispieldaten[8, 0] = 1;
            beispieldaten[6, 2] = 9; beispieldaten[7, 4] = 3; beispieldaten[8, 1] = 4;
            beispieldaten[6, 5] = 1; beispieldaten[7, 8] = 1; beispieldaten[8, 2] = 3;
            beispieldaten[6, 6] = 5;                          beispieldaten[8, 3] = 7;
            beispieldaten[6, 8] = 3;                          beispieldaten[8, 5] = 5;
                                                              beispieldaten[8, 7] = 2;
                                                              beispieldaten[8, 8] = 9;

            _spiel.Add(beispieldaten);
        }
        private void erzeugeSpiel003(){
            int[,] beispieldaten = new int[9, 9];   // zeile, spalte
            beispieldaten[0, 1] = 2; beispieldaten[1, 1] = 3; beispieldaten[2, 1] = 7;
            beispieldaten[0, 7] = 9; beispieldaten[1, 2] = 9; beispieldaten[2, 3] = 1;
            beispieldaten[0, 8] = 8; beispieldaten[1, 7] = 4; beispieldaten[2, 5] = 2;
                                                              beispieldaten[2, 8] = 5;
      

            beispieldaten[3, 3] = 3; beispieldaten[4, 4] = 5; beispieldaten[5, 1] = 5;
            beispieldaten[3, 4] = 7; beispieldaten[4, 5] = 8; beispieldaten[5, 2] = 4;
            beispieldaten[3, 7] = 5; beispieldaten[4, 6] = 2; beispieldaten[5, 6] = 9;
                                     beispieldaten[4, 7] = 1;

            beispieldaten[6, 3] = 6; beispieldaten[7, 0] = 5; beispieldaten[8, 0] = 7;
            beispieldaten[6, 5] = 9; beispieldaten[7, 5] = 7; beispieldaten[8, 1] = 4;
            beispieldaten[6, 7] = 7; beispieldaten[7, 6] = 4; beispieldaten[8, 2] = 1;
                                     beispieldaten[7, 8] = 3; beispieldaten[8, 6] = 6;
                                                              beispieldaten[8, 7] = 8;

            _spiel.Add(beispieldaten);
        }

        /// <summary>
        /// Gibt ein zufällig ausgewähltes Sudoku aus dieser Klasse zurück
        /// </summary>
        /// <returns></returns>
        public int[,] getSudoku(){

            Random r = new Random();
            
            return getSpiel()[r.Next(getSpiel().Count)];
        }

    }

}
