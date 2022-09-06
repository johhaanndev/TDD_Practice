using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Game.Tests.UnitTests
{

    public class HealthTests
    {
        [Test]
        public void WhenReplenishHeartWith0Pieces_IfHeartIsEmpty_ImageIsFilledWith0PercentAmount()
        {
            var image = new GameObject().AddComponent<Image>();
            image.fillAmount = 0;
            var heart = new Heart(image);

            heart.Replenish(0);

            Assert.AreEqual(0, image.fillAmount);
        }

        [Test]
        public void WhenReplenishHeartWith1Piece_IfHeartIsEmpty_ImageIsFilledWith25PercentAmount()
        {
            var image = new GameObject().AddComponent<Image>();
            image.fillAmount = 0;
            var heart = new Heart(image);

            heart.Replenish(1);

            Assert.AreEqual(0.25f, image.fillAmount);
        }

        [Test]
        public void WhenReplenishHeartWith1Piece_IfHeartIsAlready25PercentFilled_ImageIsFilledWith50PercentAmount()
        {
            var image = new GameObject().AddComponent<Image>();
            image.fillAmount = 0.25f;
            var heart = new Heart(image);

            heart.Replenish(1);

            Assert.AreEqual(0.5f, image.fillAmount);
        }
    }

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
    }

}