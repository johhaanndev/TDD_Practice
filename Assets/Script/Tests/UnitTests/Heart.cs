using System;
using UnityEngine.UI;

namespace Game.Tests.UnitTests
{
    public class Heart
    {
        private const float FillPerHeartPiece = 0.25f;
        private Image _image;

        public Heart(Image image)
        {
            _image = image;
        }

        public void Replenish(int numberOfHeartPieces)
        {
            if (numberOfHeartPieces < 0)
                throw new ArgumentOutOfRangeException("Number of heart pieces must be positive", "numberOfHeartPieces");

            _image.fillAmount += numberOfHeartPieces * FillPerHeartPiece;
        }

        internal void Deplete(int numberOfHeartPieces)
        {
            if (numberOfHeartPieces < 0)
                throw new ArgumentOutOfRangeException("Number of heart pieces must be positive", "numberOfHeartPieces");

            _image.fillAmount -= numberOfHeartPieces * FillPerHeartPiece;
        }
    }

}