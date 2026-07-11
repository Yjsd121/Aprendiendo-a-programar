import { Form } from "react-bootstrap";
import { AUTO_LANGUAGE, SUPPORTED_LANGUAGES } from "../constants";
import type React from "react";
import { SelectType, type fromLanguage, type Langauge } from "../types.d";

type Props =
  | {
      type: SelectType.From;
      value: fromLanguage;
      onChange: (langauge: fromLanguage) => void;
    }
  | { type: SelectType.To; value: Langauge; onChange: (langauge: Langauge) => void };

export const LanguageSelector: React.FC<Props> = ({
  onChange,
  type,
  value,
}) => {
  const HandleChange = (e: React.ChangeEvent<HTMLSelectElement>) => {
    onChange(e.target.value as Langauge);
  };

  return (
    <Form.Select
      aria-label="Selecciona el idioma"
      onChange={HandleChange}
      value={value}
    >
      {type === SelectType.From && (
        <option value={AUTO_LANGUAGE}>Detectar idioma</option>
      )}
      {Object.entries(SUPPORTED_LANGUAGES).map(([key, literal]) => (
        <option key={key} value={key}>
          {literal}
        </option>
      ))}
    </Form.Select>
  );
};
