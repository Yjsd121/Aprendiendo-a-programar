import { useState } from "react";
import type { JSX } from "react/jsx-runtime";
import { Todos } from "./components/Todos";
import {
  type FilterValue,
  type Todoid,
  type TodoTitle,
  type Todo as TodoType,
} from "./type.d";
import { TODO_FILTERS } from "./const";
import { Footer } from "./components/footer";
import { HeaderTodo } from "./components/Header";

const mocktodos = [
  {
    id: "1",
    title: "Cagar hoy",
    completed: true,
  },
  {
    id: "2",
    title: "todo2",
    completed: false,
  },
  {
    id: "3",
    title: "todo3",
    completed: false,
  },
];

const App = (): JSX.Element => {
  const [todos, settodos] = useState(mocktodos);
  const [filterSelected, SetFilterSelected] = useState<FilterValue>(
    TODO_FILTERS.ALL,
  );

  const handleDelete = ({ id }: Todoid) => {
    settodos(todos.filter((data) => data.id != id));
  };

  const Handlechange = ({
    id,
    completed,
  }: Pick<TodoType, "id" | "completed">) => {
    const newTods = todos.map((todo) => {
      if (todo.id === id) {
        return {
          ...todo,
          completed,
        };
      }
      return todo;
    });

    settodos(newTods);
  };

  const handfleFilterChange = (filter: FilterValue) => {
    SetFilterSelected(filter);
  };

  const HandleDeleteCompleted = () => {
    const newinfo = todos.filter((todo) => {
      return todo.completed != true;
    });
    settodos(newinfo);
  };

  const handleAddTodo = ({ title }: TodoTitle) => {
    const newTodo = {
      id: crypto.randomUUID(),
      title,
      completed: false,
    };
    const newTodos = [...todos, newTodo];
    settodos(newTodos);
  };

  const datafiltered = todos.filter((todo) => {
    if (filterSelected === TODO_FILTERS.ACTIVE) return !todo.completed;
    if (filterSelected === TODO_FILTERS.COMPLETED) return todo.completed;
    return todo;
  });

  const activeCounts = todos.filter((todo) => !todo.completed).length;

  const CompletedTodos = todos.length - activeCounts;

  const [EditId, setidEdit] = useState("");

  const handleEditDobleclick = ({ id }: Pick<TodoType, "id">) => {
    setidEdit(id);
  };

  const handleSaveEdit = ({ id, title }: Pick<TodoType, "id" | "title">) => {
    settodos((prevtodos) =>
      prevtodos.map((todo) =>
        todo.id === id
          ? {
              ...todo,
              title,
            }
          : todo,
      ),
    );
    setidEdit("");
  };
  return (
    <div className="todoapp">
      <HeaderTodo addTodo={handleAddTodo} />
      <Todos
        onSave={handleSaveEdit}
        isEditingiD={EditId}
        setEditvalue={handleEditDobleclick}
        ontogglecompleted={Handlechange}
        onremovetodo={handleDelete}
        todos={datafiltered}
      />
      <Footer
        activeCounts={activeCounts}
        FilterSelected={filterSelected}
        handleFilter={handfleFilterChange}
        completedCount={CompletedTodos}
        onClearCompleted={HandleDeleteCompleted}
      />
    </div>
  );
};
export default App;
