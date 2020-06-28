using System;
using BusinessRulesEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBusinessRulesEngine
{
    [TestClass]
    public class ProcessOrdersTest
    {
        //Test method for checking OrderDetails object
        [TestMethod]
        public void GetOrderDetailsTest()
        {
            OrderDetails od = new OrderDetails();
            od.OrderType = OrderType.BOOK;
            od.UserEmail = "gg@gmail.com";
            Assert.AreNotEqual(null, od);
        }

        //////Test method for processing BOOK OrderDetails object
        [TestMethod]
        public void ProcessBookOrderTest()
        {
            OrderDetails od = new OrderDetails();
            od.OrderType = OrderType.BOOK;
            od.UserEmail = "gg@gmail.com";
            HandleOrder obj = new HandleOrder();
            RuleResponse bookOrdered = obj.handleOrder(od);
            Assert.AreNotEqual(null, od);
            Assert.AreEqual(true, bookOrdered.BookOrder);
        }


        //Test method for processing PHYSICAL_PRODUCT OrderDetails object
        [TestMethod]
        public void ProcessPhysicalProductOrderComissionSentTest()
        {
            OrderDetails od = new OrderDetails();
            od.OrderType = OrderType.PHYSICAL_PRODUCT;
            od.UserEmail = "gg@gmail.com";
            od.AgentContact = "myAgent";
            HandleOrder obj = new HandleOrder();
            RuleResponse physicalProductOrder = obj.handleOrder(od);
            Assert.AreNotEqual(null, od);
            Assert.AreEqual(true, physicalProductOrder.ComissionCredited);

        }
        //Test method for processing PHYSICAL_PRODUCT OrderDetails object
        [TestMethod]
        public void ProcessPhysicalProductOrderEmilSentTest()
        {
            OrderDetails od = new OrderDetails();
            od.OrderType = OrderType.PHYSICAL_PRODUCT;
            od.UserEmail = "gg@gmail.com";
            od.AgentContact = "myAgent";
            HandleOrder obj = new HandleOrder();
            RuleResponse physicalProductOrder = obj.handleOrder(od);
            Assert.AreNotEqual(null, od);

            Assert.AreEqual(true, physicalProductOrder.EmailSent);
        }
        ////Test method for processing NEW_MEMBERSHIP OrderDetails object
        [TestMethod]
        public void ProcessNewMembershipOrderTest()
        {
            OrderDetails od = new OrderDetails();
            od.OrderType = OrderType.NEW_MEMBERSHIP;
            od.UserEmail = "gg@gmail.com";
            HandleOrder obj = new HandleOrder();
            RuleResponse newMemberShipOrder = obj.handleOrder(od);
            Assert.AreNotEqual(null, od);
            Assert.AreEqual(true, newMemberShipOrder.NewMembership);

         }
        //Test method for processing UPGRADE_MEMBERSHIP OrderDetails object
        [TestMethod]
        public void ProcessUpgradeMembershipOrderTest()
        {
            OrderDetails od = new OrderDetails();
            od.OrderType = OrderType.UPGRADE_MEMBERSHIP;
            od.UserEmail = "gg@gmail.com";
            HandleOrder obj = new HandleOrder();
            RuleResponse upgradeMemberShipOrder = obj.handleOrder(od);
            Assert.AreNotEqual(null, od);
            Assert.AreEqual(true, upgradeMemberShipOrder.UpgradeMembership);
        }
        ////Test method for processing LEARNING_TO_SKI OrderDetails object
        [TestMethod]
        public void ProcessLearningToSkiOrderTest()
        {
            OrderDetails od = new OrderDetails();
            od.OrderType = OrderType.LEARNING_TO_SKI;
            od.UserEmail = "gg@gmail.com";
            HandleOrder obj = new HandleOrder();
            RuleResponse upgradeMemberShipOrder = obj.handleOrder(od);
            Assert.AreNotEqual(null, od);
            Assert.AreEqual(true, upgradeMemberShipOrder.LearnToSki);

        }
    }
}
