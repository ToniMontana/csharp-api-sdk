using System;
using System.Collections.Generic;
using FortnoxAPILibrary.Connectors;
using FortnoxAPILibrary.Entities;
using FortnoxAPILibrary.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FortnoxAPILibrary.GeneratedTests
{
    [TestClass]
    public class PriceListTests
    {
        [TestInitialize]
        public void Init()
        {
            //Set global credentials for SDK
            //--- Open 'TestCredentials.resx' to edit the values ---\\
            ConnectionCredentials.AccessToken = TestCredentials.Access_Token;
            ConnectionCredentials.ClientSecret = TestCredentials.Client_Secret;
        }

        [TestMethod]
        public void Test_PriceList_CRUD()
        {
            #region Arrange
            //Add code to create required resources
            #endregion Arrange

            var connector = new PriceListConnector();

            #region CREATE
            var newPriceList = new PriceList()
            {
                //TODO: Populate Entity
            };

            var createdPriceList = connector.Create(newPriceList);
            MyAssert.HasNoError(connector);
            Assert.AreEqual("PropertyValue", createdPriceList.SomeProperty); //TODO: Adapt

            #endregion CREATE

            #region UPDATE

            createdPriceList.SomeProperty = "UpdatedPropertyValue"; //TODO: Adapt

            var updatedPriceList = connector.Update(createdPriceList); 
            MyAssert.HasNoError(connector);
            Assert.AreEqual("UpdatedPropertyValue", updatedPriceList.SomeProperty); //TODO: Adapt

            #endregion UPDATE

            #region READ / GET

            var retrievedPriceList = connector.Get(createdPriceList.Code); //TODO: Check ID property
            MyAssert.HasNoError(connector);
            Assert.AreEqual("UpdatedPropertyValue", retrievedPriceList.SomeProperty); //TODO: Adapt

            #endregion READ / GET

            #region DELETE

            connector.Delete(createdPriceList.Code); //TODO: Check ID property
            MyAssert.HasNoError(connector);

            retrievedPriceList = connector.Get(createdPriceList.Code); //TODO: Check ID property
            Assert.AreEqual(null, retrievedPriceList, "Entity still exists after Delete!");

            #endregion DELETE

            #region Delete arranged resources
            //Add code to delete temporary resources
            #endregion Delete arranged resources
        }
    }
}
