/*
 * EasyBimehLanding.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using EasyBimehLanding.Standard;
using EasyBimehLanding.Standard.Utilities; 
using EasyBimehLanding.Standard.Http.Client;
using EasyBimehLanding.Standard.Http.Response;
using EasyBimehLanding.Tests.Helpers;
using NUnit.Framework;
using EasyBimehLanding.Standard;
using EasyBimehLanding.Standard.Controllers;
using EasyBimehLanding.Standard.Exceptions;

namespace EasyBimehLanding.Tests
{
    [TestFixture]
    public class CarBodyControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static CarBodyController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().CarBody;
        }

    }
}