import {
  type ListOfTodos,
  type Todoid,
  type Todo as TodoType,
} from "../type.d";
import { Todo } from "../components/Todo";
import React, { useState } from "react";

interface Props {
  todos: ListOfTodos;
  ontogglecompleted: ({
    id,
    completed,
  }: Pick<TodoType, "id" | "completed">) => void;
  onremovetodo: ({ id }: Todoid) => void;
  isEditingiD: string;
  setEditvalue: ({ id }: Pick<TodoType, "id">) => void;
  onSave: ({ id, title }: Pick<TodoType, "id" | "title">) => void;
}

export const Todos: React.FC<Props> = ({
  onremovetodo,
  todos,
  ontogglecompleted,
  isEditingiD,
  setEditvalue,
  onSave,
}) => {
  const [InputValue, setInputValue] = useState("");

  const handleEdit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    onSave({ id: isEditingiD, title: InputValue });
    
  };

  return (
    <ul className="todo-list">
      {todos.map((todo) =>
        isEditingiD === todo.id ? (
          <form onSubmit={handleEdit} key={isEditingiD}>
            <input
              className="new-todo"
              value={InputValue}
              onChange={(e) => {
                setInputValue(e.target.value);
              }}
              onKeyDown={() => {}}
              autoFocus
            />
          </form>
        ) : (
          <li
            key={todo.id}
            className={`${todo.completed ? "completed" : ""}`}
            onDoubleClick={() => {
              setInputValue(todo.title);
              setEditvalue({ id: todo.id });
            }}
          >
            <Todo
              ontogglecompleted={ontogglecompleted}
              onremovetodo={onremovetodo}
              id={todo.id}
              title={todo.title}
              completed={todo.completed}
            />
          </li>
        ),
      )}
    </ul>
  );
};
