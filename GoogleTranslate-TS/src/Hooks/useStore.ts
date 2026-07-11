import {
  type State,
  type Action,
  type Langauge,
  type fromLanguage,
} from "../types.d";
import { useReducer } from "react";
//1. Crear los estaos inicales
export const initialState: State = {
  fromLanguage: "auto",
  toLanguage: "en",
  fromText: "",
  result: "",
  loading: false,
};

//2. crear el Reducer
export function reducer(state: State, action: Action) {
  const { type } = action;

  if (type === "INTERCHANGE_LANGUAGES") {
    return {
      ...state,
      fromLanguage: state.toLanguage,
      toLanguage: state.fromLanguage,
    };
  }

  if (type === "SET_FROM_LANGUAGE") {
    return {
      ...state,
      fromLanguage: action.payload,
    };
  }

  if (type === "SET_TO_LANGUAGE") {
    return {
      ...state,
      toLanguage: action.payload,
    };
  }

  if (type === "SET_FROM_TEXT") {
    return {
      ...state,
      loading: true,
      fromText: action.payload,
      result: "",
    };
  }

  if (type === "SET_RESULT") {
    return {
      ...state,
      loading: true,
      result: action.payload,
    };
  }

  return state;
}

export function useStore() {
  //3. Usar el Hook userducer
  const [{ fromLanguage, toLanguage, fromText, result, loading }, distpatch] =
    useReducer(reducer, initialState);

  const interchangeLanguages = () => {
    distpatch({ type: "INTERCHANGE_LANGUAGES" });
  };
  const setFromLanguages = (payload: fromLanguage) => {
    distpatch({ type: "SET_FROM_LANGUAGE", payload });
  };
  const setToLanguage = (payload: Langauge) => {
    distpatch({ type: "SET_TO_LANGUAGE", payload });
  };
  const setFromText = (payload: string) => {
    distpatch({ type: "SET_FROM_TEXT", payload });
  };
  const setResult = (payload: string) => {
    distpatch({ type: "SET_RESULT", payload });
  };

  return {
    fromLanguage,
    toLanguage,
    fromText,
    result,
    loading,
    interchangeLanguages,
    setFromLanguages,
    setToLanguage,
    setFromText,
    setResult,
  };
}
