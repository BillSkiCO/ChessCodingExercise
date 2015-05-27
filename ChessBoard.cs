/*
 * 
 * 
 * 
 * */


using System;

namespace Chess.Domain
{
    public class ChessBoard
    {
        public static readonly int MaxBoardWidth = 7;
        public static readonly int MaxBoardHeight = 7;
        private Pawn[,] pieces;

        public ChessBoard ()
        {
            pieces = new Pawn[MaxBoardWidth, MaxBoardHeight];
        }


        /* Pre-Condition: Intake of Pawn Object, 2 integers (x,y coordinates), Enum Piececolor (black or white)
         * Post-Condition:  Pawn Object with input generated (x,y) coordinates and color */
        public void Add(Pawn pawn, int xCoordinate, int yCoordinate, PieceColor pieceColor)
        {
            pawn.XCoordinate = xCoordinate;     //Set _xCoordinate in Pawn class
            pawn.YCoordinate = yCoordinate;     //Set _yCoordinate in Pawn class
            pawn = new Pawn(pieceColor);        //Set _pieceColor using mutator Pawn() in Pawn class

            
        }

        /* Pre-Condition: Intake of 2 integers
         * Post-Condition: Returns True or False based on (x ,y) Coordinates in comparison to MaxBoardWidth and MaxBoardHeight*/
        public bool IsLegalBoardPosition(int xCoordinate, int yCoordinate)
        {
            if(xCoordinate >= 0 && yCoordinate >= 0){       //Non-zero test
                if ((MaxBoardHeight >= yCoordinate)){       //yCoordinate Test
                    if ((MaxBoardWidth >= xCoordinate)){    //xCoordinate Test
                        return true;
                    }
                    else
                        return false;                       //xCoordinate Test Fail
                }
                else
                    return false;                           //yCoordinate Test Fail
            }
            else
                return false;                               //Non-Zero Test Fail
            
        }

    }
}
