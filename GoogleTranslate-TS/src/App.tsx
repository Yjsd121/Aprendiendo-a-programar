import "./App.css";
import { useStore } from "./Hooks/useStore";

function App() {
  const { fromLanguage, setFromLanguages } = useStore();
  return (
    <div className="App">
      <h1>Google Translate</h1>
      <button
        onClick={() => {
          setFromLanguages("es");
          
        }}
      >
        Cambiar Lenague
      </button>
      {fromLanguage}
    </div>
  );
}

export default App;
