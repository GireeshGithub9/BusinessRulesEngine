using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBusinessRulesEngine
{
    [TestClass]
    public class ProcessOrdersTest
    {
        [TestMethod]
        public void GetOrderTypeTest()
        {
            OrderDetails od = new OrderDetails();
            od.OrderType = OrderType.BOOK;
            od.UserEmail = "gg@gmail.com";
            Assert.AreEqual(null, od);
        }

        [TestMethod]
        public void ProcessBookOrderTest()
        {
            OrderDetails od = new OrderDetails();
            od.OrderType = OrderType.BOOK;
            od.UserEmail = "gg@gmail.com";
            RuleResponse bookOrdered = obj.handleOrder(od);
            Assert.AreEqual(null, od);
            Assert.AreEqual(true, bookOrdered.BookOrder);
        }
        [TestMethod]
        public void ProcessPhysicalProductOrderTest()
        {
            OrderDetails od = new OrderDetails();
            od.OrderType = OrderType.PHYSICAL_PRODUCT;
            od.UserEmail = "gg@gmail.com";
            od.AgentContact = "myAgent";
            RuleResponse physicalProductOrder = obj.handleOrder(od);
            Assert.AreEqual(null, od);
            Assert.AreEqual(true, physicalProductOrder.ComissionCredited);
            Assert.AreEqual(true, physicalProductOrder.EmailSent);
        }

        [TestMethod]
        public void ProcessNewMembershipOrderTest()
        {
            OrderDetails od = new OrderDetails();
            od.OrderType = OrderType.NEW_MEMBERSHIP;
            od.UserEmail = "gg@gmail.com";
            RuleResponse newMemberShipOrder = obj.handleOrder(od);
            Assert.AreEqual(true, newMemberShipOrder.NewMembership);

        }

        [TestMethod]
        public void ProcessUpgradeMembershipOrderTest()
        {
            OrderDetails od = new OrderDetails();
            od.OrderType = OrderType.UPGRADE_MEMBERSHIP;
            od.UserEmail = "gg@gmail.com";
            RuleResponse upgradeMemberShipOrder = obj.handleOrder(od);
            Assert.AreEqual(true, upgradeMemberShipOrder.UPGRADE_MEMBERSHIP);

        }

        [TestMethod]
        public void ProcessLearningToSkiOrderTest()
        {
            OrderDetails od = new OrderDetails();
            od.OrderType = OrderType.LEARNING_TO_SKI;
            od.UserEmail = "gg@gmail.com";
            RuleResponse upgradeMemberShipOrder = obj.handleOrder(od);
            Assert.AreEqual(true, upgradeMemberShipOrder.LEARNING_TO_SKI);

        }
    }
}
