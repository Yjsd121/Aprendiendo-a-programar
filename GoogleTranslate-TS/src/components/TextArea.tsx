import { Form } from "react-bootstrap";
import { SelectType } from "../types.d";

interface Pops {
  type: SelectType;
  loading?: boolean;
  onChange: (value: string) => void;
  value: string;
}

const commonStyles = { border: 0, height: "200px" };

const getPlaceholder = ({
  type,
  loading,
}: {
  type: SelectType;
  loading?: boolean;
}) => {
  if (type === SelectType.From) return "Introduce un texto";
  if (loading === true) return "Traduciendo...";
  return "Traducir";
};

export const Textarea: React.FC<Pops> = ({
  loading,
  type,
  value,
  onChange,
}) => {
  const styles =
    type === SelectType.From
      ? commonStyles
      : { ...commonStyles, backgroundColor: "#f5f5f5" };

  const handleChange = (e: React.ChangeEvent<HTMLTextAreaElement>) => {
    onChange(e.target.value);
  };
  return (
    <Form.Control
      autoFocus={type === SelectType.From}
      type={type}
      disabled={type===SelectType.To}
      as="textarea"
      placeholder={getPlaceholder({ type, loading })}
      style={styles}
      value={value}
      onChange={handleChange}
    />
  );
};
