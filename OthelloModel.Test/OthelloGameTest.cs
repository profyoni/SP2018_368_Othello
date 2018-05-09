using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OthelloModel.Test
{
    [TestClass]
    public class OthelloGameTest
    {
        [TestMethod]
        public void CtorThatPiecesSetUp()
        {
            var g = new OthelloGame();
            g.board[3, 4].Should().Be(GamePiece.Black);
            g.board[3, 3].Should().Be(GamePiece.White);
            g.board[3, 2].Should().Be(GamePiece.Blank);
        }

        [TestMethod]
        public void MoveWhenOccupiedShouldReturnFalse()
        {
            var g = new OthelloGame();
            g.Move(3, 3).Should().BeFalse();
        }

        [TestMethod]
        public void MoveWhenNotOccupiedShouldReturnTrue()
        {
            var g = new OthelloGame();
            g.Move(3, 5).Should().BeTrue();
        }

        [TestMethod]
        public void WhenFullBoardStopGame()
        {
            //...
        }

    }
}
