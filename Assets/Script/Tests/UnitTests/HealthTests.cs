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
        private Image _image;
        private Heart _heart;

        [SetUp]
        public void BeforeEveryTest()
        {
            _image = new GameObject().AddComponent<Image>();
            _heart = new Heart(_image);
        }

        [Test]
        public void WhenReplenishHeartWith0Pieces_IfHeartIsEmpty_ImageIsFilledWith0PercentAmount()
        {
            _image.fillAmount = 0;

            _heart.Replenish(0);

            Assert.AreEqual(0, _image.fillAmount);
        }

        [Test]
        public void WhenReplenishHeartWith1Piece_IfHeartIsEmpty_ImageIsFilledWith25PercentAmount()
        {
            _image.fillAmount = 0;
            _heart = new Heart(_image);

            _heart.Replenish(1);

            Assert.AreEqual(0.25f, _image.fillAmount);
        }

        [Test]
        public void WhenReplenishHeartWith1Piece_IfHeartIsAlready25PercentFilled_ImageIsFilledWith50PercentAmount()
        {
            _image.fillAmount = 0.25f;
            _heart = new Heart(_image);

            _heart.Replenish(1);

            Assert.AreEqual(0.5f, _image.fillAmount);
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