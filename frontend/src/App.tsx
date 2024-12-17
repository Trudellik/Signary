import { Route, Routes } from 'react-router-dom';
import Home from './components/Home';
import './App.css';
import Header from './components/Header';
import Footer from './components/Footer';
import NotFound from './components/NotFound';
import EntrySignForm from './components/EntrySignForm';

function App() {
  return (
    <div className="App">
      <Header />
      <main className="main">
        <Routes>
          <Route index element={<Home />} />
          <Route path='signform' element={<EntrySignForm />} />
          <Route path="*" element={<NotFound />} />
        </Routes>
      </main>
      <Footer />
    </div>
  );
}

export default App;
