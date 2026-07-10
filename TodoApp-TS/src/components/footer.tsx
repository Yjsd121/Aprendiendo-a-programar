import type { FilterValue } from "../type.d";
import { Filters } from "./Filters";

interface Props {
  activeCounts: number;
  completedCount: number;
  onClearCompleted: () => void;
  FilterSelected: FilterValue;
  handleFilter: (filter: FilterValue) => void;
}

export const Footer: React.FC<Props> = ({
  activeCounts = 0,
  completedCount = 0,
  onClearCompleted,
  FilterSelected,
  handleFilter,
}) => {
  return (
    <footer className="footer">
      <span className="todo-count">
        <strong>{activeCounts}</strong> Tareas pedientes
      </span>

      <Filters filterselected={FilterSelected} onFliterchange={handleFilter} />
      {completedCount > 0 && (
        <button className="clear-completed" onClick={onClearCompleted}>
          Delete completed
        </button>
      )}
    </footer>
  );
};
