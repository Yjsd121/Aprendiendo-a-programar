import React, { useState } from "react";
import type { TodoTitle } from "../type.d";

interface Props {
  addTodo: ({ title }: TodoTitle) => void;
}

export const CreateTodo: React.FC<Props> = ({ addTodo }) => {
  const [InputValue, setInputValue] = useState("");

  const handleSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    addTodo({ title: InputValue });
    setInputValue("");
  };

  return (
    <form onSubmit={handleSubmit}>
      <input
        className="new-todo"
        value={InputValue}
        onChange={(e) => {
          setInputValue(e.target.value);
        }}
        onKeyDown={() => {}}
        placeholder="Nueva Tarea"
        autoFocus
      />
    </form>
  );
};
