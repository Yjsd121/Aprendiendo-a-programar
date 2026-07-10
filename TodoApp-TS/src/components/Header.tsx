import type { TodoTitle } from "../type";
import { CreateTodo } from "./CreateTodo";

interface Props {
  addTodo: ({ title }: TodoTitle) => void;
}

export const HeaderTodo: React.FC<Props> = ({ addTodo }) => {
  return (
    <header className="header">
      <h1>
        TodoApp
        <img
          style={{ width: "20px" }}
          src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/typescript/typescript-plain.svg"
        />
      </h1>
      <CreateTodo addTodo={addTodo} />
    </header>
  );
};
