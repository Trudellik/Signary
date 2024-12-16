import React from 'react';
import { Typography } from 'antd';
import './DefinitionPost.css';

const {Title} = Typography;

interface MouthingRangeProps {
  mouthings: string[];
}

const MouthingRange = ({ mouthings }:MouthingRangeProps) => {
  return (
    <div className="mouthing-range">
      <Title level={5}>Bøjninger</Title>
      <div className='mouthing-list'>
        {mouthings.map((mouthing, index) => (
          <div key={index} className="mouthing-item">
            <img
              //src={}
              alt={`${mouthing} icon`}
              style={{ width: '20px', marginRight: '8px' }}
            />
            <span>{mouthing}</span>
          </div>
        ))}
      </div>
    </div>
  );
};

export default MouthingRange;
