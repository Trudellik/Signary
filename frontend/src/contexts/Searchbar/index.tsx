import React, { useState } from 'react';
import { Typography } from 'antd';
import './Searchbar.css';
import HandshapeSelect from './Selects/HandshapeSelect';
import HandsUsageSelect from './Selects/HandsUsageSelect';
import MouthingSelect from './Selects/MouthingSelect';

const { Title } = Typography;

interface SearchbarProps {
  onFilterChange: (filters: Filters) => void;
}

interface Filters {
  handshape: string;
  handsusage: string;
  mouthing: string;
}

const Searchbar: React.FC<SearchbarProps> = ({ onFilterChange }) => {
  const [filters, setFilters] = useState<Filters>({
    handshape: '',
    handsusage: '',
    mouthing: '',
  });

  const handleSelectChange =
    (name: keyof Filters) => (value: string | null) => {
      setFilters((prevFilters) => {
        const updatedFilters = { ...prevFilters, [name]: value ?? '' };
        onFilterChange(updatedFilters);
        return updatedFilters;
      });
    };

  return (
    <div className="searchbar">
      <Title level={4}>Filter Signs</Title>
      <div>
        <HandshapeSelect
          value={filters.handshape}
          onChange={handleSelectChange('handshape')}
        />
      </div>
      <div>
        <HandsUsageSelect
          value={filters.handsusage}
          onChange={handleSelectChange('handsusage')}
        />
      </div>
      <div>
        <MouthingSelect
          value={filters.mouthing}
          onChange={handleSelectChange('mouthing')}
        />
      </div>
    </div>
  );
};

export default Searchbar;
