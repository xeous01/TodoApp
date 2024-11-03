using System.Collections.Generic;
using System.Linq;

namespace TodoApp.Models
{
    public class TodoRepositoryInMemory : ITodoRepository
    {
        private static List<Todo> _tododos = new List<Todo>();

        public TodoRepositoryInMemory()
        {
            _tododos = new List<Todo>
               {

                   new Todo {Id = 1, Title = "ASP.NET Core 학습" , IsDone = false},
                   new Todo {Id = 2, Title = "Blazoe 학습" , IsDone = false},
                   new Todo {Id = 3, Title = "C# 학습" , IsDone = true}

               };
        }
        // 인 메모리 데이터 베이스 사용영역
        public void Add(Todo model)
        {
            model.Id = _tododos.Max(t => t.Id) + 1;
            _tododos.Add(model);
        }

        public List<Todo> GetAll()
        {
            return _tododos.ToList();
        }
    }


}
