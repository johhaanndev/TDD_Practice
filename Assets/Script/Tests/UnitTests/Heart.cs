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
            _image.fillAmount += numberOfHeartPieces * FillPerHeartPiece;
        }

        internal void Deplete(int numberOfHeartPieces)
        {
            _image.fillAmount -= numberOfHeartPieces * FillPerHeartPiece;
        }
    }

}