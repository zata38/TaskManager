using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskManagerBackend
{
    public class TaskWrapper
    {
		internal class TaskItem
		{
			public TaskFlags _taskFlags;
            public string _name;
			public string _comment;
            public DateTime _dueDate;
		}

        TaskItem _task;

		bool HasChildren { get { return _children != null; } }
		List<TaskWrapper> _children;

		bool HasParent { get { return _parent != null; } }
		TaskWrapper _parent;

        public TaskWrapper(DateTime initDue, string initName, string initComment, TaskFlags initFlags)
		{
            _task = new TaskItem();
			_task._taskFlags = initFlags;
			_task._name = initName;
			_task._comment = initComment;
			_task._dueDate = initDue;
		}

        public void AddChild (TaskWrapper existingChild)
        {
            if (!HasChildren) _children = new List<TaskWrapper>();
            _children.Add(existingChild);
        }

        public void SetParent (TaskWrapper newParent)
        {
            _parent = newParent;
        }

        public void AddFlag(TaskFlags flag)
        {
            _task._taskFlags |= flag;
        }

        public void ClearFlags()
        {
            _task._taskFlags = TaskFlags.None;
        }

        public void RemoveFlag(TaskFlags flag)
        {
            _task._taskFlags ^= flag;
        }
    }
}
