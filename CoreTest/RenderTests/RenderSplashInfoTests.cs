﻿using System;
using FluentAssertions;
using GoC.WebTemplate;
using Xunit;

namespace CoreTest.RenderTests
{
    public class RenderSplashInfoTests
    {
        [Theory, AutoNSubstituteData]
        public void RenderSplashInfoTest(Core sut)
        {
            //NOTE: Only testing the RenderSplashInfo properties right now. More properties can be added later.
            sut.SplashPageInfo.EnglishHomeUrl = "http://www.canada.ca/en/index.html";
            sut.SplashPageInfo.FrenchHomeUrl = "http://www.canada.ca/fr/index.html";
            sut.SplashPageInfo.EnglishTermsUrl = "http://www.canada.ca/en/transparency/terms.html";
            sut.SplashPageInfo.FrenchTermsUrl = "http://www.canada.ca/fr/transparence/avis.html";
            sut.SplashPageInfo.EnglishName = "[My web asset]";
            sut.SplashPageInfo.FrenchName = "[Mon actif web]";
            var result = sut.RenderSplashInfo();

            result.ToString().Should().Be("{\"cdnEnv\":\"\",\"indexEng\":\"http://www.canada.ca/en/index.html\",\"indexFra\":\"http://www.canada.ca/fr/index.html\",\"termsEng\":\"http://www.canada.ca/en/transparency/terms.html\",\"termsFra\":\"http://www.canada.ca/fr/transparence/avis.html\",\"nameEng\":\"[My web asset]\",\"nameFra\":\"[Mon actif web]\"}");
        }
    }
}
