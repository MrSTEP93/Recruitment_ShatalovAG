using NUnit.Framework;
using Recruitment.DAL.Models.Recruitment;
using Recruitment.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment.DAL.Tests
{
    /// <summary>
    /// Класс с тестами одного из репозиториев (так же, включает тесты базового репозитория).
    /// 
    /// К сожалению, я пока не вывел для себя оптимального подхода к написанию тестов. 
    /// Нужно продолжать искать баланс между максимальным покрытием проверяемых методов 
    /// и минимальным повторением кода в тестах. Есть идеи, как можно этого добиться, буду пробовать в будущем. 
    /// </summary>
    [TestFixture]
    public class SelectionStageRepositoryTests
    {
        AppDbContext db;
        SelectionStageRepository repo;

        const string testName = "test stage 1";
        const string testDesc = "created by unit test";
        const string testDescEdit = "EDITED by unit test";

        [SetUp]
        public void Setup()
        {
            db = new();
            repo = new(db);
        }

        // не самая удачная попытка вынести часть повторяющегося кода в отдельный метод
        private SelectionStage GetTestItem(string searchName = testName)
        {
            var list = repo.GetAll();
            return list.Where(x => x.Name == searchName).First();
        }

        [Test]
        public async Task CRUD_MustWork()
        {
            SelectionStage item = new(testName) { Description = testDesc };
            await repo.Create(item);

            var list = repo.GetAll();
            var testItem = list.Where(x => x.Name == testName).First();
            Assert.That(testItem.Name == testName);

            testItem.Description = testDescEdit;
            await repo.Update(testItem);
            testItem = GetTestItem();
            Assert.That(testItem.Description == testDescEdit);

            var selectedItem = repo.Get(testItem.Id).Result;
            Assert.That(selectedItem == testItem);

            await repo.Delete(selectedItem);
            list = repo.GetAll();
            Assert.That(!list.Contains(testItem));
        }

        // пришлось повторять создание и удаление..
        [Test]
        public async Task SetDescription_MustChangeProperty()
        {
            await repo.AddStage(testName, testDesc);
            var testItem = GetTestItem();
            await repo.SetDescription(testItem, testDescEdit);
            testItem = GetTestItem();
            Assert.That(testItem.Description == testDescEdit);

            await repo.Delete(testItem);
        }

    }
}
