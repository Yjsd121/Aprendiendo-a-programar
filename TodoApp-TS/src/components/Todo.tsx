import type React from "react";
import { type Todoid, type Todo as TodoType } from "../type.d";

interface Props extends TodoType {
  ontogglecompleted: ({
    id,
    completed,
  }: Pick<TodoType, "id" | "completed">) => void;
  onremovetodo: ({ id }: Todoid) => void;
}

export const Todo: React.FC<Props> = ({
  id,
  title,
  completed,
  onremovetodo,
  ontogglecompleted,
}) => {
  const handlecheck = (event: React.ChangeEvent<HTMLInputElement>): void => {
    ontogglecompleted({ id, completed: event.target.checked });
  };
  return (
    <div key={id} className="View">
      <input
        className="toggle"
        type="checkbox"
        checked={completed}
        onChange={handlecheck}
      />
      <label>{title}</label>
      <button
        className="destroy"
        onClick={() => {
          onremovetodo({ id });
        }}
      />
    </div>
  );
};
