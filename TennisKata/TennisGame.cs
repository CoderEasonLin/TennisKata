﻿using System.Collections.Generic;

namespace TennisKata
{
    public class TennisGame
    {
        private int player1Score { get; set; }

        private int player2Score;
        private bool deuce;

        private readonly List<int> _scoreMapping = new List<int>
        {
            0,
            15,
            30,
            40
        };

        private const int MAX_POINT_PER_GAME = 3;

        public string Score()
        {
            if (player1Score >= MAX_POINT_PER_GAME && player2Score >= MAX_POINT_PER_GAME)
            {
                int scoreDiff = player1Score - player2Score;
                if(scoreDiff == 0)
                    return "Deuce";
                if (scoreDiff == 1)
                    return "Advantage Player1";
                if (scoreDiff > 1)
                    return "Game Player1";
                if (scoreDiff == -1)
                    return "Advantage Player2";
                if (scoreDiff < -1)
                    return "Game Player2";
            }
            if (player1Score > MAX_POINT_PER_GAME)
                return "Game Player1";
            if (player2Score > MAX_POINT_PER_GAME)
                return "Game Player2";

            return string.Format("{0}:{1}", _scoreMapping[player1Score], _scoreMapping[player2Score]);
        }

        public void Player1WinBall()
        {
            player1Score++;
        }

        public void Player2WinBall()
        {
            player2Score++;
        }
    }
}