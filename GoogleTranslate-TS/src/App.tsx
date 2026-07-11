import "bootstrap/dist/css/bootstrap.min.css";
import { Container, Row, Col, Button, Stack } from "react-bootstrap";
import "./App.css";
import { useStore } from "./Hooks/useStore";
import { ArrowsIcon } from "./components/Icons";
import { LanguageSelector } from "./components/SelectLangeuage";
import { SelectType } from "./types.d";
import { Textarea } from "./components/TextArea";

function App() {
  const {
    toLanguage,
    fromLanguage,
    fromText,
    result,
    loading,
    setFromLanguages,
    setToLanguage,
    interchangeLanguages,
    setFromText,
    setResult,
  } = useStore();
  return (
    <Container fluid>
      <h1>Google Translate</h1>
      <Row>
        <Col>
          <Stack gap={2}>
            <LanguageSelector
              type={SelectType.From}
              value={fromLanguage}
              onChange={setFromLanguages}
            />
            <Textarea
              type={SelectType.From}
              value={fromText}
              onChange={setFromText}
            />
          </Stack>
        </Col>

        <Col xs="auto">
          <Button
            variant="link"
            onClick={() => {
              interchangeLanguages();
            }}
          >
            <ArrowsIcon />
          </Button>
        </Col>

        <Col>
          <Stack gap={2}>
            <LanguageSelector
              type={SelectType.To}
              value={toLanguage}
              onChange={setToLanguage}
            />
            <Textarea
              loading={loading}
              type={SelectType.To}
              value={result}
              onChange={setResult}
            />
          </Stack>
        </Col>
      </Row>
    </Container>
  );
}

export default App;
