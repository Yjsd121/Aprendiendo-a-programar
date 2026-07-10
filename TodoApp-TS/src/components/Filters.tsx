import { FILTERS_BUTTONS } from "../const";
import { type FilterValue } from "../type.d";

interface Props {
  onFliterchange: (filter: FilterValue) => void;
  filterselected: FilterValue;
}

export const Filters: React.FC<Props> = ({
  filterselected,
  onFliterchange,
}) => {
  return (
    <ul className="filters">
      {Object.entries(FILTERS_BUTTONS).map(([ket, { href, literal }]) => {
        const isSeleted = ket === filterselected;
        const className = isSeleted ? "seleted" : "";
        return (
          <li key={ket}>
            <a
              href={href}
              onClick={(e) => {
                e.preventDefault();
                onFliterchange(ket as FilterValue);
              }}
              className={className}
            >
              {literal}
            </a>
          </li>
        );
      })}
    </ul>
  );
};
