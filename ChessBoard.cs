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


        /* Pre-Condition: Intake of Pawn Object, 2 integers (x,y coordinates) and Enum Piececolor (black or white).
         * Post-Condition:  Pawn Object with input generated (x,y) coordinates and color. */
        public void Add(Pawn pawn, int xCoordinate, int yCoordinate, PieceColor pieceColor)
        {
            // Set _xCoordinate in Pawn.
            pawn.XCoordinate = xCoordinate;
 
            // Set _yCoordinate in Pawn.
            pawn.YCoordinate = yCoordinate;

            // Set _pieceColor using mutator Pawn() in Pawn.
            pawn = new Pawn(pieceColor);        

        }

        /* Pre-Condition: Intake of 2 integers (x,y) coordinates.
         * Post-Condition: Returns True or False based on (x ,y) Coordinates in comparison to MaxBoardWidth and MaxBoardHeight.*/
        public bool IsLegalBoardPosition(int xCoordinate, int yCoordinate)
        {
            // Non-Zero Test, y bound and then x bound.
            if(xCoordinate >= 0 && yCoordinate >= 0)
            {       
                if ((MaxBoardHeight >= yCoordinate))
                {       
                    if ((MaxBoardWidth >= xCoordinate))
                    {    
                        return true;
                    }
                    else
                        return false;                       
                }
                else
                    return false;                           
            }
            else
                return false;                               
        }
    }
}
