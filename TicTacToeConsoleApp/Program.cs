using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsoleApp
{
	class Program
	{

		//the field of play
		static char[,] playfield =
		{
			{'1', '2', '3' },
			{'4', '5', '6' },
			{'7', '8', '9' }
		};

		static void Main( string[] args )
		{
			int player = 2; //PLayer 1 starts
			int input = 0;
			bool validInput = true;


			do
			{
				if ( player == 2 )
				{
					player = 1;
					EnterXorO( player, input );
				}
				else if ( player == 1 )
				{
					player = 2;
					EnterXorO( player, input );
				}

				SetField();

				do
				{
					Console.Write( "\nPlayer {0}: Choose your field! ", player);
					try
					{
						input = Convert.ToInt32( Console.ReadLine() );
					}
					catch
					{

						Console.WriteLine("Please enter a number");
					}

					if ( (input == 1) && ( playfield[ 0, 0 ] == '1' ) )
						validInput = true;
					else if ( ( input == 2 ) && ( playfield[ 0, 1 ] == '2' ) )
						validInput = true;
					else if ( ( input == 3 ) && ( playfield[ 0, 2 ] == '3' ) )
						validInput = true;
					else if ( ( input == 4 ) && ( playfield[ 1, 0 ] == '4' ) )
						validInput = true;
					else if ( ( input == 5 ) && ( playfield[ 1, 1 ] == '5' ) )
						validInput = true;
					else if ( ( input == 6 ) && ( playfield[ 1, 2 ] == '6' ) )
						validInput = true;
					else if ( ( input == 7 ) && ( playfield[ 2, 0 ] == '7' ) )
						validInput = true;
					else if ( ( input == 8 ) && ( playfield[ 2, 1 ] == '8' ) )
						validInput = true;
					else if ( ( input == 9 ) && ( playfield[ 2, 2 ] == '9' ) )
						validInput = true;

				} while ( !validInput );
			}
			while ( true );
		}

		public static void SetField()
		{
			Console.Clear();
			Console.WriteLine( "     |     |     " );
			Console.WriteLine( "  {0}  |  {1}  |  {2}", playfield[ 0, 0 ], playfield[ 0, 1 ], playfield[ 0, 2 ] );
			Console.WriteLine( "_____|_____|_____" );
			Console.WriteLine( "     |     |     " );
			Console.WriteLine( "  {0}  |  {1}  |  {2}", playfield[ 1, 0 ], playfield[ 1, 1 ], playfield[ 1, 2 ] );
			Console.WriteLine( "_____|_____|_____" );
			Console.WriteLine( "     |     |     " );
			Console.WriteLine( "  {0}  |  {1}  |  {2}", playfield[ 2, 0 ], playfield[ 2, 1 ], playfield[ 2, 2 ] );
			Console.WriteLine( "     |     |     " );
		}

		public static void EnterXorO( int player, int input )
		{
			char playerSign = ' ';
			if ( player == 1 )
				playerSign = 'X';
			else if ( player == 2 )
				playerSign = 'O';

			switch ( input )
			{
				case 1: playfield[ 0, 0 ] = playerSign; break;
				case 2: playfield[ 0, 1 ] = playerSign; break;
				case 3: playfield[ 0, 2 ] = playerSign; break;
				case 4: playfield[ 1, 0 ] = playerSign; break;
				case 5: playfield[ 1, 1 ] = playerSign; break;
				case 6: playfield[ 1, 2 ] = playerSign; break;
				case 7: playfield[ 2, 0 ] = playerSign; break;
				case 8: playfield[ 2, 1 ] = playerSign; break;
				case 9: playfield[ 2, 2 ] = playerSign; break;
			}
		}
	}
}
