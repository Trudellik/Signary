import React, { useState } from 'react';
import SignDisplay from '../../contexts/SignDisplay';
import { mockSigns } from '../../assets/mockData';
import { Sign } from '../../models/SignModel';
import Searchbar from '../../contexts/Searchbar';
import './Home.css';

const Home = () => {
  const [filters, setFilters] = useState({
    handshape: '',
    handsusage: '',
    mouthing: '',
  });

  const handleFilterChange = (newFilters) => {
    setFilters(newFilters);
  };

  const filteredSigns: Sign[] = mockSigns.filter((sign) => {
    const matchesHandshape =
      !filters.handshape || sign.expression.handshape === filters.handshape;
    const matchesHandsUsage =
      !filters.handsusage || sign.expression.handsusage === filters.handsusage;
    const matchesMouthing =
      !filters.mouthing ||
      sign.detailSigns.some(
        (detailSign) => detailSign.mouthing.mouthingType === filters.mouthing
      );

    return matchesHandshape && matchesHandsUsage && matchesMouthing;
  });

  return (
    <div className="page">
      <div className="grid-container">
        <div className="grid-item searchbar">
          <Searchbar onFilterChange={handleFilterChange} />
        </div>
        <div className="grid-item sign-list">
          {filteredSigns.map((sign) => (
            <SignDisplay key={sign.id} sign={sign} />
          ))}
        </div>
      </div>
    </div>
  );
};

export default Home;
